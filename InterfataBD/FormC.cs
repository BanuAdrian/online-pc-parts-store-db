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
    public partial class FormC : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;

        public FormC()
        {
            InitializeComponent();
        }

        void getC()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT " +
                                                "C.COD_COMANDA, " +
                                                "CLT.NUME, " +
                                                "CLT.PRENUME, " +
                                                "CLT.LOCALITATE, " +
                                                "C.MODALITATE_PLATA, " +
                                                "C.DATA_COMANDA, " +   
                                                "CC.CANTITATE_VANDUTA, " +
                                                "P.MODEL_PIESA, " +
                                                "P.PRET_VANZARE, " +
                                                "P.GARANTIE_COMERCIALA, " +
                                                "P.COD_CATEGORIE, " +
                                                "P.COD_PRODUCATOR, " +
                                                "PROD.SITE_WEB " +
                                            "FROM COMENZI C " +
                                            "JOIN CONTINUT_COMENZI CC ON CC.COD_COMANDA = C.COD_COMANDA " +
                                            "JOIN PIESE P ON P.COD_PIESA = CC.COD_PIESA " +
                                            "JOIN CLIENTI CLT ON CLT.COD_CLIENT = C.COD_CLIENT " +
                                            "JOIN PRODUCATORI PROD ON PROD.COD_PRODUCATOR = P.COD_PRODUCATOR " +
                                            "WHERE UPPER(C.MODALITATE_PLATA) = 'CARD' AND P.GARANTIE_COMERCIALA > 24 " +
                                                "AND CC.CANTITATE_VANDUTA * P.PRET_VANZARE > 1000 AND UPPER(CLT.LOCALITATE) <> 'BUCURESTI' " +
                                            "ORDER BY COD_COMANDA ASC", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            C_dgwPunctC.DataSource = dt;
            conn.Close();
        }

        private void FormC_Load(object sender, EventArgs e)
        {
            getC();
        }

        private void C_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Convert(COD_COMANDA, System.String) LIKE '%" + C_txtSearch.Text + "%'" +
                "OR NUME LIKE '%" + C_txtSearch.Text + "%'" +
                "OR PRENUME LIKE '%" + C_txtSearch.Text + "%'" +
                "OR MODALITATE_PLATA LIKE '%" + C_txtSearch.Text + "%'" +
                "OR Convert(DATA_COMANDA, System.String) LIKE '%" + C_txtSearch.Text + "%'" +
                "OR Convert(CANTITATE_VANDUTA, System.String) LIKE '%" + C_txtSearch.Text + "%'" +
                "OR MODEL_PIESA LIKE '%" + C_txtSearch.Text + "%'" +
                "OR Convert(PRET_VANZARE, System.String) LIKE '%" + C_txtSearch.Text + "%'" +
                "OR Convert(GARANTIE_COMERCIALA, System.String) LIKE '%" + C_txtSearch.Text + "%'" +
                "OR COD_CATEGORIE LIKE '%" + C_txtSearch.Text + "%'" +
                "OR SITE_WEB LIKE '%" + C_txtSearch.Text + "%'";
            C_dgwPunctC.DataSource = dv;
        }
    }
}
