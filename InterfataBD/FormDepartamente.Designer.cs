namespace InterfataBD
{
    partial class FormDepartamente
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
            this.DPT_btnDelete = new System.Windows.Forms.Button();
            this.DPT_btnUpdate = new System.Windows.Forms.Button();
            this.DPT_btnInsert = new System.Windows.Forms.Button();
            this.DPT_txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DPT_txtCodDpt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DPT_dgwDepartamente = new System.Windows.Forms.DataGridView();
            this.DPT_txtNumeDpt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPT_dgwDepartamente)).BeginInit();
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
            this.label10.TabIndex = 63;
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
            // DPT_btnDelete
            // 
            this.DPT_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DPT_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPT_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DPT_btnDelete.Location = new System.Drawing.Point(1439, 754);
            this.DPT_btnDelete.Name = "DPT_btnDelete";
            this.DPT_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.DPT_btnDelete.TabIndex = 62;
            this.DPT_btnDelete.Text = "Delete";
            this.DPT_btnDelete.UseVisualStyleBackColor = true;
            this.DPT_btnDelete.Click += new System.EventHandler(this.DPT_btnDelete_Click);
            // 
            // DPT_btnUpdate
            // 
            this.DPT_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DPT_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPT_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DPT_btnUpdate.Location = new System.Drawing.Point(1260, 754);
            this.DPT_btnUpdate.Name = "DPT_btnUpdate";
            this.DPT_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.DPT_btnUpdate.TabIndex = 61;
            this.DPT_btnUpdate.Text = "Update";
            this.DPT_btnUpdate.UseVisualStyleBackColor = true;
            this.DPT_btnUpdate.Click += new System.EventHandler(this.DPT_btnUpdate_Click);
            // 
            // DPT_btnInsert
            // 
            this.DPT_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DPT_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.DPT_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DPT_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPT_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DPT_btnInsert.Location = new System.Drawing.Point(1083, 754);
            this.DPT_btnInsert.Name = "DPT_btnInsert";
            this.DPT_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.DPT_btnInsert.TabIndex = 60;
            this.DPT_btnInsert.Text = "Insert";
            this.DPT_btnInsert.UseVisualStyleBackColor = false;
            this.DPT_btnInsert.Click += new System.EventHandler(this.DPT_btnInsert_Click);
            // 
            // DPT_txtSearch
            // 
            this.DPT_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPT_txtSearch.Location = new System.Drawing.Point(123, 54);
            this.DPT_txtSearch.Name = "DPT_txtSearch";
            this.DPT_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.DPT_txtSearch.TabIndex = 59;
            this.DPT_txtSearch.TextChanged += new System.EventHandler(this.DPT_txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 35);
            this.label2.TabIndex = 55;
            this.label2.Text = "NUME_DEPARTAMENT:";
            // 
            // DPT_txtCodDpt
            // 
            this.DPT_txtCodDpt.Font = new System.Drawing.Font("Arial", 14F);
            this.DPT_txtCodDpt.Location = new System.Drawing.Point(1353, 111);
            this.DPT_txtCodDpt.Name = "DPT_txtCodDpt";
            this.DPT_txtCodDpt.Size = new System.Drawing.Size(220, 34);
            this.DPT_txtCodDpt.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 53;
            this.label1.Text = "COD_DEPARTAMENT:";
            // 
            // DPT_dgwDepartamente
            // 
            this.DPT_dgwDepartamente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DPT_dgwDepartamente.BackgroundColor = System.Drawing.Color.White;
            this.DPT_dgwDepartamente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DPT_dgwDepartamente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DPT_dgwDepartamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DPT_dgwDepartamente.Location = new System.Drawing.Point(15, 103);
            this.DPT_dgwDepartamente.Name = "DPT_dgwDepartamente";
            this.DPT_dgwDepartamente.ReadOnly = true;
            this.DPT_dgwDepartamente.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.DPT_dgwDepartamente.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DPT_dgwDepartamente.RowTemplate.Height = 24;
            this.DPT_dgwDepartamente.Size = new System.Drawing.Size(1048, 697);
            this.DPT_dgwDepartamente.TabIndex = 52;
            this.DPT_dgwDepartamente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DPT_dgwComenzi_CellEnter);
            // 
            // DPT_txtNumeDpt
            // 
            this.DPT_txtNumeDpt.Font = new System.Drawing.Font("Arial", 14F);
            this.DPT_txtNumeDpt.Location = new System.Drawing.Point(1353, 164);
            this.DPT_txtNumeDpt.Name = "DPT_txtNumeDpt";
            this.DPT_txtNumeDpt.Size = new System.Drawing.Size(220, 34);
            this.DPT_txtNumeDpt.TabIndex = 54;
            // 
            // FormDepartamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.DPT_txtNumeDpt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DPT_btnDelete);
            this.Controls.Add(this.DPT_btnUpdate);
            this.Controls.Add(this.DPT_btnInsert);
            this.Controls.Add(this.DPT_txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DPT_txtCodDpt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DPT_dgwDepartamente);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormDepartamente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPARTAMENTE";
            this.Load += new System.EventHandler(this.FormDepartamente_Load);
            this.Click += new System.EventHandler(this.FormDepartamente_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPT_dgwDepartamente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.Label label10;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private System.Windows.Forms.Button DPT_btnDelete;
        private System.Windows.Forms.Button DPT_btnUpdate;
        private System.Windows.Forms.Button DPT_btnInsert;
        private System.Windows.Forms.TextBox DPT_txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DPT_txtCodDpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DPT_dgwDepartamente;
        private System.Windows.Forms.TextBox DPT_txtNumeDpt;
    }
}