namespace InterfataBD
{
    partial class FormAprovizionari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.APROV_txtCC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.APROV_dpDataAprov = new System.Windows.Forms.DateTimePicker();
            this.APROV_btnDelete = new System.Windows.Forms.Button();
            this.APROV_btnUpdate = new System.Windows.Forms.Button();
            this.APROV_btnInsert = new System.Windows.Forms.Button();
            this.APROV_txtSearch = new System.Windows.Forms.TextBox();
            this.dataSet11 = new InterfataBD.DataSet1();
            this.APROV_txtPC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.APROV_txtCodAprov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.APROV_dgwAprovizionari = new System.Windows.Forms.DataGridView();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMENZITableAdapter = new InterfataBD.DataSet1TableAdapters.COMENZITableAdapter();
            this.APROV_txtCodPiesa = new System.Windows.Forms.TextBox();
            this.APROV_txtCuiFnz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APROV_dgwAprovizionari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // APROV_txtCC
            // 
            this.APROV_txtCC.Font = new System.Drawing.Font("Arial", 14F);
            this.APROV_txtCC.Location = new System.Drawing.Point(1379, 210);
            this.APROV_txtCC.Name = "APROV_txtCC";
            this.APROV_txtCC.Size = new System.Drawing.Size(194, 34);
            this.APROV_txtCC.TabIndex = 78;
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
            this.label10.TabIndex = 77;
            this.label10.Text = "Search:";
            // 
            // APROV_dpDataAprov
            // 
            this.APROV_dpDataAprov.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.APROV_dpDataAprov.CustomFormat = "dd-MMM-yy";
            this.APROV_dpDataAprov.Font = new System.Drawing.Font("Arial", 14F);
            this.APROV_dpDataAprov.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.APROV_dpDataAprov.Location = new System.Drawing.Point(1379, 158);
            this.APROV_dpDataAprov.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.APROV_dpDataAprov.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.APROV_dpDataAprov.Name = "APROV_dpDataAprov";
            this.APROV_dpDataAprov.Size = new System.Drawing.Size(194, 34);
            this.APROV_dpDataAprov.TabIndex = 65;
            this.APROV_dpDataAprov.Value = new System.DateTime(2024, 1, 3, 0, 0, 0, 0);
            // 
            // APROV_btnDelete
            // 
            this.APROV_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.APROV_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APROV_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.APROV_btnDelete.Location = new System.Drawing.Point(1439, 754);
            this.APROV_btnDelete.Name = "APROV_btnDelete";
            this.APROV_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.APROV_btnDelete.TabIndex = 76;
            this.APROV_btnDelete.Text = "Delete";
            this.APROV_btnDelete.UseVisualStyleBackColor = true;
            this.APROV_btnDelete.Click += new System.EventHandler(this.APROV_btnDelete_Click);
            // 
            // APROV_btnUpdate
            // 
            this.APROV_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.APROV_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APROV_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.APROV_btnUpdate.Location = new System.Drawing.Point(1260, 754);
            this.APROV_btnUpdate.Name = "APROV_btnUpdate";
            this.APROV_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.APROV_btnUpdate.TabIndex = 75;
            this.APROV_btnUpdate.Text = "Update";
            this.APROV_btnUpdate.UseVisualStyleBackColor = true;
            this.APROV_btnUpdate.Click += new System.EventHandler(this.APROV_btnUpdate_Click);
            // 
            // APROV_btnInsert
            // 
            this.APROV_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.APROV_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.APROV_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.APROV_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APROV_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.APROV_btnInsert.Location = new System.Drawing.Point(1083, 754);
            this.APROV_btnInsert.Name = "APROV_btnInsert";
            this.APROV_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.APROV_btnInsert.TabIndex = 74;
            this.APROV_btnInsert.Text = "Insert";
            this.APROV_btnInsert.UseVisualStyleBackColor = false;
            this.APROV_btnInsert.Click += new System.EventHandler(this.APROV_btnInsert_Click);
            // 
            // APROV_txtSearch
            // 
            this.APROV_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APROV_txtSearch.Location = new System.Drawing.Point(123, 54);
            this.APROV_txtSearch.Name = "APROV_txtSearch";
            this.APROV_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.APROV_txtSearch.TabIndex = 73;
            this.APROV_txtSearch.TextChanged += new System.EventHandler(this.APROV_txtSearch_TextChanged);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // APROV_txtPC
            // 
            this.APROV_txtPC.Font = new System.Drawing.Font("Arial", 14F);
            this.APROV_txtPC.Location = new System.Drawing.Point(1379, 258);
            this.APROV_txtPC.Name = "APROV_txtPC";
            this.APROV_txtPC.Size = new System.Drawing.Size(194, 34);
            this.APROV_txtPC.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1078, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 35);
            this.label3.TabIndex = 71;
            this.label3.Text = "PRET_CUMPARARE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1077, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 35);
            this.label4.TabIndex = 70;
            this.label4.Text = "CANTITATE_CUMPARATA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 35);
            this.label2.TabIndex = 69;
            this.label2.Text = "DATA_APROVIZIONARE:";
            // 
            // APROV_txtCodAprov
            // 
            this.APROV_txtCodAprov.Font = new System.Drawing.Font("Arial", 14F);
            this.APROV_txtCodAprov.Location = new System.Drawing.Point(1379, 111);
            this.APROV_txtCodAprov.Name = "APROV_txtCodAprov";
            this.APROV_txtCodAprov.Size = new System.Drawing.Size(194, 34);
            this.APROV_txtCodAprov.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 35);
            this.label1.TabIndex = 67;
            this.label1.Text = "COD_APROVIZIONARE:";
            // 
            // APROV_dgwAprovizionari
            // 
            this.APROV_dgwAprovizionari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.APROV_dgwAprovizionari.BackgroundColor = System.Drawing.Color.White;
            this.APROV_dgwAprovizionari.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.APROV_dgwAprovizionari.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.APROV_dgwAprovizionari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.APROV_dgwAprovizionari.Location = new System.Drawing.Point(15, 103);
            this.APROV_dgwAprovizionari.Name = "APROV_dgwAprovizionari";
            this.APROV_dgwAprovizionari.ReadOnly = true;
            this.APROV_dgwAprovizionari.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.APROV_dgwAprovizionari.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.APROV_dgwAprovizionari.RowTemplate.Height = 24;
            this.APROV_dgwAprovizionari.Size = new System.Drawing.Size(1048, 697);
            this.APROV_dgwAprovizionari.TabIndex = 66;
            this.APROV_dgwAprovizionari.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.APROV_dgwAprovizionari_CellEnter);
            // 
            // cOMENZIBindingSource
            // 
            this.cOMENZIBindingSource.DataMember = "COMENZI";
            this.cOMENZIBindingSource.DataSource = this.dataSet11;
            // 
            // cOMENZITableAdapter
            // 
            this.cOMENZITableAdapter.ClearBeforeFill = true;
            // 
            // APROV_txtCodPiesa
            // 
            this.APROV_txtCodPiesa.Font = new System.Drawing.Font("Arial", 14F);
            this.APROV_txtCodPiesa.Location = new System.Drawing.Point(1379, 307);
            this.APROV_txtCodPiesa.Name = "APROV_txtCodPiesa";
            this.APROV_txtCodPiesa.Size = new System.Drawing.Size(194, 34);
            this.APROV_txtCodPiesa.TabIndex = 82;
            // 
            // APROV_txtCuiFnz
            // 
            this.APROV_txtCuiFnz.Font = new System.Drawing.Font("Arial", 14F);
            this.APROV_txtCuiFnz.Location = new System.Drawing.Point(1379, 355);
            this.APROV_txtCuiFnz.Name = "APROV_txtCuiFnz";
            this.APROV_txtCuiFnz.Size = new System.Drawing.Size(194, 34);
            this.APROV_txtCuiFnz.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1078, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 35);
            this.label5.TabIndex = 80;
            this.label5.Text = "CUI_FURNIZOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1077, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 35);
            this.label6.TabIndex = 79;
            this.label6.Text = "COD_PIESA:";
            // 
            // FormAprovizionari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.APROV_txtCodPiesa);
            this.Controls.Add(this.APROV_txtCuiFnz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.APROV_txtCC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.APROV_dpDataAprov);
            this.Controls.Add(this.APROV_btnDelete);
            this.Controls.Add(this.APROV_btnUpdate);
            this.Controls.Add(this.APROV_btnInsert);
            this.Controls.Add(this.APROV_txtSearch);
            this.Controls.Add(this.APROV_txtPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.APROV_txtCodAprov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APROV_dgwAprovizionari);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormAprovizionari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APROVIZIONARI";
            this.Load += new System.EventHandler(this.FormAprovizionari_Load);
            this.Click += new System.EventHandler(this.FormAprovizionari_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APROV_dgwAprovizionari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox APROV_txtCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker APROV_dpDataAprov;
        private System.Windows.Forms.Button APROV_btnDelete;
        private System.Windows.Forms.Button APROV_btnUpdate;
        private System.Windows.Forms.Button APROV_btnInsert;
        private System.Windows.Forms.TextBox APROV_txtSearch;
        private DataSet1 dataSet11;
        private System.Windows.Forms.TextBox APROV_txtPC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox APROV_txtCodAprov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView APROV_dgwAprovizionari;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.TextBox APROV_txtCodPiesa;
        private System.Windows.Forms.TextBox APROV_txtCuiFnz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}