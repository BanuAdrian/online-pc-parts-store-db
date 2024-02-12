namespace InterfataBD
{
    partial class FormCategorii
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
            this.cOMENZITableAdapter = new InterfataBD.DataSet1TableAdapters.COMENZITableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.dataSet11 = new InterfataBD.DataSet1();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CAT_txtNumeCat = new System.Windows.Forms.TextBox();
            this.CAT_btnDelete = new System.Windows.Forms.Button();
            this.CAT_btnUpdate = new System.Windows.Forms.Button();
            this.CAT_btnInsert = new System.Windows.Forms.Button();
            this.CAT_txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CAT_txtCodCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CAT_dgwCategorii = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAT_dgwCategorii)).BeginInit();
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
            // CAT_txtNumeCat
            // 
            this.CAT_txtNumeCat.Font = new System.Drawing.Font("Arial", 14F);
            this.CAT_txtNumeCat.Location = new System.Drawing.Point(1353, 164);
            this.CAT_txtNumeCat.Name = "CAT_txtNumeCat";
            this.CAT_txtNumeCat.Size = new System.Drawing.Size(220, 34);
            this.CAT_txtNumeCat.TabIndex = 66;
            // 
            // CAT_btnDelete
            // 
            this.CAT_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CAT_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAT_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CAT_btnDelete.Location = new System.Drawing.Point(1439, 754);
            this.CAT_btnDelete.Name = "CAT_btnDelete";
            this.CAT_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.CAT_btnDelete.TabIndex = 72;
            this.CAT_btnDelete.Text = "Delete";
            this.CAT_btnDelete.UseVisualStyleBackColor = true;
            this.CAT_btnDelete.Click += new System.EventHandler(this.CAT_btnDelete_Click);
            // 
            // CAT_btnUpdate
            // 
            this.CAT_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CAT_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAT_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CAT_btnUpdate.Location = new System.Drawing.Point(1260, 754);
            this.CAT_btnUpdate.Name = "CAT_btnUpdate";
            this.CAT_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.CAT_btnUpdate.TabIndex = 71;
            this.CAT_btnUpdate.Text = "Update";
            this.CAT_btnUpdate.UseVisualStyleBackColor = true;
            this.CAT_btnUpdate.Click += new System.EventHandler(this.CAT_btnUpdate_Click);
            // 
            // CAT_btnInsert
            // 
            this.CAT_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CAT_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.CAT_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CAT_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAT_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CAT_btnInsert.Location = new System.Drawing.Point(1083, 754);
            this.CAT_btnInsert.Name = "CAT_btnInsert";
            this.CAT_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.CAT_btnInsert.TabIndex = 70;
            this.CAT_btnInsert.Text = "Insert";
            this.CAT_btnInsert.UseVisualStyleBackColor = false;
            this.CAT_btnInsert.Click += new System.EventHandler(this.CAT_btnInsert_Click);
            // 
            // CAT_txtSearch
            // 
            this.CAT_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAT_txtSearch.Location = new System.Drawing.Point(123, 54);
            this.CAT_txtSearch.Name = "CAT_txtSearch";
            this.CAT_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.CAT_txtSearch.TabIndex = 69;
            this.CAT_txtSearch.TextChanged += new System.EventHandler(this.CAT_txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 35);
            this.label2.TabIndex = 68;
            this.label2.Text = "NUME_CATEGORIE:";
            // 
            // CAT_txtCodCat
            // 
            this.CAT_txtCodCat.Font = new System.Drawing.Font("Arial", 14F);
            this.CAT_txtCodCat.Location = new System.Drawing.Point(1353, 111);
            this.CAT_txtCodCat.Name = "CAT_txtCodCat";
            this.CAT_txtCodCat.Size = new System.Drawing.Size(220, 34);
            this.CAT_txtCodCat.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 35);
            this.label1.TabIndex = 65;
            this.label1.Text = "COD_CATEGORIE:";
            // 
            // CAT_dgwCategorii
            // 
            this.CAT_dgwCategorii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CAT_dgwCategorii.BackgroundColor = System.Drawing.Color.White;
            this.CAT_dgwCategorii.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CAT_dgwCategorii.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CAT_dgwCategorii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CAT_dgwCategorii.Location = new System.Drawing.Point(15, 103);
            this.CAT_dgwCategorii.Name = "CAT_dgwCategorii";
            this.CAT_dgwCategorii.ReadOnly = true;
            this.CAT_dgwCategorii.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.CAT_dgwCategorii.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CAT_dgwCategorii.RowTemplate.Height = 24;
            this.CAT_dgwCategorii.Size = new System.Drawing.Size(1048, 697);
            this.CAT_dgwCategorii.TabIndex = 64;
            this.CAT_dgwCategorii.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CAT_dgwCategorii_CellEnter);
            // 
            // FormCategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CAT_txtNumeCat);
            this.Controls.Add(this.CAT_btnDelete);
            this.Controls.Add(this.CAT_btnUpdate);
            this.Controls.Add(this.CAT_btnInsert);
            this.Controls.Add(this.CAT_txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CAT_txtCodCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CAT_dgwCategorii);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormCategorii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORII";
            this.Load += new System.EventHandler(this.FormCategorii_Load);
            this.Click += new System.EventHandler(this.FormCategorii_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CAT_dgwCategorii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.Label label10;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private System.Windows.Forms.TextBox CAT_txtNumeCat;
        private System.Windows.Forms.Button CAT_btnDelete;
        private System.Windows.Forms.Button CAT_btnUpdate;
        private System.Windows.Forms.Button CAT_btnInsert;
        private System.Windows.Forms.TextBox CAT_txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CAT_txtCodCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CAT_dgwCategorii;
    }
}