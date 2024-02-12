using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cLIENTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormClienti formClienti = new FormClienti();
                formClienti.MdiParent = this;
                formClienti.FormBorderStyle = FormBorderStyle.None;
                formClienti.Dock = DockStyle.Fill;
                formClienti.Show();
        }

        private void cOMENZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormComenzi formComenzi = new FormComenzi();
                formComenzi.MdiParent = this;
                formComenzi.FormBorderStyle = FormBorderStyle.None;
                formComenzi.Dock = DockStyle.Fill;
                formComenzi.Show();
        }

        private void dEPARTAMENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartamente formDepartamente = new FormDepartamente();
            formDepartamente.MdiParent = this;
            formDepartamente.FormBorderStyle = FormBorderStyle.None;
            formDepartamente.Dock = DockStyle.Fill;
            formDepartamente.Show();
        }

        private void aNGAJATIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAngajati formAngajati = new FormAngajati();
            formAngajati.MdiParent = this;
            formAngajati.FormBorderStyle = FormBorderStyle.None;
            formAngajati.Dock = DockStyle.Fill;
            formAngajati.Show();
        }

        private void gESTIONARECOMENZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionareComenzi formGestionareComenzi = new FormGestionareComenzi();
            formGestionareComenzi.MdiParent = this;
            formGestionareComenzi.FormBorderStyle = FormBorderStyle.None;
            formGestionareComenzi.Dock = DockStyle.Fill;
            formGestionareComenzi.Show();
        }

        private void cATEGORIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorii formCategorii = new FormCategorii();
            formCategorii.MdiParent = this;
            formCategorii.FormBorderStyle = FormBorderStyle.None;
            formCategorii.Dock = DockStyle.Fill;
            formCategorii.Show();
        }

        private void pRODUCATORIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducatori formProducatori = new FormProducatori();
            formProducatori.MdiParent = this;
            formProducatori.FormBorderStyle = FormBorderStyle.None;
            formProducatori.Dock = DockStyle.Fill;
            formProducatori.Show();
        }

        private void pIESEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPiese formPiese = new FormPiese();
            formPiese.MdiParent = this;
            formPiese.FormBorderStyle = FormBorderStyle.None;
            formPiese.Dock = DockStyle.Fill;
            formPiese.Show();
        }

        private void cONTINUTCOMENZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContinutComenzi formContinutComenzi = new FormContinutComenzi();
            formContinutComenzi.MdiParent = this;
            formContinutComenzi.FormBorderStyle = FormBorderStyle.None;
            formContinutComenzi.Dock = DockStyle.Fill;
            formContinutComenzi.Show();
        }

        private void fURNIZORIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFurnizori formFurnizori = new FormFurnizori();
            formFurnizori.MdiParent = this;
            formFurnizori.FormBorderStyle = FormBorderStyle.None;
            formFurnizori.Dock = DockStyle.Fill;
            formFurnizori.Show();
        }

        private void aPROVIZIONARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAprovizionari formAprovizionari = new FormAprovizionari();
            formAprovizionari.MdiParent = this;
            formAprovizionari.FormBorderStyle = FormBorderStyle.None;
            formAprovizionari.Dock = DockStyle.Fill;
            formAprovizionari.Show();
        }

        private void pUNCTULCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormC formC = new FormC();
            formC.MdiParent = this;
            formC.FormBorderStyle = FormBorderStyle.None;
            formC.Dock = DockStyle.Fill;
            formC.Show();
        }

        private void pUNCTULDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormD formD = new FormD();
            formD.MdiParent = this;
            formD.FormBorderStyle = FormBorderStyle.None;
            formD.Dock = DockStyle.Fill;
            formD.Show();
        }

        private void cOMPUSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVizCompusa formVizCompusa = new FormVizCompusa();
            formVizCompusa.MdiParent = this;
            formVizCompusa.FormBorderStyle = FormBorderStyle.None;
            formVizCompusa.Dock = DockStyle.Fill;
            formVizCompusa.Show();
        }

        private void cOMPLEXAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVizComplexa formVizComplexa = new FormVizComplexa();
            formVizComplexa.MdiParent = this;
            formVizComplexa.FormBorderStyle = FormBorderStyle.None;
            formVizComplexa.Dock = DockStyle.Fill;
            formVizComplexa.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm();
            defaultForm.MdiParent = this;
            defaultForm.FormBorderStyle = FormBorderStyle.None;
            defaultForm.Dock = DockStyle.Fill;
            defaultForm.Show();
        }

        private void aCASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm();
            defaultForm.MdiParent = this;
            defaultForm.FormBorderStyle = FormBorderStyle.None;
            defaultForm.Dock = DockStyle.Fill;
            defaultForm.Show();
        }
    }
}
