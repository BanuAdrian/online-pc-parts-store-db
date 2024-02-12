namespace InterfataBD
{
    partial class FormContinutComenzi
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
            this.CC_txtCV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CC_txtCodPiesa = new System.Windows.Forms.TextBox();
            this.CC_btnDelete = new System.Windows.Forms.Button();
            this.CC_btnUpdate = new System.Windows.Forms.Button();
            this.CC_btnInsert = new System.Windows.Forms.Button();
            this.CC_txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CC_txtCodCmd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CC_dgwContinuturi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_dgwContinuturi)).BeginInit();
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
            // CC_txtCV
            // 
            this.CC_txtCV.Font = new System.Drawing.Font("Arial", 14F);
            this.CC_txtCV.Location = new System.Drawing.Point(1353, 218);
            this.CC_txtCV.Name = "CC_txtCV";
            this.CC_txtCV.Size = new System.Drawing.Size(220, 34);
            this.CC_txtCV.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1078, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 35);
            this.label3.TabIndex = 87;
            this.label3.Text = "CANTITATE_VANDUTA:";
            // 
            // CC_txtCodPiesa
            // 
            this.CC_txtCodPiesa.Font = new System.Drawing.Font("Arial", 14F);
            this.CC_txtCodPiesa.Location = new System.Drawing.Point(1353, 164);
            this.CC_txtCodPiesa.Name = "CC_txtCodPiesa";
            this.CC_txtCodPiesa.Size = new System.Drawing.Size(220, 34);
            this.CC_txtCodPiesa.TabIndex = 78;
            // 
            // CC_btnDelete
            // 
            this.CC_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CC_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CC_btnDelete.Location = new System.Drawing.Point(1439, 754);
            this.CC_btnDelete.Name = "CC_btnDelete";
            this.CC_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.CC_btnDelete.TabIndex = 84;
            this.CC_btnDelete.Text = "Delete";
            this.CC_btnDelete.UseVisualStyleBackColor = true;
            this.CC_btnDelete.Click += new System.EventHandler(this.CC_btnDelete_Click);
            // 
            // CC_btnUpdate
            // 
            this.CC_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CC_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CC_btnUpdate.Location = new System.Drawing.Point(1260, 754);
            this.CC_btnUpdate.Name = "CC_btnUpdate";
            this.CC_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.CC_btnUpdate.TabIndex = 83;
            this.CC_btnUpdate.Text = "Update";
            this.CC_btnUpdate.UseVisualStyleBackColor = true;
            this.CC_btnUpdate.Click += new System.EventHandler(this.CC_btnUpdate_Click);
            // 
            // CC_btnInsert
            // 
            this.CC_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CC_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.CC_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CC_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CC_btnInsert.Location = new System.Drawing.Point(1083, 754);
            this.CC_btnInsert.Name = "CC_btnInsert";
            this.CC_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.CC_btnInsert.TabIndex = 82;
            this.CC_btnInsert.Text = "Insert";
            this.CC_btnInsert.UseVisualStyleBackColor = false;
            this.CC_btnInsert.Click += new System.EventHandler(this.CC_btnInsert_Click);
            // 
            // CC_txtSearch
            // 
            this.CC_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_txtSearch.Location = new System.Drawing.Point(123, 54);
            this.CC_txtSearch.Name = "CC_txtSearch";
            this.CC_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.CC_txtSearch.TabIndex = 81;
            this.CC_txtSearch.TextChanged += new System.EventHandler(this.CC_txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 80;
            this.label2.Text = "COD_PIESA:";
            // 
            // CC_txtCodCmd
            // 
            this.CC_txtCodCmd.Font = new System.Drawing.Font("Arial", 14F);
            this.CC_txtCodCmd.Location = new System.Drawing.Point(1353, 111);
            this.CC_txtCodCmd.Name = "CC_txtCodCmd";
            this.CC_txtCodCmd.Size = new System.Drawing.Size(220, 34);
            this.CC_txtCodCmd.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 77;
            this.label1.Text = "COD_COMANDA:";
            // 
            // CC_dgwContinuturi
            // 
            this.CC_dgwContinuturi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CC_dgwContinuturi.BackgroundColor = System.Drawing.Color.White;
            this.CC_dgwContinuturi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CC_dgwContinuturi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CC_dgwContinuturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CC_dgwContinuturi.Location = new System.Drawing.Point(15, 103);
            this.CC_dgwContinuturi.Name = "CC_dgwContinuturi";
            this.CC_dgwContinuturi.ReadOnly = true;
            this.CC_dgwContinuturi.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.CC_dgwContinuturi.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CC_dgwContinuturi.RowTemplate.Height = 24;
            this.CC_dgwContinuturi.Size = new System.Drawing.Size(1048, 697);
            this.CC_dgwContinuturi.TabIndex = 76;
            this.CC_dgwContinuturi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PROD_dgwProducatori_CellEnter);
            // 
            // FormContinutComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CC_txtCV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CC_txtCodPiesa);
            this.Controls.Add(this.CC_btnDelete);
            this.Controls.Add(this.CC_btnUpdate);
            this.Controls.Add(this.CC_btnInsert);
            this.Controls.Add(this.CC_txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CC_txtCodCmd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CC_dgwContinuturi);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormContinutComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContinutComenzi";
            this.Load += new System.EventHandler(this.FormContinutComenzi_Load);
            this.Click += new System.EventHandler(this.FormContinutComenzi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CC_dgwContinuturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.Label label10;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private System.Windows.Forms.TextBox CC_txtCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CC_txtCodPiesa;
        private System.Windows.Forms.Button CC_btnDelete;
        private System.Windows.Forms.Button CC_btnUpdate;
        private System.Windows.Forms.Button CC_btnInsert;
        private System.Windows.Forms.TextBox CC_txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CC_txtCodCmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CC_dgwContinuturi;
    }
}