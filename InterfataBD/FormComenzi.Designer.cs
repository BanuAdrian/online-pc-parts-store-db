namespace InterfataBD
{
    partial class FormComenzi
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
            this.CMD_btnDelete = new System.Windows.Forms.Button();
            this.CMD_btnUpdate = new System.Windows.Forms.Button();
            this.CMD_btnInsert = new System.Windows.Forms.Button();
            this.CMD_txtSearch = new System.Windows.Forms.TextBox();
            this.CMD_txtCodClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMD_txtCodCmd = new System.Windows.Forms.TextBox();
            this.CMD_dgwComenzi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CMD_dpDataCmd = new System.Windows.Forms.DateTimePicker();
            this.dataSet11 = new InterfataBD.DataSet1();
            this.label10 = new System.Windows.Forms.Label();
            this.cOMENZIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMENZITableAdapter = new InterfataBD.DataSet1TableAdapters.COMENZITableAdapter();
            this.CMD_listModPlata = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CMD_dgwComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CMD_btnDelete
            // 
            this.CMD_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CMD_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CMD_btnDelete.Location = new System.Drawing.Point(1436, 753);
            this.CMD_btnDelete.Name = "CMD_btnDelete";
            this.CMD_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.CMD_btnDelete.TabIndex = 47;
            this.CMD_btnDelete.Text = "Delete";
            this.CMD_btnDelete.UseVisualStyleBackColor = true;
            this.CMD_btnDelete.Click += new System.EventHandler(this.CMD_btnDelete_Click);
            // 
            // CMD_btnUpdate
            // 
            this.CMD_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CMD_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CMD_btnUpdate.Location = new System.Drawing.Point(1257, 753);
            this.CMD_btnUpdate.Name = "CMD_btnUpdate";
            this.CMD_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.CMD_btnUpdate.TabIndex = 46;
            this.CMD_btnUpdate.Text = "Update";
            this.CMD_btnUpdate.UseVisualStyleBackColor = true;
            this.CMD_btnUpdate.Click += new System.EventHandler(this.CMD_btnUpdate_Click);
            // 
            // CMD_btnInsert
            // 
            this.CMD_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CMD_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.CMD_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CMD_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CMD_btnInsert.Location = new System.Drawing.Point(1080, 753);
            this.CMD_btnInsert.Name = "CMD_btnInsert";
            this.CMD_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.CMD_btnInsert.TabIndex = 45;
            this.CMD_btnInsert.Text = "Insert";
            this.CMD_btnInsert.UseVisualStyleBackColor = false;
            this.CMD_btnInsert.Click += new System.EventHandler(this.CMD_btnInsert_Click);
            // 
            // CMD_txtSearch
            // 
            this.CMD_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_txtSearch.Location = new System.Drawing.Point(120, 53);
            this.CMD_txtSearch.Name = "CMD_txtSearch";
            this.CMD_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.CMD_txtSearch.TabIndex = 44;
            this.CMD_txtSearch.TextChanged += new System.EventHandler(this.CMD_txtSearch_TextChanged);
            // 
            // CMD_txtCodClient
            // 
            this.CMD_txtCodClient.Font = new System.Drawing.Font("Arial", 14F);
            this.CMD_txtCodClient.Location = new System.Drawing.Point(1350, 257);
            this.CMD_txtCodClient.Name = "CMD_txtCodClient";
            this.CMD_txtCodClient.Size = new System.Drawing.Size(220, 34);
            this.CMD_txtCodClient.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1075, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 35);
            this.label3.TabIndex = 31;
            this.label3.Text = "COD_CLIENT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1074, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "DATA_COMANDA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1075, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "MODALITATE_PLATA:";
            // 
            // CMD_txtCodCmd
            // 
            this.CMD_txtCodCmd.Font = new System.Drawing.Font("Arial", 14F);
            this.CMD_txtCodCmd.Location = new System.Drawing.Point(1350, 110);
            this.CMD_txtCodCmd.Name = "CMD_txtCodCmd";
            this.CMD_txtCodCmd.Size = new System.Drawing.Size(220, 34);
            this.CMD_txtCodCmd.TabIndex = 26;
            // 
            // CMD_dgwComenzi
            // 
            this.CMD_dgwComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CMD_dgwComenzi.BackgroundColor = System.Drawing.Color.White;
            this.CMD_dgwComenzi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CMD_dgwComenzi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CMD_dgwComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CMD_dgwComenzi.Location = new System.Drawing.Point(12, 102);
            this.CMD_dgwComenzi.Name = "CMD_dgwComenzi";
            this.CMD_dgwComenzi.ReadOnly = true;
            this.CMD_dgwComenzi.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.CMD_dgwComenzi.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CMD_dgwComenzi.RowTemplate.Height = 24;
            this.CMD_dgwComenzi.Size = new System.Drawing.Size(1048, 697);
            this.CMD_dgwComenzi.TabIndex = 24;
            this.CMD_dgwComenzi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CMD_dgwComenzi_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1075, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "COD_COMANDA:";
            // 
            // CMD_dpDataCmd
            // 
            this.CMD_dpDataCmd.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.CMD_dpDataCmd.CustomFormat = "dd-MMM-yy";
            this.CMD_dpDataCmd.Font = new System.Drawing.Font("Arial", 14F);
            this.CMD_dpDataCmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CMD_dpDataCmd.Location = new System.Drawing.Point(1350, 209);
            this.CMD_dpDataCmd.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.CMD_dpDataCmd.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.CMD_dpDataCmd.Name = "CMD_dpDataCmd";
            this.CMD_dpDataCmd.Size = new System.Drawing.Size(220, 34);
            this.CMD_dpDataCmd.TabIndex = 10;
            this.CMD_dpDataCmd.Value = new System.DateTime(2024, 1, 3, 0, 0, 0, 0);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 35);
            this.label10.TabIndex = 49;
            this.label10.Text = "Search:";
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
            // CMD_listModPlata
            // 
            this.CMD_listModPlata.Font = new System.Drawing.Font("Arial", 14F);
            this.CMD_listModPlata.FormattingEnabled = true;
            this.CMD_listModPlata.Items.AddRange(new object[] {
            "RAMBURS",
            "CARD"});
            this.CMD_listModPlata.Location = new System.Drawing.Point(1350, 159);
            this.CMD_listModPlata.Name = "CMD_listModPlata";
            this.CMD_listModPlata.Size = new System.Drawing.Size(220, 34);
            this.CMD_listModPlata.TabIndex = 51;
            // 
            // FormComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.CMD_listModPlata);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CMD_dpDataCmd);
            this.Controls.Add(this.CMD_btnDelete);
            this.Controls.Add(this.CMD_btnUpdate);
            this.Controls.Add(this.CMD_btnInsert);
            this.Controls.Add(this.CMD_txtSearch);
            this.Controls.Add(this.CMD_txtCodClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMD_txtCodCmd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMD_dgwComenzi);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormComenzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMENZI";
            this.Load += new System.EventHandler(this.FormComenzi_Load);
            this.Click += new System.EventHandler(this.FormComenzi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.CMD_dgwComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMENZIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMD_btnDelete;
        private System.Windows.Forms.Button CMD_btnUpdate;
        private System.Windows.Forms.Button CMD_btnInsert;
        private System.Windows.Forms.TextBox CMD_txtSearch;
        private System.Windows.Forms.TextBox CMD_txtCodClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CMD_txtCodCmd;
        private System.Windows.Forms.DataGridView CMD_dgwComenzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CMD_dpDataCmd;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource cOMENZIBindingSource;
        private DataSet1TableAdapters.COMENZITableAdapter cOMENZITableAdapter;
        private System.Windows.Forms.ComboBox CMD_listModPlata;
    }
}