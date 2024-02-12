using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace InterfataBD
{
    public partial class FormComenzi : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodComanda;

        public FormComenzi()
        {
            InitializeComponent();
        }

        void getComenzi()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM COMENZI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            CMD_dgwComenzi.DataSource = dt;
            conn.Close();
        }

        private void FormComenzi_Load(object sender, EventArgs e)
        {
            getComenzi();
        }

        private void CMD_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "COMENZI VALUES (:COD_COMANDA, " +
                ":MODALITATE_PLATA, " +
                ":DATA_COMANDA, " +
                ":COD_CLIENT)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_COMANDA", CMD_txtCodCmd.Text);
            cmd.Parameters.Add(":MODALITATE_PLATA", CMD_listModPlata.Text);
            cmd.Parameters.Add(":DATA_COMANDA", CMD_dpDataCmd.Text);
            cmd.Parameters.Add(":COD_CLIENT", CMD_txtCodClient.Text);
            OracleException ex = null;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (OracleException tempEx)
            {
                ex = tempEx;
                MessageBox.Show(ex.Message.ToString());
            }
            conn.Close();
            if (ex == null)
                MessageBox.Show("Comanda a fost inserata cu succes.");
            getComenzi();
        }

        private void CMD_btnUpdate_Click(object sender, EventArgs e)
        {
            if (CMD_txtCodCmd.Text != "")
            {
                var query = "UPDATE COMENZI " +
                    "SET COD_COMANDA = :COD_COMANDA, " +
                    "MODALITATE_PLATA = :MODALITATE_PLATA, " +
                    "DATA_COMANDA = :DATA_COMANDA, " +
                    "COD_CLIENT = :COD_CLIENT " +
                    "WHERE COD_COMANDA = :COD_COMANDA";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_COMANDA", CMD_txtCodCmd.Text);
                cmd.Parameters.Add(":MODALITATE_PLATA", CMD_listModPlata.Text);
                cmd.Parameters.Add(":DATA_COMANDA", CMD_dpDataCmd.Text);
                cmd.Parameters.Add(":COD_CLIENT", CMD_txtCodClient.Text);
                cmd.Parameters.Add(":COD_COMANDA", tempCodComanda);
                OracleException ex = null;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException tempEx)
                {
                    ex = tempEx;
                    MessageBox.Show(ex.Message.ToString());
                }
                conn.Close();
                if (ex == null)
                    MessageBox.Show("Comanda a fost actualizata cu succes.");
                getComenzi();
            }
        }

        private void CMD_btnDelete_Click(object sender, EventArgs e)
        {
            if (CMD_txtCodCmd.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM COMENZI WHERE COD_COMANDA = :COD_COMANDA";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_CLIENT", CMD_txtCodCmd.Text);
                    OracleException ex = null;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException tempEx)
                    {
                        ex = tempEx;
                        MessageBox.Show(ex.Message.ToString());
                    }
                    conn.Close();
                    if (ex == null)
                        MessageBox.Show("Comanda a fost stearsa cu succes.");
                    getComenzi();
                }
            }
        }

        private void CMD_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_COMANDA, System.String) LIKE '%" + CMD_txtSearch.Text + "%'" +
                "OR MODALITATE_PLATA LIKE '%" + CMD_txtSearch.Text + "%'" +
                "OR Convert(DATA_COMANDA, System.String) LIKE '%" + CMD_txtSearch.Text + "%'" +
                "OR Convert(COD_CLIENT, System.String) LIKE '%" + CMD_txtSearch.Text + "%'";
            CMD_dgwComenzi.DataSource = dv;
        }

        private void CMD_dgwComenzi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CMD_txtCodCmd.Text = CMD_dgwComenzi.CurrentRow.Cells[0].Value.ToString();
            tempCodComanda = CMD_txtCodCmd.Text;
            CMD_listModPlata.Text = CMD_dgwComenzi.CurrentRow.Cells[1].Value.ToString();
            CMD_dpDataCmd.Text = CMD_dgwComenzi.CurrentRow.Cells[2].Value.ToString();
            CMD_txtCodClient.Text = CMD_dgwComenzi.CurrentRow.Cells[3].Value.ToString();
        }

        private void FormComenzi_Click(object sender, EventArgs e)
        {
            CMD_txtCodCmd.Text = "";
            CMD_listModPlata.Text = "";
            CMD_dpDataCmd.Text = "";
            CMD_txtCodClient.Text = "";
        }
    }
}
