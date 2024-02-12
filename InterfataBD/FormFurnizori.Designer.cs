namespace InterfataBD
{
    partial class FormFurnizori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cOMENZITableAdapter = new InterfataBD.DataSet1TableAdapters.COMENZITableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.dataSet11 = new InterfataBD.DataSet1();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FNZ_txtIBAN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FNZ_txtNumeFnz = new System.Windows.Forms.TextBox();
            this.FNZ_btnDelete = new System.Windows.Forms.Button();
            this.FNZ_btnUpdate = new System.Windows.Forms.Button();
            this.FNZ_btnInsert = new System.Windows.Forms.Button();
            this.FNZ_txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FNZ_txtCUIFnz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FNZ_dgwFurnizori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNZ_dgwFurnizori)).BeginInit();
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
            this.label10.TabIndex = 85;
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
            // FNZ_txtIBAN
            // 
            this.FNZ_txtIBAN.Font = new System.Drawing.Font("Arial", 14F);
            this.FNZ_txtIBAN.Location = new System.Drawing.Point(1305, 218);
            this.FNZ_txtIBAN.Name = "FNZ_txtIBAN";
            this.FNZ_txtIBAN.Size = new System.Drawing.Size(268, 34);
            this.FNZ_txtIBAN.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1078, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 35);
            this.label3.TabIndex = 87;
            this.label3.Text = "IBAN:";
            // 
            // FNZ_txtNumeFnz
            // 
            this.FNZ_txtNumeFnz.Font = new System.Drawing.Font("Arial", 14F);
            this.FNZ_txtNumeFnz.Location = new System.Drawing.Point(1305, 164);
            this.FNZ_txtNumeFnz.Name = "FNZ_txtNumeFnz";
            this.FNZ_txtNumeFnz.Size = new System.Drawing.Size(268, 34);
            this.FNZ_txtNumeFnz.TabIndex = 78;
            // 
            // FNZ_btnDelete
            // 
            this.FNZ_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FNZ_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNZ_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FNZ_btnDelete.Location = new System.Drawing.Point(1439, 754);
            this.FNZ_btnDelete.Name = "FNZ_btnDelete";
            this.FNZ_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.FNZ_btnDelete.TabIndex = 84;
            this.FNZ_btnDelete.Text = "Delete";
            this.FNZ_btnDelete.UseVisualStyleBackColor = true;
            this.FNZ_btnDelete.Click += new System.EventHandler(this.FNZ_btnDelete_Click);
            // 
            // FNZ_btnUpdate
            // 
            this.FNZ_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FNZ_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNZ_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FNZ_btnUpdate.Location = new System.Drawing.Point(1260, 754);
            this.FNZ_btnUpdate.Name = "FNZ_btnUpdate";
            this.FNZ_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.FNZ_btnUpdate.TabIndex = 83;
            this.FNZ_btnUpdate.Text = "Update";
            this.FNZ_btnUpdate.UseVisualStyleBackColor = true;
            this.FNZ_btnUpdate.Click += new System.EventHandler(this.FNZ_btnUpdate_Click);
            // 
            // FNZ_btnInsert
            // 
            this.FNZ_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.FNZ_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.FNZ_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FNZ_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNZ_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FNZ_btnInsert.Location = new System.Drawing.Point(1083, 754);
            this.FNZ_btnInsert.Name = "FNZ_btnInsert";
            this.FNZ_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.FNZ_btnInsert.TabIndex = 82;
            this.FNZ_btnInsert.Text = "Insert";
            this.FNZ_btnInsert.UseVisualStyleBackColor = false;
            this.FNZ_btnInsert.Click += new System.EventHandler(this.FNZ_btnInsert_Click);
            // 
            // FNZ_txtSearch
            // 
            this.FNZ_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNZ_txtSearch.Location = new System.Drawing.Point(123, 54);
            this.FNZ_txtSearch.Name = "FNZ_txtSearch";
            this.FNZ_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.FNZ_txtSearch.TabIndex = 81;
            this.FNZ_txtSearch.TextChanged += new System.EventHandler(this.FNZ_txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 35);
            this.label2.TabIndex = 80;
            this.label2.Text = "NUME_FURNIZOR:";
            // 
            // FNZ_txtCUIFnz
            // 
            this.FNZ_txtCUIFnz.Font = new System.Drawing.Font("Arial", 14F);
            this.FNZ_txtCUIFnz.Location = new System.Drawing.Point(1305, 111);
            this.FNZ_txtCUIFnz.Name = "FNZ_txtCUIFnz";
            this.FNZ_txtCUIFnz.Size = new System.Drawing.Size(268, 34);
            this.FNZ_txtCUIFnz.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 77;
            this.label1.Text = "CUI_FURNIZOR:";
            // 
            // FNZ_dgwFurnizori
            // 
            this.FNZ_dgwFurnizori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FNZ_dgwFurnizori.BackgroundColor = System.Drawing.Color.White;
            this.FNZ_dgwFurnizori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FNZ_dgwFurnizori.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.FNZ_dgwFurnizori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FNZ_dgwFurnizori.Location = new System.Drawing.Point(15, 103);
            this.FNZ_dgwFurnizori.Name = "FNZ_dgwFurnizori";
            this.FNZ_dgwFurnizori.ReadOnly = true;
            this.FNZ_dgwFurnizori.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            this.FNZ_dgwFurnizori.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FNZ_dgwFurnizori.RowTemplate.Height = 24;
            this.FNZ_dgwFurnizori.Size = new System.Drawing.Size(1048, 697);
            this.FNZ_dgwFurnizori.TabIndex = 76;
            this.FNZ_dgwFurnizori.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.FNXZ_dgwFurnizori_CellEnter);
            // 
            // FormFurnizori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FNZ_txtIBAN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FNZ_txtNumeFnz);
            this.Controls.Add(this.FNZ_btnDelete);
            this.Controls.Add(this.FNZ_btnUpdate);
            this.Controls.Add(this.FNZ_btnInsert);
            this.Controls.Add(this.FNZ_txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FNZ_txtCUIFnz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FNZ_dgwFurnizori);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormFurnizori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFurnizori";
            this.Load += new System.EventHandler(this.FormFurnizori_Load);
            this.Click += new System.EventHandler(this.FormFurnizori_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNZ_dgwFurnizori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.Label label10;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private System.Windows.Forms.TextBox FNZ_txtIBAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FNZ_txtNumeFnz;
        private System.Windows.Forms.Button FNZ_btnDelete;
        private System.Windows.Forms.Button FNZ_btnUpdate;
        private System.Windows.Forms.Button FNZ_btnInsert;
        private System.Windows.Forms.TextBox FNZ_txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FNZ_txtCUIFnz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FNZ_dgwFurnizori;
    }
}