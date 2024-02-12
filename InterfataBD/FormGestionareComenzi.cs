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
    public partial class FormGestionareComenzi : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodGestionare;

        public FormGestionareComenzi()
        {
            InitializeComponent();
        }

        void getGestComenzi()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM GESTIONARE_COMENZI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            GESTCMD_dgwGestComenzi.DataSource = dt;
            conn.Close();
        }

        private void FormGestionareComenzi_Load(object sender, EventArgs e)
        {
            getGestComenzi();
        }

        private void GESTCMD_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "GESTIONARE_COMENZI VALUES (:COD_GESTIONARE, " +
                ":DATA_GESTIONARE, " +
                ":COD_COMANDA, " +
                ":COD_ANGAJAT)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_GESTIONARE", GESTCMD_txtCodGest.Text);
            cmd.Parameters.Add(":DATA_GESTIONARE", GESTCMD_dpDataGest.Text);
            cmd.Parameters.Add(":COD_COMANDA", GESTCMD_txtCodCmd.Text);
            cmd.Parameters.Add(":COD_ANGAJAT", GESTCMD_txtCodAng.Text);
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
                MessageBox.Show("Gestionarea comenzii a fost inserata cu succes.");
            getGestComenzi();
        }

        private void GESTCMD_btnUpdate_Click(object sender, EventArgs e)
        {
            if (GESTCMD_txtCodGest.Text != "")
            {
                var query = "UPDATE GESTIONARE_COMENZI " +
                    "SET COD_GESTIONARE = :COD_GESTIONARE, " +
                    "DATA_GESTIONARE = :DATA_GESTIONARE, " +
                    "COD_COMANDA = :COD_COMANDA, " +
                    "COD_ANGAJAT = :COD_ANGAJAT " +
                    "WHERE COD_GESTIONARE = :COD_GESTIONARE";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_GESTIONARE", GESTCMD_txtCodGest.Text);
                cmd.Parameters.Add(":DATA_GESTIONARE", GESTCMD_dpDataGest.Text);
                cmd.Parameters.Add(":COD_COMANDA", GESTCMD_txtCodCmd.Text);
                cmd.Parameters.Add(":COD_ANGAJAT", GESTCMD_txtCodAng.Text);
                cmd.Parameters.Add(":COD_GESTIONARE", tempCodGestionare);
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
                    MessageBox.Show("Gestionarea comenzii a fost actualizata cu succes.");
                getGestComenzi();
            }
        }

        private void GESTCMD_btnDelete_Click(object sender, EventArgs e)
        {
            if (GESTCMD_txtCodGest.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM GESTIONARE_COMENZI WHERE COD_GESTIONARE = :COD_GESTIONARE";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_GESTIONARE", GESTCMD_txtCodGest.Text);
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
                        MessageBox.Show("Gestionarea comenzii a fost stearsa cu succes.");
                    getGestComenzi();
                }
            }
        }

        private void GESTCMD_dgwGestComenzi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            GESTCMD_txtCodGest.Text = GESTCMD_dgwGestComenzi.CurrentRow.Cells[0].Value.ToString();
            tempCodGestionare = GESTCMD_txtCodGest.Text;
            GESTCMD_dpDataGest.Text = GESTCMD_dgwGestComenzi.CurrentRow.Cells[1].Value.ToString();
            GESTCMD_txtCodCmd.Text = GESTCMD_dgwGestComenzi.CurrentRow.Cells[2].Value.ToString();
            GESTCMD_txtCodAng.Text = GESTCMD_dgwGestComenzi.CurrentRow.Cells[3].Value.ToString();
        }

        private void GESTCMD_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_GESTIONARE, System.String) LIKE '%" + GESTCMD_txtSearch.Text + "%'" +
                "OR Convert(DATA_GESTIONARE, System.String) LIKE '%" + GESTCMD_txtSearch.Text + "%'" +
                "OR Convert(COD_COMANDA, System.String) LIKE '%" + GESTCMD_txtSearch.Text + "%'" +
                "OR Convert(COD_ANGAJAT, System.String) LIKE '%" + GESTCMD_txtSearch.Text + "%'";
            GESTCMD_dgwGestComenzi.DataSource = dv;
        }

        private void FormGestionareComenzi_Click(object sender, EventArgs e)
        {
            GESTCMD_txtCodGest.Text = "";
            GESTCMD_dpDataGest.Text = "";
            GESTCMD_txtCodCmd.Text = "";
            GESTCMD_txtCodAng.Text = "";
        }
    }
}
