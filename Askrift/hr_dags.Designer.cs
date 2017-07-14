namespace Askrift
{
    partial class hr_dags
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
            this.dags1 = new System.Windows.Forms.DateTimePicker();
            this.dags2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text_kt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dags1
            // 
            this.dags1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dags1.Location = new System.Drawing.Point(47, 80);
            this.dags1.Name = "dags1";
            this.dags1.Size = new System.Drawing.Size(98, 20);
            this.dags1.TabIndex = 0;
            this.dags1.ValueChanged += new System.EventHandler(this.dags1_ValueChanged);
            // 
            // dags2
            // 
            this.dags2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dags2.Location = new System.Drawing.Point(175, 80);
            this.dags2.Name = "dags2";
            this.dags2.Size = new System.Drawing.Size(94, 20);
            this.dags2.TabIndex = 1;
            this.dags2.ValueChanged += new System.EventHandler(this.dags2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hætta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_kt
            // 
            this.text_kt.Location = new System.Drawing.Point(47, 36);
            this.text_kt.Name = "text_kt";
            this.text_kt.Size = new System.Drawing.Size(222, 20);
            this.text_kt.TabIndex = 4;
            // 
            // hr_dags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 160);
            this.ControlBox = false;
            this.Controls.Add(this.text_kt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dags2);
            this.Controls.Add(this.dags1);
            this.Name = "hr_dags";
            this.Text = "Dags";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dags1;
        private System.Windows.Forms.DateTimePicker dags2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_kt;
    }
}