namespace InterfataBD
{
    partial class FormProducatori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cOMENZITableAdapter = new InterfataBD.DataSet1TableAdapters.COMENZITableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.dataSet11 = new InterfataBD.DataSet1();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PROD_txtNumeProd = new System.Windows.Forms.TextBox();
            this.PROD_btnDelete = new System.Windows.Forms.Button();
            this.PROD_btnUpdate = new System.Windows.Forms.Button();
            this.PROD_btnInsert = new System.Windows.Forms.Button();
            this.PROD_txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PROD_txtCodProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PROD_dgwProducatori = new System.Windows.Forms.DataGridView();
            this.PROD_txtSiteWeb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_dgwProducatori)).BeginInit();
            this.SuspendLayout();
            // 
            // cOMENZITableAdapter
            // 
            this.cOMENZITableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 35);
            this.label10.TabIndex = 73;
            this.label10.Text = "Search:";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMENZIBindingSource
            // 
            this.cOMENZIBindingSource.DataMember = "COMENZI";
            this.cOMENZIBindingSource.DataSource = this.dataSet11;
            // 
            // PROD_txtNumeProd
            // 
            this.PROD_txtNumeProd.Font = new System.Drawing.Font("Arial", 14F);
            this.PROD_txtNumeProd.Location = new System.Drawing.Point(1353, 164);
            this.PROD_txtNumeProd.Name = "PROD_txtNumeProd";
            this.PROD_txtNumeProd.Size = new System.Drawing.Size(220, 34);
            this.PROD_txtNumeProd.TabIndex = 66;
            // 
            // PROD_btnDelete
            // 
            this.PROD_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PROD_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROD_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PROD_btnDelete.Location = new System.Drawing.Point(1439, 754);
            this.PROD_btnDelete.Name = "PROD_btnDelete";
            this.PROD_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.PROD_btnDelete.TabIndex = 72;
            this.PROD_btnDelete.Text = "Delete";
            this.PROD_btnDelete.UseVisualStyleBackColor = true;
            this.PROD_btnDelete.Click += new System.EventHandler(this.PROD_btnDelete_Click);
            // 
            // PROD_btnUpdate
            // 
            this.PROD_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PROD_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROD_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PROD_btnUpdate.Location = new System.Drawing.Point(1260, 754);
            this.PROD_btnUpdate.Name = "PROD_btnUpdate";
            this.PROD_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.PROD_btnUpdate.TabIndex = 71;
            this.PROD_btnUpdate.Text = "Update";
            this.PROD_btnUpdate.UseVisualStyleBackColor = true;
            this.PROD_btnUpdate.Click += new System.EventHandler(this.PROD_btnUpdate_Click);
            // 
            // PROD_btnInsert
            // 
            this.PROD_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PROD_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.PROD_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PROD_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROD_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PROD_btnInsert.Location = new System.Drawing.Point(1083, 754);
            this.PROD_btnInsert.Name = "PROD_btnInsert";
            this.PROD_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.PROD_btnInsert.TabIndex = 70;
            this.PROD_btnInsert.Text = "Insert";
            this.PROD_btnInsert.UseVisualStyleBackColor = false;
            this.PROD_btnInsert.Click += new System.EventHandler(this.PROD_btnInsert_Click);
            // 
            // PROD_txtSearch
            // 
            this.PROD_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROD_txtSearch.Location = new System.Drawing.Point(123, 54);
            this.PROD_txtSearch.Name = "PROD_txtSearch";
            this.PROD_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.PROD_txtSearch.TabIndex = 69;
            this.PROD_txtSearch.TextChanged += new System.EventHandler(this.PROD_txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 35);
            this.label2.TabIndex = 68;
            this.label2.Text = "NUME_PRODUCATOR:";
            // 
            // PROD_txtCodProd
            // 
            this.PROD_txtCodProd.Font = new System.Drawing.Font("Arial", 14F);
            this.PROD_txtCodProd.Location = new System.Drawing.Point(1353, 111);
            this.PROD_txtCodProd.Name = "PROD_txtCodProd";
            this.PROD_txtCodProd.Size = new System.Drawing.Size(220, 34);
            this.PROD_txtCodProd.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 65;
            this.label1.Text = "COD_PRODUCATOR:";
            // 
            // PROD_dgwProducatori
            // 
            this.PROD_dgwProducatori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PROD_dgwProducatori.BackgroundColor = System.Drawing.Color.White;
            this.PROD_dgwProducatori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PROD_dgwProducatori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.PROD_dgwProducatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PROD_dgwProducatori.Location = new System.Drawing.Point(15, 103);
            this.PROD_dgwProducatori.Name = "PROD_dgwProducatori";
            this.PROD_dgwProducatori.ReadOnly = true;
            this.PROD_dgwProducatori.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            this.PROD_dgwProducatori.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PROD_dgwProducatori.RowTemplate.Height = 24;
            this.PROD_dgwProducatori.Size = new System.Drawing.Size(1048, 697);
            this.PROD_dgwProducatori.TabIndex = 64;
            this.PROD_dgwProducatori.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PROD_dgwProducatori_CellEnter);
            // 
            // PROD_txtSiteWeb
            // 
            this.PROD_txtSiteWeb.Font = new System.Drawing.Font("Arial", 14F);
            this.PROD_txtSiteWeb.Location = new System.Drawing.Point(1353, 218);
            this.PROD_txtSiteWeb.Name = "PROD_txtSiteWeb";
            this.PROD_txtSiteWeb.Size = new System.Drawing.Size(220, 34);
            this.PROD_txtSiteWeb.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1078, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 35);
            this.label3.TabIndex = 75;
            this.label3.Text = "SITE_WEB:";
            // 
            // FormProducatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.PROD_txtSiteWeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PROD_txtNumeProd);
            this.Controls.Add(this.PROD_btnDelete);
            this.Controls.Add(this.PROD_btnUpdate);
            this.Controls.Add(this.PROD_btnInsert);
            this.Controls.Add(this.PROD_txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PROD_txtCodProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PROD_dgwProducatori);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormProducatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCATORI";
            this.Load += new System.EventHandler(this.FormProducatori_Load);
            this.Click += new System.EventHandler(this.FormProducatori_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PROD_dgwProducatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.Label label10;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private System.Windows.Forms.TextBox PROD_txtNumeProd;
        private System.Windows.Forms.Button PROD_btnDelete;
        private System.Windows.Forms.Button PROD_btnUpdate;
        private System.Windows.Forms.Button PROD_btnInsert;
        private System.Windows.Forms.TextBox PROD_txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PROD_txtCodProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PROD_dgwProducatori;
        private System.Windows.Forms.TextBox PROD_txtSiteWeb;
        private System.Windows.Forms.Label label3;
    }
}