using Oracle.ManagedDataAccess.Client;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataBD
{
    public partial class FormVizCompusa : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodCmd;

        public FormVizCompusa()
        {
            InitializeComponent();
        }

        void getVizCompusa()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM VIZ_COMPUSA", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            VCMP_dgwVizCompusa.DataSource = dt;
            conn.Close();
        }

        private void FormVizCompusa_Load(object sender, EventArgs e)
        {
            getVizCompusa();
        }

        private void VCMP_btnInsert_Click(object sender, EventArgs e)
        {
            VCMP_txtNume.Text = "";
            VCMP_txtPrenume.Text = "";
            var query = "INSERT INTO " +
                "VIZ_COMPUSA (COD_COMANDA, MODALITATE_PLATA, DATA_COMANDA, COD_CLIENT) VALUES (:COD_COMANDA, " +
                ":MODALITATE_PLATA, " +
                ":DATA_COMANDA, " +
                ":COD_CLIENT)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_COMANDA", VCMP_txtCodCmd.Text);
            cmd.Parameters.Add(":MODALITATE_PLATA", VCMP_listModPlata.Text);
            cmd.Parameters.Add(":DATA_COMANDA", VCMP_dpDataCmd.Text);
            cmd.Parameters.Add(":COD_CLIENT", VCMP_txtCodClient.Text);
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
                MessageBox.Show("Inregistrarea a fost inserata cu succes.");
            getVizCompusa();
        }

        private void VCMP_btnUpdate_Click(object sender, EventArgs e)
        {
            if (VCMP_txtCodCmd.Text != "")
            {
                VCMP_txtNume.Text = "";
                VCMP_txtPrenume.Text = "";
                var query = "UPDATE VIZ_COMPUSA " +
                    "SET COD_COMANDA = :COD_COMANDA, " +
                    "MODALITATE_PLATA = :MODALITATE_PLATA, " +
                    "DATA_COMANDA = :DATA_COMANDA, " +
                    "COD_CLIENT = :COD_CLIENT " +
                    "WHERE COD_COMANDA = :COD_COMANDA";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_COMANDA", VCMP_txtCodCmd.Text);
                cmd.Parameters.Add(":MODALITATE_PLATA", VCMP_listModPlata.Text);
                cmd.Parameters.Add(":DATA_COMANDA", VCMP_dpDataCmd.Text);
                cmd.Parameters.Add(":COD_CLIENT", VCMP_txtCodClient.Text);
                cmd.Parameters.Add(":COD_COMANDA", tempCodCmd);
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
                    MessageBox.Show("Inregistrarea a fost actualizata cu succes.");
                getVizCompusa();
            }
        }

        private void VCMP_btnDelete_Click(object sender, EventArgs e)
        {
            if (VCMP_txtCodCmd.Text != "")
            {
                VCMP_txtNume.Text = "";
                VCMP_txtPrenume.Text = "";
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM VIZ_COMPUSA WHERE COD_COMANDA = :COD_COMANDA";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_COMANDA", VCMP_txtCodCmd.Text);
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
                        MessageBox.Show("Inregistrarea a fost stearsa cu succes.");
                    getVizCompusa();
                }
            }
        }

        private void VCMP_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "NUME LIKE '%" + VCMP_txtSearch.Text + "%'" +
                "OR PRENUME LIKE '%" + VCMP_txtSearch.Text + "%'" +
                "OR Convert(COD_COMANDA, System.String) LIKE '%" + VCMP_txtSearch.Text + "%'" +
                "OR MODALITATE_PLATA LIKE '%" + VCMP_txtSearch.Text + "%'" +
                "OR Convert(DATA_COMANDA, System.String) LIKE '%" + VCMP_txtSearch.Text + "%'" +
                "OR Convert(COD_CLIENT, System.String) LIKE '%" + VCMP_txtSearch.Text + "%'";
            VCMP_dgwVizCompusa.DataSource = dv;
        }

        private void VCMP_dgwVizCompusa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            VCMP_txtNume.Text = VCMP_dgwVizCompusa.CurrentRow.Cells[0].Value.ToString();
            VCMP_txtPrenume.Text = VCMP_dgwVizCompusa.CurrentRow.Cells[1].Value.ToString();
            VCMP_txtCodCmd.Text = VCMP_dgwVizCompusa.CurrentRow.Cells[2].Value.ToString();
            tempCodCmd = VCMP_txtCodCmd.Text;
            VCMP_listModPlata.Text = VCMP_dgwVizCompusa.CurrentRow.Cells[3].Value.ToString();
            VCMP_dpDataCmd.Text = VCMP_dgwVizCompusa.CurrentRow.Cells[4].Value.ToString();
            VCMP_txtCodClient.Text = VCMP_dgwVizCompusa.CurrentRow.Cells[5].Value.ToString();
 
        }

        private void FormVizCompusa_Click(object sender, EventArgs e)
        {
            VCMP_txtNume.Text = "";
            VCMP_txtPrenume.Text = "";
            VCMP_txtCodCmd.Text = "";
            VCMP_listModPlata.Text = "";
            VCMP_dpDataCmd.Text = "";
            VCMP_txtCodClient.Text = "";
        }
    }
}
