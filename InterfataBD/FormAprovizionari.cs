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
    public partial class FormAprovizionari : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodAprov;

        public FormAprovizionari()
        {
            InitializeComponent();
        }

        void getAprovizionari()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM APROVIZIONARI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            APROV_dgwAprovizionari.DataSource = dt;
            conn.Close();
        }

        private void FormAprovizionari_Load(object sender, EventArgs e)
        {
            getAprovizionari();
        }

        private void APROV_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "APROVIZIONARI VALUES (:COD_APROVIZIONARE, " +
                ":DATA_APROVIZIONARE, " +
                ":CANTITATE_CUMPARATA, " +
                ":PRET_CUMPARARE, " +
                ":COD_PIESA, " +
                ":CUI_FURNIZOR)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_APROVIZIONARE", APROV_txtCodAprov.Text);
            cmd.Parameters.Add(":DATA_APROVIZIONARE", APROV_dpDataAprov.Text);
            cmd.Parameters.Add(":CANTITATE_CUMPARATA", APROV_txtCC.Text);
            cmd.Parameters.Add(":PRET_CUMPARARE", APROV_txtPC.Text);
            cmd.Parameters.Add(":COD_PIESA", APROV_txtCodPiesa.Text);
            cmd.Parameters.Add(":CUI_FURNIZOR", APROV_txtCuiFnz.Text);
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
                MessageBox.Show("Aprovizionarea a fost inserata cu succes.");
            getAprovizionari();
        }

        private void APROV_btnUpdate_Click(object sender, EventArgs e)
        {
            if (APROV_txtCodAprov.Text != "")
            {
                var query = "UPDATE APROVIZIONARI " +
                    "SET COD_APROVIZIONARE = :COD_APROVIZIONARE, " +
                    "DATA_APROVIZIONARE = :DATA_APROVIZIONARE, " +
                    "CANTITATE_CUMPARATA = :CANTITATE_CUMPARATA, " +
                    "PRET_CUMPARARE = :PRET_CUMPARARE, " +
                    "COD_PIESA = :COD_PIESA, " +
                    "CUI_FURNIZOR = :CUI_FURNIZOR " +
                    "WHERE COD_APROVIZIONARE = :COD_APROVIZIONARE";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_APROVIZIONARE", APROV_txtCodAprov.Text);
                cmd.Parameters.Add(":DATA_APROVIZIONARE", APROV_dpDataAprov.Text);
                cmd.Parameters.Add(":CANTITATE_CUMPARATA", APROV_txtCC.Text);
                cmd.Parameters.Add(":PRET_CUMPARARE", APROV_txtPC.Text);
                cmd.Parameters.Add(":COD_PIESA", APROV_txtCodPiesa.Text);
                cmd.Parameters.Add(":CUI_FURNIZOR", APROV_txtCuiFnz.Text);
                cmd.Parameters.Add(":COD_APROVIZIONARE", tempCodAprov);
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
                    MessageBox.Show("Aprovizionarea a fost actualizata cu succes.");
                getAprovizionari();
            }
        }

        private void APROV_btnDelete_Click(object sender, EventArgs e)
        {
            if (APROV_txtCodAprov.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM APROVIZIONARI WHERE COD_APROVIZIONARE = :COD_APROVIZIONARE";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_APROVIZIONARE", APROV_txtCodAprov.Text);
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
                        MessageBox.Show("Aprovizionarea a fost stearsa cu succes.");
                    getAprovizionari();
                }
            }
        }

        private void APROV_dgwAprovizionari_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            APROV_txtCodAprov.Text = APROV_dgwAprovizionari.CurrentRow.Cells[0].Value.ToString();
            tempCodAprov = APROV_txtCodAprov.Text;
            APROV_dpDataAprov.Text = APROV_dgwAprovizionari.CurrentRow.Cells[1].Value.ToString();
            APROV_txtCC.Text = APROV_dgwAprovizionari.CurrentRow.Cells[2].Value.ToString();
            APROV_txtPC.Text = APROV_dgwAprovizionari.CurrentRow.Cells[3].Value.ToString();
            APROV_txtCodPiesa.Text = APROV_dgwAprovizionari.CurrentRow.Cells[4].Value.ToString();
            APROV_txtCuiFnz.Text = APROV_dgwAprovizionari.CurrentRow.Cells[5].Value.ToString();
        }

        private void APROV_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_APROVIZIONARE, System.String) LIKE '%" + APROV_txtSearch.Text + "%'" +
                "OR Convert(DATA_APROVIZIONARE, System.String) LIKE '%" + APROV_txtSearch.Text + "%'" +
                "OR Convert(CANTITATE_CUMPARATA, System.String) LIKE '%" + APROV_txtSearch.Text + "%'" +
                "OR Convert(PRET_CUMPARARE, System.String) LIKE '%" + APROV_txtSearch.Text + "%'" +
                "OR Convert(COD_PIESA, System.String) LIKE '%" + APROV_txtSearch.Text + "%'" +
                "OR CUI_FURNIZOR LIKE '%" + APROV_txtSearch.Text + "%'";
            APROV_dgwAprovizionari.DataSource = dv;
        }

        private void FormAprovizionari_Click(object sender, EventArgs e)
        {
            APROV_txtCodAprov.Text = "";
            APROV_dpDataAprov.Text = "";
            APROV_txtCC.Text = "";
            APROV_txtPC.Text = "";
            APROV_txtCodPiesa.Text = "";
            APROV_txtCuiFnz.Text = "";
        }
    }
}
