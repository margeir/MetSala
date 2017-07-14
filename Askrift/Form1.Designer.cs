namespace Askrift
{
    partial class g_peningar
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
            this.verd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.haetta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verd
            // 
            this.verd.Location = new System.Drawing.Point(232, 111);
            this.verd.Name = "verd";
            this.verd.Size = new System.Drawing.Size(174, 20);
            this.verd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // haetta
            // 
            this.haetta.Location = new System.Drawing.Point(470, 127);
            this.haetta.Name = "haetta";
            this.haetta.Size = new System.Drawing.Size(75, 23);
            this.haetta.TabIndex = 2;
            this.haetta.Text = "Hætta";
            this.haetta.UseVisualStyleBackColor = true;
            this.haetta.Click += new System.EventHandler(this.haetta_Click);
            // 
            // g_peningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 199);
            this.ControlBox = false;
            this.Controls.Add(this.haetta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "g_peningar";
            this.Text = "Greiðsla Peningar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox verd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button haetta;
    }
}