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
    public partial class FormContinutComenzi : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodComanda, tempCodPiesa;

        public FormContinutComenzi()
        {
            InitializeComponent();
        }

        void getContinutComenzi()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM CONTINUT_COMENZI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            CC_dgwContinuturi.DataSource = dt;
            conn.Close();
        }

        private void FormContinutComenzi_Load(object sender, EventArgs e)
        {
            getContinutComenzi();
        }

        private void CC_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "CONTINUT_COMENZI VALUES (:COD_COMANDA, " +
                ":COD_PIESA, " +
                ":CANTITATE_VANDUTA)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":COD_COMANDA", CC_txtCodCmd.Text);
            cmd.Parameters.Add(":COD_PIESA", CC_txtCodPiesa.Text);
            cmd.Parameters.Add(":CANTITATE_VANDUTA", CC_txtCV.Text);
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
                MessageBox.Show("Continul comenzii a fost inserat cu succes.");
            getContinutComenzi();
        }

        private void CC_btnUpdate_Click(object sender, EventArgs e)
        {
            if (CC_txtCodCmd.Text != "")
            {
                var query = "UPDATE CONTINUT_COMENZI " +
                            "SET COD_COMANDA = :COD_COMANDA, " +
                            "COD_PIESA = :COD_PIESA, " +
                            "CANTITATE_VANDUTA = :CANTITATE_VANDUTA " +
                            "WHERE COD_COMANDA = :COD_COMANDA AND COD_PIESA = :COD_PIESA";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":COD_COMANDA", CC_txtCodCmd.Text);
                cmd.Parameters.Add(":COD_PIESA", CC_txtCodPiesa.Text);
                cmd.Parameters.Add(":CANTITATE_VANDUTA", CC_txtCV.Text);
                cmd.Parameters.Add(":COD_COMANDA", tempCodComanda);
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
                    MessageBox.Show("Continul comenzii a fost actualizat cu succes.");
                getContinutComenzi();
            }
        }

        private void CC_btnDelete_Click(object sender, EventArgs e)
        {
            if (CC_txtCodCmd.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM CONTINUT_COMENZI WHERE COD_COMANDA = :COD_COMANDA AND COD_PIESA = :COD_PIESA";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":COD_COMANDA", CC_txtCodCmd.Text);
                    cmd.Parameters.Add(":COD_PIESA", CC_txtCodPiesa.Text);
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
                        MessageBox.Show("Continul comenzii a fost sters cu succes.");
                    getContinutComenzi();
                }
            }
        }

        private void CC_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_COMANDA, System.String) LIKE '%" + CC_txtSearch.Text + "%'" +
                "OR Convert(COD_PIESA, System.String) LIKE '%" + CC_txtSearch.Text + "%'" +
                "OR Convert(CANTITATE_VANDUTA, System.String) LIKE '%" + CC_txtSearch.Text + "%'";
            CC_dgwContinuturi.DataSource = dv;
        }

        private void PROD_dgwProducatori_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CC_txtCodCmd.Text = CC_dgwContinuturi.CurrentRow.Cells[0].Value.ToString();
            tempCodComanda = CC_txtCodCmd.Text;
            CC_txtCodPiesa.Text = CC_dgwContinuturi.CurrentRow.Cells[1].Value.ToString();
            tempCodPiesa = CC_txtCodPiesa.Text;
            CC_txtCV.Text = CC_dgwContinuturi.CurrentRow.Cells[2].Value.ToString();
        }

        private void FormContinutComenzi_Click(object sender, EventArgs e)
        {
            CC_txtCodCmd.Text = "";
            CC_txtCodPiesa.Text = "";
            CC_txtCV.Text = "";

        }
    }
}
