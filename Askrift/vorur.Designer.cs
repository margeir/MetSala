namespace Askrift
{
    partial class vorur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnafn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verd_vsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vnr,
            this.vnafn,
            this.verd,
            this.verd_vsk});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(492, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vnr
            // 
            this.vnr.FillWeight = 50F;
            this.vnr.HeaderText = "Númer";
            this.vnr.Name = "vnr";
            this.vnr.Width = 50;
            // 
            // vnafn
            // 
            this.vnafn.FillWeight = 280F;
            this.vnafn.HeaderText = "Lýsing vöru";
            this.vnafn.Name = "vnafn";
            this.vnafn.Width = 280;
            // 
            // verd
            // 
            this.verd.FillWeight = 75F;
            this.verd.HeaderText = "Verð";
            this.verd.Name = "verd";
            this.verd.Width = 75;
            // 
            // verd_vsk
            // 
            this.verd_vsk.FillWeight = 75F;
            this.verd_vsk.HeaderText = "VSK";
            this.verd_vsk.Name = "verd_vsk";
            this.verd_vsk.Width = 75;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(494, 434);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Vörulisti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn vnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnafn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verd;
        private System.Windows.Forms.DataGridViewTextBoxColumn verd_vsk;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}