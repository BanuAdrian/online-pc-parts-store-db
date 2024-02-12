using Oracle.ManagedDataAccess.Client;
using System;
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
    public partial class FormProducatori : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodProd;

        public FormProducatori()
        {
            InitializeComponent();
        }

        void getProducatori()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM PRODUCATORI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            PROD_dgwProducatori.DataSource = dt;
            conn.Close();
        }

        private void FormProducatori_Load(object sender, EventArgs e)
        {
            getProducatori();
        }

        private void PROD_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "PRODUCATORI VALUES (:COD_PRODUCATOR, " +
                ":NUME_PRODUCATOR, " +
                ":SITE_WEB)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_PRODUCATOR", PROD_txtCodProd.Text);
            cmd.Parameters.Add(":NUME_PRODUCATOR", PROD_txtNumeProd.Text);
            cmd.Parameters.Add(":SITE_WEB", PROD_txtSiteWeb.Text);
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
                MessageBox.Show("Producatorul a fost inserat cu succes.");
            getProducatori();
        }

        private void PROD_btnUpdate_Click(object sender, EventArgs e)
        {
            if (PROD_txtCodProd.Text != "")
            {
                var query = "UPDATE PRODUCATORI " +
                    "SET COD_PRODUCATOR = :COD_PRODUCATOR, " +
                    "NUME_PRODUCATOR = :NUME_PRODUCATOR, " +
                    "SITE_WEB = :SITE_WEB " +
                    "WHERE COD_PRODUCATOR = :COD_PRODUCATOR";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_PRODUCATOR", PROD_txtCodProd.Text);
                cmd.Parameters.Add(":NUME_PRODUCATOR", PROD_txtNumeProd.Text);
                cmd.Parameters.Add(":SITE_WEB", PROD_txtSiteWeb.Text);
                cmd.Parameters.Add(":COD_PRODUCATOR", tempCodProd);
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
                    MessageBox.Show("Producatorul a fost actualizat cu succes.");
                getProducatori();
            }
        }

        private void PROD_btnDelete_Click(object sender, EventArgs e)
        {
            if (PROD_txtCodProd.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM PRODUCATORI WHERE COD_PRODUCATOR = :COD_PRODUCATOR";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_PRODUCATOR", PROD_txtCodProd.Text);
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
                        MessageBox.Show("Producatorul a fost sters cu succes.");
                    getProducatori();
                }
            }
        }

        private void PROD_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "COD_PRODUCATOR LIKE '%" + PROD_txtSearch.Text + "%'" +
                "OR NUME_PRODUCATOR LIKE '%" + PROD_txtSearch.Text + "%'" +
                "OR SITE_WEB LIKE '%" + PROD_txtSearch.Text + "%'";
            PROD_dgwProducatori.DataSource = dv;
        }

        private void PROD_dgwProducatori_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PROD_txtCodProd.Text = PROD_dgwProducatori.CurrentRow.Cells[0].Value.ToString();
            tempCodProd = PROD_txtCodProd.Text;
            PROD_txtNumeProd.Text = PROD_dgwProducatori.CurrentRow.Cells[1].Value.ToString();
            PROD_txtSiteWeb.Text = PROD_dgwProducatori.CurrentRow.Cells[2].Value.ToString();
        }

        private void FormProducatori_Click(object sender, EventArgs e)
        {
            PROD_txtCodProd.Text = "";
            PROD_txtNumeProd.Text = "";
            PROD_txtSiteWeb.Text = "";
        }
    }
}
