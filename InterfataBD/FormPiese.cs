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
    public partial class FormPiese : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodPiesa;

        public FormPiese()
        {
            InitializeComponent();
        }

        void getPiese()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM PIESE", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            PS_dgwPiese.DataSource = dt;
            conn.Close();
        }

        private void FormPiese_Load(object sender, EventArgs e)
        {
            getPiese();
        }

        private void PS_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "PIESE VALUES (:COD_PIESA, " +
                ":MODEL_PIESA, " +
                ":PRET_VANZARE, " +
                ":GARANTIE_COMERCIALA, " +
                ":COD_CATEGORIE, " +
                ":COD_PRODUCATOR) ";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_PIESA", PS_txtCodPiesa.Text);
            cmd.Parameters.Add(":MODEL_PIESA", PS_txtModelPiesa.Text);
            cmd.Parameters.Add(":PRET_VANZARE", PS_txtPretVanzare.Text);
            cmd.Parameters.Add(":GARANTIE_COMERCIALA", PS_txtGrt.Text);
            cmd.Parameters.Add(":COD_CATEGORIE", PS_txtCodCat.Text);
            cmd.Parameters.Add(":COD_PRODUCATOR", PS_txtCodProd.Text);
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
                MessageBox.Show("Piesa a fost inserata cu succes.");
            getPiese();
        }

        private void PS_btnUpdate_Click(object sender, EventArgs e)
        {
            if (PS_txtCodPiesa.Text != "")
            {
                var query = "UPDATE PIESE " +
                    "SET COD_PIESA = :COD_PIESA, " +
                    "MODEL_PIESA = :MODEL_PIESA, " +
                    "PRET_VANZARE = :PRET_VANZARE, " +
                    "GARANTIE_COMERCIALA = :GARANTIE_COMERCIALA, " +
                    "COD_CATEGORIE = :COD_CATEGORIE, " +
                    "COD_PRODUCATOR = :COD_PRODUCATOR " +
                    "WHERE COD_PIESA = :COD_PIESA";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_PIESA", PS_txtCodPiesa.Text);
                cmd.Parameters.Add(":MODEL_PIESA", PS_txtModelPiesa.Text);
                cmd.Parameters.Add(":PRET_VANZARE", PS_txtPretVanzare.Text);
                cmd.Parameters.Add(":GARANTIE_COMERCIALA", PS_txtGrt.Text);
                cmd.Parameters.Add(":COD_CATEGORIE", PS_txtCodCat.Text);
                cmd.Parameters.Add(":COD_PRODUCATOR", PS_txtCodProd.Text);
                cmd.Parameters.Add(":COD_PIESA", tempCodPiesa);
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
                    MessageBox.Show("Piesa a fost actualizata cu succes.");
                getPiese();
            }
        }

        private void PS_btnDelete_Click(object sender, EventArgs e)
        {
            if (PS_txtCodPiesa.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM PIESE WHERE COD_PIESA = :COD_PIESA";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_PIESA", PS_txtCodPiesa.Text);
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
                        MessageBox.Show("Piesa a fost stearsa cu succes.");
                    getPiese();
                }
            }
        }

        private void PS_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_PIESA, System.String) LIKE '%" + PS_txtSearch.Text + "%'" +
                "OR MODEL_PIESA LIKE '%" + PS_txtSearch.Text + "%'" +
                "OR Convert(PRET_VANZARE, System.String) LIKE '%" + PS_txtSearch.Text + "%'" +
                "OR Convert(GARANTIE_COMERCIALA, System.String) LIKE '%" + PS_txtSearch.Text + "%'" +
                "OR COD_CATEGORIE LIKE '%" + PS_txtSearch.Text + "%'" +
                "OR COD_PRODUCATOR LIKE '%" + PS_txtSearch.Text + "%'";
            PS_dgwPiese.DataSource = dv;
        }

        private void PS_dgwPiese_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PS_txtCodPiesa.Text = PS_dgwPiese.CurrentRow.Cells[0].Value.ToString();
            tempCodPiesa = PS_txtCodPiesa.Text;
            PS_txtModelPiesa.Text = PS_dgwPiese.CurrentRow.Cells[1].Value.ToString();
            PS_txtPretVanzare.Text = PS_dgwPiese.CurrentRow.Cells[2].Value.ToString();
            PS_txtGrt.Text = PS_dgwPiese.CurrentRow.Cells[3].Value.ToString();
            PS_txtCodCat.Text = PS_dgwPiese.CurrentRow.Cells[4].Value.ToString();
            PS_txtCodProd.Text = PS_dgwPiese.CurrentRow.Cells[5].Value.ToString();
        }

        private void FormPiese_Click(object sender, EventArgs e)
        {
            PS_txtCodPiesa.Text = "";
            PS_txtModelPiesa.Text = "";
            PS_txtPretVanzare.Text = "";
            PS_txtGrt.Text = "";
            PS_txtCodCat.Text = "";
            PS_txtCodProd.Text = "";
        }
    }
}
