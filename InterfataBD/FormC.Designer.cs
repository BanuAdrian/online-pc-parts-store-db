namespace InterfataBD
{
    partial class FormC
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
            this.C_txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.C_dgwPunctC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.C_dgwPunctC)).BeginInit();
            this.SuspendLayout();
            // 
            // C_txtSearch
            // 
            this.C_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_txtSearch.Location = new System.Drawing.Point(378, 53);
            this.C_txtSearch.Name = "C_txtSearch";
            this.C_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.C_txtSearch.TabIndex = 47;
            this.C_txtSearch.TextChanged += new System.EventHandler(this.C_txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(264, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 35);
            this.label10.TabIndex = 46;
            this.label10.Text = "Search:";
            // 
            // C_dgwPunctC
            // 
            this.C_dgwPunctC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.C_dgwPunctC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.C_dgwPunctC.BackgroundColor = System.Drawing.Color.White;
            this.C_dgwPunctC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.C_dgwPunctC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.C_dgwPunctC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_dgwPunctC.Location = new System.Drawing.Point(12, 102);
            this.C_dgwPunctC.Name = "C_dgwPunctC";
            this.C_dgwPunctC.ReadOnly = true;
            this.C_dgwPunctC.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.C_dgwPunctC.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.C_dgwPunctC.RowTemplate.Height = 24;
            this.C_dgwPunctC.Size = new System.Drawing.Size(1508, 739);
            this.C_dgwPunctC.TabIndex = 45;
            // 
            // FormC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.C_txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.C_dgwPunctC);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punctul C";
            this.Load += new System.EventHandler(this.FormC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C_dgwPunctC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox C_txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView C_dgwPunctC;
    }
}