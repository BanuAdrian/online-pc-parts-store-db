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
    public partial class FormDepartamente : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodDep;

        public FormDepartamente()
        {
            InitializeComponent();
        }

        void getDepartamente()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM DEPARTAMENTE", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            DPT_dgwDepartamente.DataSource = dt;
            conn.Close();
        }

        private void FormDepartamente_Load(object sender, EventArgs e)
        {
            getDepartamente();
        }

        private void DPT_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "DEPARTAMENTE VALUES (:COD_DEPARTAMENT, " +
                ":NUME_DEPARTAMENT)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_DEPARTAMENT", DPT_txtCodDpt.Text);
            cmd.Parameters.Add(":NUME_DEPARTAMENT", DPT_txtNumeDpt.Text);
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
                MessageBox.Show("Departamentul a fost inserat cu succes.");
            getDepartamente();
        }

        private void DPT_btnUpdate_Click(object sender, EventArgs e)
        {
            if (DPT_txtNumeDpt.Text != "")
            {
                var query = "UPDATE DEPARTAMENTE " +
                    "SET COD_DEPARTAMENT = :COD_DEPARTAMENT, " +
                    "NUME_DEPARTAMENT = :NUME_DEPARTAMENT " +
                    "WHERE COD_DEPARTAMENT = :COD_DEPARTAMENT";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_DEPARTAMENT", DPT_txtCodDpt.Text);
                cmd.Parameters.Add(":NUME_DEPARTAMENT", DPT_txtNumeDpt.Text);
                cmd.Parameters.Add(":COD_DEPARTAMENT", tempCodDep);
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
                    MessageBox.Show("Departamentul a fost actualizat cu succes.");
                getDepartamente();
            }
        }

        private void DPT_btnDelete_Click(object sender, EventArgs e)
        {
            if (DPT_txtNumeDpt.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM DEPARTAMENTE WHERE COD_DEPARTAMENT = :COD_DEPARTAMENT";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_DEPARTAMENT", DPT_txtCodDpt.Text);
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
                        MessageBox.Show("Departamentul a fost sters cu succes.");
                    getDepartamente();
                }
            }
        }

        private void DPT_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_DEPARTAMENT, System.String) LIKE '%" + DPT_txtSearch.Text + "%'" +
                "OR NUME_DEPARTAMENT LIKE '%" + DPT_txtSearch.Text + "%'";
            DPT_dgwDepartamente.DataSource = dv;
        }

        private void DPT_dgwComenzi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DPT_txtCodDpt.Text = DPT_dgwDepartamente.CurrentRow.Cells[0].Value.ToString();
            tempCodDep = DPT_txtCodDpt.Text;
            DPT_txtNumeDpt.Text = DPT_dgwDepartamente.CurrentRow.Cells[1].Value.ToString();
        }

        private void FormDepartamente_Click(object sender, EventArgs e)
        {
            DPT_txtCodDpt.Text = "";
            DPT_txtNumeDpt.Text = "";
        }
    }
}
