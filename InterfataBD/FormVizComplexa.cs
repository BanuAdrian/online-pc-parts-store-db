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
    public partial class FormVizComplexa : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        DataTable dt;

        public FormVizComplexa()
        {
            InitializeComponent();
        }

        void getVizComplexa()
        {
            conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            adapter = new OracleDataAdapter("SELECT * FROM VIZ_COMPLEXA", conn);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            VCMX_dgwVizComplexa.DataSource = dt;
            conn.Close();
        }

        private void FormVizComplexa_Load(object sender, EventArgs e)
        {
            getVizComplexa();
        }

        private void VCMX_txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "COD_PRODUCATOR LIKE '%" + VCMX_txtSearch.Text + "%'" +
                "OR NUME_PRODUCATOR LIKE '%" + VCMX_txtSearch.Text + "%'" +
                "OR SITE_WEB LIKE '%" + VCMX_txtSearch.Text + "%'" +
                "OR Convert(NUMAR_PIESE, System.String) LIKE '%" + VCMX_txtSearch.Text + "%'";
            VCMX_dgwVizComplexa.DataSource = dv;
        }
    }
}
