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
    public partial class FormD : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;

        public FormD()
        {
            InitializeComponent();
        }

        void getD()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT " +
                                                "COD_CATEGORIE, " + 
                                                "COUNT(COD_CATEGORIE) NUMAR_PIESE, " +
                                                "SUM(PRET_VANZARE) VALOARE_TOTALA " +
                                            "FROM PIESE " +
                                            "GROUP BY COD_CATEGORIE " +
                                            "HAVING COUNT(COD_CATEGORIE) < 10 " +
                                            "ORDER BY VALOARE_TOTALA DESC", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            D_dgwPunctD.DataSource = dt;
            conn.Close();
        }

        private void FormD_Load(object sender, EventArgs e)
        {
            getD();
        }

        private void D_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "COD_CATEGORIE LIKE '%" + D_txtSearch.Text + "%'" +
                "OR Convert(NUMAR_PIESE, System.String) LIKE '%" + D_txtSearch.Text + "%'" +
                "OR Convert(VALOARE_TOTALA, System.String) LIKE '%" + D_txtSearch.Text + "%'";
            D_dgwPunctD.DataSource = dv;
        }
    }
}
