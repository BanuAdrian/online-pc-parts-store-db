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
    public partial class FormAngajati : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodAng;

        public FormAngajati()
        {
            InitializeComponent();
        }

        void getAngajati()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM ANGAJATI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            ANG_dgwAngajati.DataSource = dt;
            conn.Close();
        }

        private void FormAngajati_Load(object sender, EventArgs e)
        {
            getAngajati();
        }

        private void ANG_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "ANGAJATI VALUES (:COD_ANGAJAT, " +
                ":NUME, " +
                ":PRENUME, " +
                ":EMAIL, " +
                ":TELEFON, " +
                ":SALARIU, " +
                ":DATA_ANGAJARE, " +
                ":COD_DEPARTAMENT)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_ANGAJAT", ANG_txtCodAngajat.Text);
            cmd.Parameters.Add(":NUME", ANG_txtNume.Text);
            cmd.Parameters.Add(":PRENUME", ANG_txtPrenume.Text);
            cmd.Parameters.Add(":EMAIL", ANG_txtEmail.Text);
            cmd.Parameters.Add(":TELEFON", ANG_txtTel.Text);
            cmd.Parameters.Add(":SALARIU", ANG_txtSalariu.Text);
            cmd.Parameters.Add(":DATA_ANGAJARE", ANG_dpDataAng.Text);
            cmd.Parameters.Add(":COD_DEPARTAMENT", ANG_txtCodDpt.Text);
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
                MessageBox.Show("Angajatul a fost inserat cu succes.");
            getAngajati();
        }

        private void ANG_btnUpdate_Click(object sender, EventArgs e)
        {
            if (ANG_txtCodAngajat.Text != "")
            {
                var query = "UPDATE ANGAJATI " +
                    "SET COD_ANGAJAT = :COD_ANGAJAT, " +
                    "NUME = :NUME, " +
                    "PRENUME = :PRENUME, " +
                    "EMAIL = :EMAIL, " +
                    "TELEFON = :TELEFON, " +
                    "SALARIU = :SALARIU, " +
                    "DATA_ANGAJARE = :DATA_ANGAJARE, " +
                    "COD_DEPARTAMENT = :COD_DEPARTAMENT " +
                    "WHERE COD_ANGAJAT = :COD_ANGAJAT";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_ANGAJAT", ANG_txtCodAngajat.Text);
                cmd.Parameters.Add(":NUME", ANG_txtNume.Text);
                cmd.Parameters.Add(":PRENUME", ANG_txtPrenume.Text);
                cmd.Parameters.Add(":EMAIL", ANG_txtEmail.Text);
                cmd.Parameters.Add(":TELEFON", ANG_txtTel.Text);
                cmd.Parameters.Add(":SALARIU", ANG_txtSalariu.Text);
                cmd.Parameters.Add(":DATA_ANGAJARE", ANG_dpDataAng.Text);
                cmd.Parameters.Add(":COD_DEPARTAMENT", ANG_txtCodDpt.Text);
                cmd.Parameters.Add(":COD_ANGAJAT", tempCodAng);
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
                    MessageBox.Show("Angajatul a fost actualizat cu succes.");
                getAngajati();
            }
        }

        private void ANG_btnDelete_Click(object sender, EventArgs e)
        {
            if (ANG_txtCodAngajat.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM ANGAJATI WHERE COD_ANGAJAT = :COD_ANGAJAT ";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_ANGAJAT", ANG_txtCodAngajat.Text);
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
                        MessageBox.Show("Angajatul a fost sters cu succes.");
                    getAngajati();
                }
            }
        }

        private void ANG_dgwAngajati_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ANG_txtCodAngajat.Text = ANG_dgwAngajati.CurrentRow.Cells[0].Value.ToString();
            tempCodAng = ANG_txtCodAngajat.Text;
            ANG_txtNume.Text = ANG_dgwAngajati.CurrentRow.Cells[1].Value.ToString();
            ANG_txtPrenume.Text = ANG_dgwAngajati.CurrentRow.Cells[2].Value.ToString();
            ANG_txtEmail.Text = ANG_dgwAngajati.CurrentRow.Cells[3].Value.ToString();
            ANG_txtTel.Text = ANG_dgwAngajati.CurrentRow.Cells[4].Value.ToString();
            ANG_txtSalariu.Text = ANG_dgwAngajati.CurrentRow.Cells[5].Value.ToString();
            ANG_dpDataAng.Text = ANG_dgwAngajati.CurrentRow.Cells[6].Value.ToString();
            ANG_txtCodDpt.Text = ANG_dgwAngajati.CurrentRow.Cells[7].Value.ToString();
        }
        private void ANG_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_ANGAJAT, System.String) LIKE '%" + ANG_txtSearch.Text + "%'" +
                "OR NUME LIKE '%" + ANG_txtSearch.Text + "%'" +
                "OR PRENUME LIKE '%" + ANG_txtSearch.Text + "%'" +
                "OR EMAIL LIKE '%" + ANG_txtSearch.Text + "%'" +
                "OR TELEFON LIKE '%" + ANG_txtSearch.Text + "%'" +
                "OR Convert(SALARIU, System.String) LIKE '%" + ANG_txtSearch.Text + "%'" +
                "OR Convert(DATA_ANGAJARE, System.String) LIKE '%" + ANG_txtSearch.Text + "%'" +
                "OR Convert(COD_DEPARTAMENT, System.String) LIKE '%" + ANG_txtSearch.Text + "%'";
            ANG_dgwAngajati.DataSource = dv;
        }

        private void FormAngajati_Click(object sender, EventArgs e)
        {
            ANG_txtCodAngajat.Text = "";
            ANG_txtNume.Text = "";
            ANG_txtPrenume.Text = "";
            ANG_txtEmail.Text = "";
            ANG_txtTel.Text = "";
            ANG_txtSalariu.Text = "";
            ANG_dpDataAng.Text = "";
            ANG_txtCodDpt.Text = "";
        }
    }
}
