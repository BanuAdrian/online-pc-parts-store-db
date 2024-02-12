namespace InterfataBD
{
    partial class FormAngajati
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ANG_btnDelete = new System.Windows.Forms.Button();
            this.ANG_btnUpdate = new System.Windows.Forms.Button();
            this.ANG_btnInsert = new System.Windows.Forms.Button();
            this.ANG_txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ANG_txtCodDpt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ANG_txtSalariu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ANG_txtTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ANG_txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ANG_txtPrenume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ANG_txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ANG_txtCodAngajat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ANG_dgwAngajati = new System.Windows.Forms.DataGridView();
            this.ANG_dpDataAng = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ANG_dgwAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // ANG_btnDelete
            // 
            this.ANG_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ANG_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANG_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ANG_btnDelete.Location = new System.Drawing.Point(1439, 753);
            this.ANG_btnDelete.Name = "ANG_btnDelete";
            this.ANG_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.ANG_btnDelete.TabIndex = 47;
            this.ANG_btnDelete.Text = "Delete";
            this.ANG_btnDelete.UseVisualStyleBackColor = true;
            this.ANG_btnDelete.Click += new System.EventHandler(this.ANG_btnDelete_Click);
            // 
            // ANG_btnUpdate
            // 
            this.ANG_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ANG_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANG_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ANG_btnUpdate.Location = new System.Drawing.Point(1260, 753);
            this.ANG_btnUpdate.Name = "ANG_btnUpdate";
            this.ANG_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.ANG_btnUpdate.TabIndex = 46;
            this.ANG_btnUpdate.Text = "Update";
            this.ANG_btnUpdate.UseVisualStyleBackColor = true;
            this.ANG_btnUpdate.Click += new System.EventHandler(this.ANG_btnUpdate_Click);
            // 
            // ANG_btnInsert
            // 
            this.ANG_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ANG_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.ANG_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ANG_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANG_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ANG_btnInsert.Location = new System.Drawing.Point(1083, 753);
            this.ANG_btnInsert.Name = "ANG_btnInsert";
            this.ANG_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.ANG_btnInsert.TabIndex = 45;
            this.ANG_btnInsert.Text = "Insert";
            this.ANG_btnInsert.UseVisualStyleBackColor = false;
            this.ANG_btnInsert.Click += new System.EventHandler(this.ANG_btnInsert_Click);
            // 
            // ANG_txtSearch
            // 
            this.ANG_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANG_txtSearch.Location = new System.Drawing.Point(123, 53);
            this.ANG_txtSearch.Name = "ANG_txtSearch";
            this.ANG_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.ANG_txtSearch.TabIndex = 44;
            this.ANG_txtSearch.TextChanged += new System.EventHandler(this.ANG_txtSearch_TextChanged);
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
            this.label10.TabIndex = 43;
            this.label10.Text = "Search:";
            // 
            // ANG_txtCodDpt
            // 
            this.ANG_txtCodDpt.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_txtCodDpt.Location = new System.Drawing.Point(1338, 460);
            this.ANG_txtCodDpt.Name = "ANG_txtCodDpt";
            this.ANG_txtCodDpt.Size = new System.Drawing.Size(235, 34);
            this.ANG_txtCodDpt.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1078, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 35);
            this.label5.TabIndex = 39;
            this.label5.Text = "COD_DEPARTAMENT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1078, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 35);
            this.label6.TabIndex = 37;
            this.label6.Text = "DATA_ANGAJARE:";
            // 
            // ANG_txtSalariu
            // 
            this.ANG_txtSalariu.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_txtSalariu.Location = new System.Drawing.Point(1338, 362);
            this.ANG_txtSalariu.Name = "ANG_txtSalariu";
            this.ANG_txtSalariu.Size = new System.Drawing.Size(235, 34);
            this.ANG_txtSalariu.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1078, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 35);
            this.label7.TabIndex = 35;
            this.label7.Text = "SALARIU:";
            // 
            // ANG_txtTel
            // 
            this.ANG_txtTel.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_txtTel.Location = new System.Drawing.Point(1338, 309);
            this.ANG_txtTel.Name = "ANG_txtTel";
            this.ANG_txtTel.Size = new System.Drawing.Size(235, 34);
            this.ANG_txtTel.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1078, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 35);
            this.label8.TabIndex = 33;
            this.label8.Text = "TELEFON:";
            // 
            // ANG_txtEmail
            // 
            this.ANG_txtEmail.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_txtEmail.Location = new System.Drawing.Point(1338, 257);
            this.ANG_txtEmail.Name = "ANG_txtEmail";
            this.ANG_txtEmail.Size = new System.Drawing.Size(235, 34);
            this.ANG_txtEmail.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1078, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 35);
            this.label3.TabIndex = 31;
            this.label3.Text = "EMAIL:";
            // 
            // ANG_txtPrenume
            // 
            this.ANG_txtPrenume.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_txtPrenume.Location = new System.Drawing.Point(1338, 208);
            this.ANG_txtPrenume.Name = "ANG_txtPrenume";
            this.ANG_txtPrenume.Size = new System.Drawing.Size(235, 34);
            this.ANG_txtPrenume.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1078, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "PRENUME:";
            // 
            // ANG_txtNume
            // 
            this.ANG_txtNume.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_txtNume.Location = new System.Drawing.Point(1338, 159);
            this.ANG_txtNume.Name = "ANG_txtNume";
            this.ANG_txtNume.Size = new System.Drawing.Size(235, 34);
            this.ANG_txtNume.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "NUME:";
            // 
            // ANG_txtCodAngajat
            // 
            this.ANG_txtCodAngajat.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_txtCodAngajat.Location = new System.Drawing.Point(1338, 110);
            this.ANG_txtCodAngajat.Name = "ANG_txtCodAngajat";
            this.ANG_txtCodAngajat.Size = new System.Drawing.Size(235, 34);
            this.ANG_txtCodAngajat.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "COD_ANGAJAT:";
            // 
            // ANG_dgwAngajati
            // 
            this.ANG_dgwAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ANG_dgwAngajati.BackgroundColor = System.Drawing.Color.White;
            this.ANG_dgwAngajati.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ANG_dgwAngajati.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ANG_dgwAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ANG_dgwAngajati.Location = new System.Drawing.Point(15, 102);
            this.ANG_dgwAngajati.Name = "ANG_dgwAngajati";
            this.ANG_dgwAngajati.ReadOnly = true;
            this.ANG_dgwAngajati.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.ANG_dgwAngajati.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ANG_dgwAngajati.RowTemplate.Height = 24;
            this.ANG_dgwAngajati.Size = new System.Drawing.Size(1048, 697);
            this.ANG_dgwAngajati.TabIndex = 24;
            this.ANG_dgwAngajati.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ANG_dgwAngajati_CellEnter);
            // 
            // ANG_dpDataAng
            // 
            this.ANG_dpDataAng.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.ANG_dpDataAng.CustomFormat = "dd-MMM-yy";
            this.ANG_dpDataAng.Font = new System.Drawing.Font("Arial", 14F);
            this.ANG_dpDataAng.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ANG_dpDataAng.Location = new System.Drawing.Point(1338, 412);
            this.ANG_dpDataAng.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.ANG_dpDataAng.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.ANG_dpDataAng.Name = "ANG_dpDataAng";
            this.ANG_dpDataAng.Size = new System.Drawing.Size(232, 34);
            this.ANG_dpDataAng.TabIndex = 48;
            this.ANG_dpDataAng.Value = new System.DateTime(2024, 1, 3, 0, 0, 0, 0);
            // 
            // FormAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.ANG_dpDataAng);
            this.Controls.Add(this.ANG_btnDelete);
            this.Controls.Add(this.ANG_btnUpdate);
            this.Controls.Add(this.ANG_btnInsert);
            this.Controls.Add(this.ANG_txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ANG_txtCodDpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ANG_txtSalariu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ANG_txtTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ANG_txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ANG_txtPrenume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ANG_txtNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ANG_txtCodAngajat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ANG_dgwAngajati);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormAngajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANGAJATI";
            this.Load += new System.EventHandler(this.FormAngajati_Load);
            this.Click += new System.EventHandler(this.FormAngajati_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ANG_dgwAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ANG_btnDelete;
        private System.Windows.Forms.Button ANG_btnUpdate;
        private System.Windows.Forms.Button ANG_btnInsert;
        private System.Windows.Forms.TextBox ANG_txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ANG_txtCodDpt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ANG_txtSalariu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ANG_txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ANG_txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ANG_txtPrenume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ANG_txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ANG_txtCodAngajat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ANG_dgwAngajati;
        private System.Windows.Forms.DateTimePicker ANG_dpDataAng;
    }
}