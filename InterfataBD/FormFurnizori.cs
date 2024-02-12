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
    public partial class FormFurnizori : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;
        string tempCodFnz; 

        public FormFurnizori()
        {
            InitializeComponent();
        }

        void getFurnizori()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM FURNIZORI", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            FNZ_dgwFurnizori.DataSource = dt;
            conn.Close();
        }

        private void FormFurnizori_Load(object sender, EventArgs e)
        {
            getFurnizori();
        }

        private void FNZ_btnInsert_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO " +
                "FURNIZORI VALUES (:CUI_FURNIZOR, " +
                ":NUME_FURNIZOR, " +
                ":IBAN)";
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":CUI_FURNIZOR", FNZ_txtCUIFnz.Text);
            cmd.Parameters.Add(":NUME_FURNIZOR", FNZ_txtNumeFnz.Text);
            cmd.Parameters.Add(":IBAN", FNZ_txtIBAN.Text);
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
                MessageBox.Show("Furnizorul a fost inserat cu succes.");
            getFurnizori();
        }

        private void FNZ_btnUpdate_Click(object sender, EventArgs e)
        {
            if (FNZ_txtCUIFnz.Text != "")
            {
                var query = "UPDATE FURNIZORI " +
                    "SET CUI_FURNIZOR = :CUI_FURNIZOR, " +
                    "NUME_FURNIZOR = :NUME_FURNIZOR, " +
                    "IBAN = :IBAN " +
                    "WHERE CUI_FURNIZOR = :CUI_FURNIZOR";
                conn.Open();
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":CUI_FURNIZOR", FNZ_txtCUIFnz.Text);
                cmd.Parameters.Add(":NUME_FURNIZOR", FNZ_txtNumeFnz.Text);
                cmd.Parameters.Add(":IBAN", FNZ_txtIBAN.Text);
                cmd.Parameters.Add(":CUI_FURNIZOR", tempCodFnz);
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
                    MessageBox.Show("Furnizorul a fost actualizat cu succes.");
                getFurnizori();
            }
        }

        private void FNZ_btnDelete_Click(object sender, EventArgs e)
        {
            if (FNZ_txtCUIFnz.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = "DELETE FROM FURNIZORI WHERE CUI_FURNIZOR = :CUI_FURNIZOR";
                    conn.Open();
                    cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":CUI_FURNIZOR", FNZ_txtCUIFnz.Text);
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
                        MessageBox.Show("Furnizorul a fost sters cu succes.");
                    getFurnizori();
                }
            }
        }

        private void FNZ_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "CUI_FURNIZOR LIKE '%" + FNZ_txtSearch.Text + "%'" +
                "OR NUME_FURNIZOR LIKE '%" + FNZ_txtSearch.Text + "%'" +
                "OR IBAN LIKE '%" + FNZ_txtSearch.Text + "%'";
            FNZ_dgwFurnizori.DataSource = dv;
        }

        private void FNXZ_dgwFurnizori_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FNZ_txtCUIFnz.Text = FNZ_dgwFurnizori.CurrentRow.Cells[0].Value.ToString();
            tempCodFnz = FNZ_txtCUIFnz.Text;
            FNZ_txtNumeFnz.Text = FNZ_dgwFurnizori.CurrentRow.Cells[1].Value.ToString();
            FNZ_txtIBAN.Text = FNZ_dgwFurnizori.CurrentRow.Cells[2].Value.ToString();
        }

        private void FormFurnizori_Click(object sender, EventArgs e)
        {
            FNZ_txtCUIFnz.Text = "";
            FNZ_txtNumeFnz.Text = "";
            FNZ_txtIBAN.Text = "";
        }
    }
}
