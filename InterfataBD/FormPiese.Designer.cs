namespace InterfataBD
{
    partial class FormPiese
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PS_btnDelete = new System.Windows.Forms.Button();
            this.PS_btnUpdate = new System.Windows.Forms.Button();
            this.PS_btnInsert = new System.Windows.Forms.Button();
            this.PS_txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PS_txtCodProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PS_txtCodCat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PS_txtGrt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PS_txtPretVanzare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PS_txtModelPiesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PS_txtCodPiesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PS_dgwPiese = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PS_dgwPiese)).BeginInit();
            this.SuspendLayout();
            // 
            // PS_btnDelete
            // 
            this.PS_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PS_btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS_btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PS_btnDelete.Location = new System.Drawing.Point(1439, 753);
            this.PS_btnDelete.Name = "PS_btnDelete";
            this.PS_btnDelete.Size = new System.Drawing.Size(134, 46);
            this.PS_btnDelete.TabIndex = 69;
            this.PS_btnDelete.Text = "Delete";
            this.PS_btnDelete.UseVisualStyleBackColor = true;
            this.PS_btnDelete.Click += new System.EventHandler(this.PS_btnDelete_Click);
            // 
            // PS_btnUpdate
            // 
            this.PS_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PS_btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS_btnUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PS_btnUpdate.Location = new System.Drawing.Point(1260, 753);
            this.PS_btnUpdate.Name = "PS_btnUpdate";
            this.PS_btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.PS_btnUpdate.TabIndex = 68;
            this.PS_btnUpdate.Text = "Update";
            this.PS_btnUpdate.UseVisualStyleBackColor = true;
            this.PS_btnUpdate.Click += new System.EventHandler(this.PS_btnUpdate_Click);
            // 
            // PS_btnInsert
            // 
            this.PS_btnInsert.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PS_btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.PS_btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PS_btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS_btnInsert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PS_btnInsert.Location = new System.Drawing.Point(1083, 753);
            this.PS_btnInsert.Name = "PS_btnInsert";
            this.PS_btnInsert.Size = new System.Drawing.Size(134, 46);
            this.PS_btnInsert.TabIndex = 67;
            this.PS_btnInsert.Text = "Insert";
            this.PS_btnInsert.UseVisualStyleBackColor = false;
            this.PS_btnInsert.Click += new System.EventHandler(this.PS_btnInsert_Click);
            // 
            // PS_txtSearch
            // 
            this.PS_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS_txtSearch.Location = new System.Drawing.Point(123, 53);
            this.PS_txtSearch.Name = "PS_txtSearch";
            this.PS_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.PS_txtSearch.TabIndex = 66;
            this.PS_txtSearch.TextChanged += new System.EventHandler(this.PS_txtSearch_TextChanged);
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
            this.label10.TabIndex = 65;
            this.label10.Text = "Search:";
            // 
            // PS_txtCodProd
            // 
            this.PS_txtCodProd.Font = new System.Drawing.Font("Arial", 14F);
            this.PS_txtCodProd.Location = new System.Drawing.Point(1386, 362);
            this.PS_txtCodProd.Name = "PS_txtCodProd";
            this.PS_txtCodProd.Size = new System.Drawing.Size(187, 34);
            this.PS_txtCodProd.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1078, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 35);
            this.label7.TabIndex = 60;
            this.label7.Text = "COD_PRODUCATOR:";
            // 
            // PS_txtCodCat
            // 
            this.PS_txtCodCat.Font = new System.Drawing.Font("Arial", 14F);
            this.PS_txtCodCat.Location = new System.Drawing.Point(1386, 309);
            this.PS_txtCodCat.Name = "PS_txtCodCat";
            this.PS_txtCodCat.Size = new System.Drawing.Size(187, 34);
            this.PS_txtCodCat.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1078, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 35);
            this.label8.TabIndex = 58;
            this.label8.Text = "COD_CATEGORIE:";
            // 
            // PS_txtGrt
            // 
            this.PS_txtGrt.Font = new System.Drawing.Font("Arial", 14F);
            this.PS_txtGrt.Location = new System.Drawing.Point(1386, 257);
            this.PS_txtGrt.Name = "PS_txtGrt";
            this.PS_txtGrt.Size = new System.Drawing.Size(187, 34);
            this.PS_txtGrt.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1078, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 35);
            this.label3.TabIndex = 56;
            this.label3.Text = "GARANTIE_COMERCIALA:";
            // 
            // PS_txtPretVanzare
            // 
            this.PS_txtPretVanzare.Font = new System.Drawing.Font("Arial", 14F);
            this.PS_txtPretVanzare.Location = new System.Drawing.Point(1386, 208);
            this.PS_txtPretVanzare.Name = "PS_txtPretVanzare";
            this.PS_txtPretVanzare.Size = new System.Drawing.Size(187, 34);
            this.PS_txtPretVanzare.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1078, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 35);
            this.label4.TabIndex = 54;
            this.label4.Text = "PRET_VANZARE:";
            // 
            // PS_txtModelPiesa
            // 
            this.PS_txtModelPiesa.Font = new System.Drawing.Font("Arial", 14F);
            this.PS_txtModelPiesa.Location = new System.Drawing.Point(1386, 159);
            this.PS_txtModelPiesa.Name = "PS_txtModelPiesa";
            this.PS_txtModelPiesa.Size = new System.Drawing.Size(187, 34);
            this.PS_txtModelPiesa.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1078, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 35);
            this.label2.TabIndex = 52;
            this.label2.Text = "MODEL_PIESA:";
            // 
            // PS_txtCodPiesa
            // 
            this.PS_txtCodPiesa.Font = new System.Drawing.Font("Arial", 14F);
            this.PS_txtCodPiesa.Location = new System.Drawing.Point(1386, 110);
            this.PS_txtCodPiesa.Name = "PS_txtCodPiesa";
            this.PS_txtCodPiesa.Size = new System.Drawing.Size(187, 34);
            this.PS_txtCodPiesa.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1078, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 50;
            this.label1.Text = "COD_PIESA:";
            // 
            // PS_dgwPiese
            // 
            this.PS_dgwPiese.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PS_dgwPiese.BackgroundColor = System.Drawing.Color.White;
            this.PS_dgwPiese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PS_dgwPiese.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.PS_dgwPiese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PS_dgwPiese.Location = new System.Drawing.Point(15, 102);
            this.PS_dgwPiese.Name = "PS_dgwPiese";
            this.PS_dgwPiese.ReadOnly = true;
            this.PS_dgwPiese.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            this.PS_dgwPiese.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PS_dgwPiese.RowTemplate.Height = 24;
            this.PS_dgwPiese.Size = new System.Drawing.Size(1048, 697);
            this.PS_dgwPiese.TabIndex = 49;
            this.PS_dgwPiese.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PS_dgwPiese_CellEnter);
            // 
            // FormPiese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.PS_btnDelete);
            this.Controls.Add(this.PS_btnUpdate);
            this.Controls.Add(this.PS_btnInsert);
            this.Controls.Add(this.PS_txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PS_txtCodProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PS_txtCodCat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PS_txtGrt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PS_txtPretVanzare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PS_txtModelPiesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PS_txtCodPiesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PS_dgwPiese);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormPiese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIESE";
            this.Load += new System.EventHandler(this.FormPiese_Load);
            this.Click += new System.EventHandler(this.FormPiese_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PS_dgwPiese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PS_btnDelete;
        private System.Windows.Forms.Button PS_btnUpdate;
        private System.Windows.Forms.Button PS_btnInsert;
        private System.Windows.Forms.TextBox PS_txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PS_txtCodProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PS_txtCodCat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PS_txtGrt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PS_txtPretVanzare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PS_txtModelPiesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PS_txtCodPiesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PS_dgwPiese;
    }
}