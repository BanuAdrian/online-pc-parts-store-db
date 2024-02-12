namespace InterfataBD
{
    partial class FormD
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
            this.D_txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.D_dgwPunctD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.D_dgwPunctD)).BeginInit();
            this.SuspendLayout();
            // 
            // D_txtSearch
            // 
            this.D_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_txtSearch.Location = new System.Drawing.Point(378, 53);
            this.D_txtSearch.Name = "D_txtSearch";
            this.D_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.D_txtSearch.TabIndex = 50;
            this.D_txtSearch.TextChanged += new System.EventHandler(this.D_txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(262, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 35);
            this.label10.TabIndex = 49;
            this.label10.Text = "Search:";
            // 
            // D_dgwPunctD
            // 
            this.D_dgwPunctD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.D_dgwPunctD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.D_dgwPunctD.BackgroundColor = System.Drawing.Color.White;
            this.D_dgwPunctD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.D_dgwPunctD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.D_dgwPunctD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_dgwPunctD.Location = new System.Drawing.Point(12, 102);
            this.D_dgwPunctD.Name = "D_dgwPunctD";
            this.D_dgwPunctD.ReadOnly = true;
            this.D_dgwPunctD.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.D_dgwPunctD.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.D_dgwPunctD.RowTemplate.Height = 24;
            this.D_dgwPunctD.Size = new System.Drawing.Size(1510, 739);
            this.D_dgwPunctD.TabIndex = 48;
            // 
            // FormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.D_txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.D_dgwPunctD);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormD";
            this.Load += new System.EventHandler(this.FormD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D_dgwPunctD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox D_txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView D_dgwPunctD;
    }
}