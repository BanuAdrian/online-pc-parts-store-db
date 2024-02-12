namespace InterfataBD
{
    partial class FormVizComplexa
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
            this.VCMX_txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VCMX_dgwVizComplexa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VCMX_dgwVizComplexa)).BeginInit();
            this.SuspendLayout();
            // 
            // VCMX_txtSearch
            // 
            this.VCMX_txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCMX_txtSearch.Location = new System.Drawing.Point(378, 53);
            this.VCMX_txtSearch.Name = "VCMX_txtSearch";
            this.VCMX_txtSearch.Size = new System.Drawing.Size(940, 34);
            this.VCMX_txtSearch.TabIndex = 53;
            this.VCMX_txtSearch.TextChanged += new System.EventHandler(this.VCMX_txtSearch_TextChanged);
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
            this.label10.TabIndex = 52;
            this.label10.Text = "Search:";
            // 
            // VCMX_dgwVizComplexa
            // 
            this.VCMX_dgwVizComplexa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VCMX_dgwVizComplexa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.VCMX_dgwVizComplexa.BackgroundColor = System.Drawing.Color.White;
            this.VCMX_dgwVizComplexa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VCMX_dgwVizComplexa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.VCMX_dgwVizComplexa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VCMX_dgwVizComplexa.Location = new System.Drawing.Point(12, 102);
            this.VCMX_dgwVizComplexa.Name = "VCMX_dgwVizComplexa";
            this.VCMX_dgwVizComplexa.ReadOnly = true;
            this.VCMX_dgwVizComplexa.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.VCMX_dgwVizComplexa.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VCMX_dgwVizComplexa.RowTemplate.Height = 24;
            this.VCMX_dgwVizComplexa.Size = new System.Drawing.Size(1508, 739);
            this.VCMX_dgwVizComplexa.TabIndex = 51;
            // 
            // FormVizComplexa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::InterfataBD.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.VCMX_txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VCMX_dgwVizComplexa);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormVizComplexa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare Complexa";
            this.Load += new System.EventHandler(this.FormVizComplexa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VCMX_dgwVizComplexa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VCMX_txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView VCMX_dgwVizComplexa;
    }
}