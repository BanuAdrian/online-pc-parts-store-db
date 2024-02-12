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
    public partial class FormCategorii : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodCat;

        public FormCategorii()
        {
            InitializeComponent();
        }

        void getCategorii()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM CATEGORII", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            CAT_dgwCategorii.DataSource = dt;
            conn.Close();
        }

        private void FormCategorii_Load(object sender, EventArgs e)
        {
            getCategorii();
        }

        private void CAT_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "CATEGORII VALUES (:COD_CATEGORIE, " +
                ":NUME_CATEGORIE)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_CATEGORIE", CAT_txtCodCat.Text);
            cmd.Parameters.Add(":NUME_CATEGORIE", CAT_txtNumeCat.Text);
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
                MessageBox.Show("Categoria a fost inserata cu succes.");
            getCategorii();
        }

        private void CAT_btnUpdate_Click(object sender, EventArgs e)
        {
            if (CAT_txtCodCat.Text != "")
            {
                var query = "UPDATE CATEGORII " +
                    "SET COD_CATEGORIE = :COD_CATEGORIE, " +
                    "NUME_CATEGORIE = :NUME_CATEGORIE " +
                    "WHERE COD_CATEGORIE = :COD_CATEGORIE";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_CATEGORIE", CAT_txtCodCat.Text);
                cmd.Parameters.Add(":NUME_CATEGORIE", CAT_txtNumeCat.Text);
                cmd.Parameters.Add(":COD_CATEGORIE", tempCodCat);
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
                    MessageBox.Show("Categoria a fost actualizata cu succes.");
                getCategorii();
            }
        }

        private void CAT_btnDelete_Click(object sender, EventArgs e)
        {
            if (CAT_txtCodCat.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM CATEGORII WHERE COD_CATEGORIE = :COD_CATEGORIE";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_CATEGORIE", CAT_txtCodCat.Text);
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
                        MessageBox.Show("Categoria a fost stearsa cu succes.");
                    getCategorii();
                }
            }
        }

        private void CAT_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "COD_CATEGORIE LIKE '%" + CAT_txtSearch.Text + "%'" +
                "OR NUME_CATEGORIE LIKE '%" + CAT_txtSearch.Text + "%'";
            CAT_dgwCategorii.DataSource = dv;
        }

        private void CAT_dgwCategorii_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CAT_txtCodCat.Text = CAT_dgwCategorii.CurrentRow.Cells[0].Value.ToString();
            tempCodCat = CAT_txtCodCat.Text;
            CAT_txtNumeCat.Text = CAT_dgwCategorii.CurrentRow.Cells[1].Value.ToString();
        }

        private void FormCategorii_Click(object sender, EventArgs e)
        {
            CAT_txtCodCat.Text = "";
            CAT_txtNumeCat.Text = "";
        }
    }
}
