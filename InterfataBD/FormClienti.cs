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
    public partial class FormClienti : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodClient;

        public FormClienti()
        {
            InitializeComponent();
        }

        void getClienti()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM CLIENTI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            CLT_dgwClienti.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getClienti();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "CLIENTI VALUES (:COD_CLIENT, " +
                ":NUME, " +
                ":PRENUME, " +
                ":EMAIL, " +
                ":TELEFON, " +
                ":STRADA, " +
                ":NUMAR, " +
                ":LOCALITATE, " +
                ":JUDET)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_CLIENT", CLT_txtCodClient.Text);
            cmd.Parameters.Add(":NUME", CLT_txtNume.Text);
            cmd.Parameters.Add(":PRENUME", CLT_txtPrenume.Text);
            cmd.Parameters.Add(":EMAIL", CLT_txtEmail.Text);
            cmd.Parameters.Add(":TELEFON", CLT_txtTel.Text);
            cmd.Parameters.Add(":STRADA", CLT_txtStrClient.Text);
            cmd.Parameters.Add(":NUMAR", CLT_txtNrClient.Text);
            cmd.Parameters.Add(":LOCALITATE", CLT_txtLocClient.Text);
            cmd.Parameters.Add(":JUDET", CLT_txtJudClient.Text);
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
                MessageBox.Show("Clientul a fost inserat cu succes.");
            getClienti();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (CLT_txtCodClient.Text != "")
            {
                var query = "UPDATE CLIENTI " +
                    "SET COD_CLIENT = :COD_CLIENT, " +
                    "NUME = :NUME, " +
                    "PRENUME = :PRENUME, " +
                    "EMAIL = :EMAIL, " +
                    "TELEFON = :TELEFON, " +
                    "STRADA = :STRADA, " +
                    "NUMAR = :NUMAR, " +
                    "LOCALITATE = :LOCALITATE, " +
                    "JUDET = :JUDET " +
                    "WHERE COD_CLIENT = :COD_CLIENT";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_CLIENT", CLT_txtCodClient.Text);
                cmd.Parameters.Add(":NUME", CLT_txtNume.Text);
                cmd.Parameters.Add(":PRENUME", CLT_txtPrenume.Text);
                cmd.Parameters.Add(":EMAIL", CLT_txtEmail.Text);
                cmd.Parameters.Add(":TELEFON", CLT_txtTel.Text);
                cmd.Parameters.Add(":STRADA", CLT_txtStrClient.Text);
                cmd.Parameters.Add(":NUMAR", CLT_txtNrClient.Text);
                cmd.Parameters.Add(":LOCALITATE", CLT_txtLocClient.Text);
                cmd.Parameters.Add(":JUDET", CLT_txtJudClient.Text);
                cmd.Parameters.Add(":COD_CLIENT", tempCodClient);
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
                    MessageBox.Show("Clientul a fost actualizat cu succes.");
                getClienti();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CLT_txtCodClient.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM CLIENTI WHERE COD_CLIENT = :COD_CLIENT";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_CLIENT", CLT_txtCodClient.Text);
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
                        MessageBox.Show("Clientul a fost sters cu succes.");
                    getClienti();
                }
            }
        }

        private void dgwClienti_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CLT_txtCodClient.Text = CLT_dgwClienti.CurrentRow.Cells[0].Value.ToString();
            tempCodClient = CLT_txtCodClient.Text;
            CLT_txtNume.Text = CLT_dgwClienti.CurrentRow.Cells[1].Value.ToString();
            CLT_txtPrenume.Text = CLT_dgwClienti.CurrentRow.Cells[2].Value.ToString();
            CLT_txtEmail.Text = CLT_dgwClienti.CurrentRow.Cells[3].Value.ToString();
            CLT_txtTel.Text = CLT_dgwClienti.CurrentRow.Cells[4].Value.ToString();
            CLT_txtStrClient.Text = CLT_dgwClienti.CurrentRow.Cells[5].Value.ToString();
            CLT_txtNrClient.Text = CLT_dgwClienti.CurrentRow.Cells[6].Value.ToString();
            CLT_txtLocClient.Text = CLT_dgwClienti.CurrentRow.Cells[7].Value.ToString();
            CLT_txtJudClient.Text = CLT_dgwClienti.CurrentRow.Cells[8].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_CLIENT, System.String) LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR NUME LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR PRENUME LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR EMAIL LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR TELEFON LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR STRADA LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR NUMAR LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR LOCALITATE LIKE '%" + CLT_txtSearch.Text + "%'" +
                "OR JUDET LIKE '%" + CLT_txtSearch.Text + "%'";
            CLT_dgwClienti.DataSource = dv;
        }

        private void FormClienti_Click(object sender, EventArgs e)
        {
            CLT_txtCodClient.Text = "";
            CLT_txtNume.Text = "";
            CLT_txtPrenume.Text = "";
            CLT_txtEmail.Text = "";
            CLT_txtTel.Text = "";
            CLT_txtStrClient.Text = "";
            CLT_txtNrClient.Text = "";
            CLT_txtLocClient.Text = "";
            CLT_txtJudClient.Text = "";
        }
    }
}
