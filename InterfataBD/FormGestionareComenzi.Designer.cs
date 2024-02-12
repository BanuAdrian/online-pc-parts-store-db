namespace InterfataBD
{
    partial class FormGestionareComenzi
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
            this.GESTCMD_dpDataGest = new System.Windows.Forms.DateTimePicker();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GESTCMD_btnDelete = new System.Windows.Forms.Button();
            this.GESTCMD_btnUpdate = new System.Windows.Forms.Button();
            this.GESTCMD_btnInsert = new System.Windows.Forms.Button();
            this.GESTCMD_txtSearch = new System.Windows.Forms.TextBox();
            this.GESTCMD_txtCodAng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GESTCMD_txtCodGest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GESTCMD_dgwGestComenzi = new System.Windows.Forms.DataGridView();
            this.GESTCMD_txtCodCmd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GESTCMD_dgwGestComenzi)).BeginInit();
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
            // GESTCMD_dpDataGest
            // 
            this.GESTCMD_dpDataGest.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.GESTCMD_dpDataGest.CustomFormat = "dd-MMM-yy";
            this.GESTCMD_dpDataGest.Font = new System.Drawing.Font("Arial", 14F);
            this.GESTCMD_dpDataGest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GESTCMD_dpDataGest.Location = new System.Drawing.Point(1353, 158);
            this.GESTCMD_dpDataGest.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.GESTCMD_dpDataGest.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.GESTCMD_dpDataGest.Name = "GESTCMD_dpDataGest";
            this.GESTCMD_dpDataGest.Size = new System.Drawing.Size(220, 34);
            this.GESTCMD_dpDataGest.TabIndex = 51;
            this.GESTCMD_dpDataGest.Value = new System.DateTime(2024, 1, 3, 0, 0, 0, 0);
            // 
            // cOMENZIBindingSource
            // 
            this.cOMENZIBindingSource.DataMember = "COMENZI";
            this.cOMENZIBindingSource.DataSource = this.dataSet11;
            // 
            // GESTCMD_btnDelete
            // 
            this.GESTCMD_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GESTCMD_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GESTCMD_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GESTCMD_btnDelete.Location = new System.Drawing.Point(1439, 754);
            this.GESTCMD_btnDelete.Name = "GESTCMD_btnDelete";
            this.GESTCMD_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.GESTCMD_btnDelete.TabIndex = 62;
            this.GESTCMD_btnDelete.Text = "Delete";
            this.GESTCMD_btnDelete.UseVisualStyleBackColor = true;
            this.GESTCMD_btnDelete.Click += new System.EventHandler(this.GESTCMD_btnDelete_Click);
            // 
            // GESTCMD_btnUpdate
            // 
            this.GESTCMD_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GESTCMD_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GESTCMD_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GESTCMD_btnUpdate.Location = new System.Drawing.Point(1260, 754);
            this.GESTCMD_btnUpdate.Name = "GESTCMD_btnUpdate";
            this.GESTCMD_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.GESTCMD_btnUpdate.TabIndex = 61;
            this.GESTCMD_btnUpdate.Text = "Update";
            this.GESTCMD_btnUpdate.UseVisualStyleBackColor = true;
            this.GESTCMD_btnUpdate.Click += new System.EventHandler(this.GESTCMD_btnUpdate_Click);
            // 
            // GESTCMD_btnInsert
            // 
            this.GESTCMD_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.GESTCMD_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.GESTCMD_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GESTCMD_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GESTCMD_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GESTCMD_btnInsert.Location = new System.Drawing.Point(1083, 754);
            this.GESTCMD_btnInsert.Name = "GESTCMD_btnInsert";
            this.GESTCMD_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.GESTCMD_btnInsert.TabIndex = 60;
            this.GESTCMD_btnInsert.Text = "Insert";
            this.GESTCMD_btnInsert.UseVisualStyleBackColor = false;
            this.GESTCMD_btnInsert.Click += new System.EventHandler(this.GESTCMD_btnInsert_Click);
            // 
            // GESTCMD_txtSearch
            // 
            this.GESTCMD_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GESTCMD_txtSearch.Location = new System.Drawing.Point(123, 54);
            this.GESTCMD_txtSearch.Name = "GESTCMD_txtSearch";
            this.GESTCMD_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.GESTCMD_txtSearch.TabIndex = 59;
            this.GESTCMD_txtSearch.TextChanged += new System.EventHandler(this.GESTCMD_txtSearch_TextChanged);
            // 
            // GESTCMD_txtCodAng
            // 
            this.GESTCMD_txtCodAng.Font = new System.Drawing.Font("Arial", 14F);
            this.GESTCMD_txtCodAng.Location = new System.Drawing.Point(1353, 258);
            this.GESTCMD_txtCodAng.Name = "GESTCMD_txtCodAng";
            this.GESTCMD_txtCodAng.Size = new System.Drawing.Size(220, 34);
            this.GESTCMD_txtCodAng.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1078, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 35);
            this.label3.TabIndex = 57;
            this.label3.Text = "COD_ANGAJAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1077, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 35);
            this.label4.TabIndex = 56;
            this.label4.Text = "COD_COMANDA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 35);
            this.label2.TabIndex = 55;
            this.label2.Text = "DATA_GESTIONARE:";
            // 
            // GESTCMD_txtCodGest
            // 
            this.GESTCMD_txtCodGest.Font = new System.Drawing.Font("Arial", 14F);
            this.GESTCMD_txtCodGest.Location = new System.Drawing.Point(1353, 111);
            this.GESTCMD_txtCodGest.Name = "GESTCMD_txtCodGest";
            this.GESTCMD_txtCodGest.Size = new System.Drawing.Size(220, 34);
            this.GESTCMD_txtCodGest.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 35);
            this.label1.TabIndex = 53;
            this.label1.Text = "COD_GESTIONARE:";
            // 
            // GESTCMD_dgwGestComenzi
            // 
            this.GESTCMD_dgwGestComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GESTCMD_dgwGestComenzi.BackgroundColor = System.Drawing.Color.White;
            this.GESTCMD_dgwGestComenzi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GESTCMD_dgwGestComenzi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GESTCMD_dgwGestComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GESTCMD_dgwGestComenzi.Location = new System.Drawing.Point(15, 103);
            this.GESTCMD_dgwGestComenzi.Name = "GESTCMD_dgwGestComenzi";
            this.GESTCMD_dgwGestComenzi.ReadOnly = true;
            this.GESTCMD_dgwGestComenzi.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            this.GESTCMD_dgwGestComenzi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GESTCMD_dgwGestComenzi.RowTemplate.Height = 24;
            this.GESTCMD_dgwGestComenzi.Size = new System.Drawing.Size(1048, 697);
            this.GESTCMD_dgwGestComenzi.TabIndex = 52;
            this.GESTCMD_dgwGestComenzi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GESTCMD_dgwGestComenzi_CellEnter);
            // 
            // GESTCMD_txtCodCmd
            // 
            this.GESTCMD_txtCodCmd.Font = new System.Drawing.Font("Arial", 14F);
            this.GESTCMD_txtCodCmd.Location = new System.Drawing.Point(1353, 210);
            this.GESTCMD_txtCodCmd.Name = "GESTCMD_txtCodCmd";
            this.GESTCMD_txtCodCmd.Size = new System.Drawing.Size(220, 34);
            this.GESTCMD_txtCodCmd.TabIndex = 64;
            // 
            // FormGestionareComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.GESTCMD_txtCodCmd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GESTCMD_dpDataGest);
            this.Controls.Add(this.GESTCMD_btnDelete);
            this.Controls.Add(this.GESTCMD_btnUpdate);
            this.Controls.Add(this.GESTCMD_btnInsert);
            this.Controls.Add(this.GESTCMD_txtSearch);
            this.Controls.Add(this.GESTCMD_txtCodAng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GESTCMD_txtCodGest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GESTCMD_dgwGestComenzi);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormGestionareComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIONARE_COMENZI";
            this.Load += new System.EventHandler(this.FormGestionareComenzi_Load);
            this.Click += new System.EventHandler(this.FormGestionareComenzi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GESTCMD_dgwGestComenzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.Label label10;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DateTimePicker GESTCMD_dpDataGest;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private System.Windows.Forms.Button GESTCMD_btnDelete;
        private System.Windows.Forms.Button GESTCMD_btnUpdate;
        private System.Windows.Forms.Button GESTCMD_btnInsert;
        private System.Windows.Forms.TextBox GESTCMD_txtSearch;
        private System.Windows.Forms.TextBox GESTCMD_txtCodAng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GESTCMD_txtCodGest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GESTCMD_dgwGestComenzi;
        private System.Windows.Forms.TextBox GESTCMD_txtCodCmd;
    }
}