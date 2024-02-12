namespace InterfataBD
{
    partial class FormClienti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CLT_dgwClienti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CLT_txtCodClient = new System.Windows.Forms.TextBox();
            this.CLT_txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CLT_txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CLT_txtPrenume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CLT_txtLocClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CLT_txtNrClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CLT_txtStrClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CLT_txtTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CLT_txtJudClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CLT_txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CLT_btnInsert = new System.Windows.Forms.Button();
            this.CLT_btnUpdate = new System.Windows.Forms.Button();
            this.CLT_btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CLT_dgwClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // CLT_dgwClienti
            // 
            this.CLT_dgwClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CLT_dgwClienti.BackgroundColor = System.Drawing.Color.White;
            this.CLT_dgwClienti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CLT_dgwClienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CLT_dgwClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLT_dgwClienti.Location = new System.Drawing.Point(12, 102);
            this.CLT_dgwClienti.Name = "CLT_dgwClienti";
            this.CLT_dgwClienti.ReadOnly = true;
            this.CLT_dgwClienti.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            this.CLT_dgwClienti.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CLT_dgwClienti.RowTemplate.Height = 24;
            this.CLT_dgwClienti.Size = new System.Drawing.Size(1048, 697);
            this.CLT_dgwClienti.TabIndex = 0;
            this.CLT_dgwClienti.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwClienti_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1075, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "COD_CLIENT:";
            // 
            // CLT_txtCodClient
            // 
            this.CLT_txtCodClient.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtCodClient.Location = new System.Drawing.Point(1298, 110);
            this.CLT_txtCodClient.Name = "CLT_txtCodClient";
            this.CLT_txtCodClient.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtCodClient.TabIndex = 2;
            // 
            // CLT_txtNume
            // 
            this.CLT_txtNume.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtNume.Location = new System.Drawing.Point(1298, 159);
            this.CLT_txtNume.Name = "CLT_txtNume";
            this.CLT_txtNume.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtNume.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1075, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUME:";
            // 
            // CLT_txtEmail
            // 
            this.CLT_txtEmail.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtEmail.Location = new System.Drawing.Point(1298, 257);
            this.CLT_txtEmail.Name = "CLT_txtEmail";
            this.CLT_txtEmail.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1075, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "EMAIL:";
            // 
            // CLT_txtPrenume
            // 
            this.CLT_txtPrenume.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtPrenume.Location = new System.Drawing.Point(1298, 208);
            this.CLT_txtPrenume.Name = "CLT_txtPrenume";
            this.CLT_txtPrenume.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtPrenume.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1075, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "PRENUME:";
            // 
            // CLT_txtLocClient
            // 
            this.CLT_txtLocClient.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtLocClient.Location = new System.Drawing.Point(1298, 460);
            this.CLT_txtLocClient.Name = "CLT_txtLocClient";
            this.CLT_txtLocClient.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtLocClient.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1075, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "LOCALITATE:";
            // 
            // CLT_txtNrClient
            // 
            this.CLT_txtNrClient.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtNrClient.Location = new System.Drawing.Point(1298, 411);
            this.CLT_txtNrClient.Name = "CLT_txtNrClient";
            this.CLT_txtNrClient.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtNrClient.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1075, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "NUMAR:";
            // 
            // CLT_txtStrClient
            // 
            this.CLT_txtStrClient.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtStrClient.Location = new System.Drawing.Point(1298, 362);
            this.CLT_txtStrClient.Name = "CLT_txtStrClient";
            this.CLT_txtStrClient.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtStrClient.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1075, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 35);
            this.label7.TabIndex = 11;
            this.label7.Text = "STRADA:";
            // 
            // CLT_txtTel
            // 
            this.CLT_txtTel.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtTel.Location = new System.Drawing.Point(1298, 309);
            this.CLT_txtTel.Name = "CLT_txtTel";
            this.CLT_txtTel.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtTel.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1075, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 35);
            this.label8.TabIndex = 9;
            this.label8.Text = "TELEFON:";
            // 
            // CLT_txtJudClient
            // 
            this.CLT_txtJudClient.Font = new System.Drawing.Font("Arial", 14F);
            this.CLT_txtJudClient.Location = new System.Drawing.Point(1298, 507);
            this.CLT_txtJudClient.Name = "CLT_txtJudClient";
            this.CLT_txtJudClient.Size = new System.Drawing.Size(272, 34);
            this.CLT_txtJudClient.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1075, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 35);
            this.label9.TabIndex = 17;
            this.label9.Text = "JUDET:";
            // 
            // CLT_txtSearch
            // 
            this.CLT_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLT_txtSearch.Location = new System.Drawing.Point(120, 53);
            this.CLT_txtSearch.Name = "CLT_txtSearch";
            this.CLT_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.CLT_txtSearch.TabIndex = 20;
            this.CLT_txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 35);
            this.label10.TabIndex = 19;
            this.label10.Text = "Search:";
            // 
            // CLT_btnInsert
            // 
            this.CLT_btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.CLT_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.CLT_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CLT_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLT_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CLT_btnInsert.Location = new System.Drawing.Point(1080, 753);
            this.CLT_btnInsert.Name = "CLT_btnInsert";
            this.CLT_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.CLT_btnInsert.TabIndex = 21;
            this.CLT_btnInsert.Text = "Insert";
            this.CLT_btnInsert.UseVisualStyleBackColor = false;
            this.CLT_btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // CLT_btnUpdate
            // 
            this.CLT_btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.CLT_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CLT_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLT_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CLT_btnUpdate.Location = new System.Drawing.Point(1257, 753);
            this.CLT_btnUpdate.Name = "CLT_btnUpdate";
            this.CLT_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.CLT_btnUpdate.TabIndex = 22;
            this.CLT_btnUpdate.Text = "Update";
            this.CLT_btnUpdate.UseVisualStyleBackColor = false;
            this.CLT_btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // CLT_btnDelete
            // 
            this.CLT_btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.CLT_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CLT_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLT_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CLT_btnDelete.Location = new System.Drawing.Point(1436, 753);
            this.CLT_btnDelete.Name = "CLT_btnDelete";
            this.CLT_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.CLT_btnDelete.TabIndex = 23;
            this.CLT_btnDelete.Text = "Delete";
            this.CLT_btnDelete.UseVisualStyleBackColor = false;
            this.CLT_btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.CLT_btnDelete);
            this.Controls.Add(this.CLT_btnUpdate);
            this.Controls.Add(this.CLT_btnInsert);
            this.Controls.Add(this.CLT_txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CLT_txtJudClient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CLT_txtLocClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CLT_txtNrClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CLT_txtStrClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CLT_txtTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CLT_txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLT_txtPrenume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CLT_txtNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLT_txtCodClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLT_dgwClienti);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormClienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENTI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.FormClienti_Click);
            ((System.ComponentModel.ISupportInitialize)(this.CLT_dgwClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CLT_dgwClienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CLT_txtCodClient;
        private System.Windows.Forms.TextBox CLT_txtNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CLT_txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CLT_txtPrenume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CLT_txtLocClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CLT_txtNrClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CLT_txtStrClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CLT_txtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CLT_txtJudClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CLT_txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CLT_btnInsert;
        private System.Windows.Forms.Button CLT_btnUpdate;
        private System.Windows.Forms.Button CLT_btnDelete;
    }
}