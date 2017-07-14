namespace Askrift
{
    partial class endurp
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdags1 = new System.Windows.Forms.DateTimePicker();
            this.rdags2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samtals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rhaus1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textrdags = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textafsl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t2vsk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmvsk = new System.Windows.Forms.TextBox();
            this.t1vsk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tsamtals = new System.Windows.Forms.TextBox();
            this.solumadur = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rhaus2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdags1
            // 
            this.rdags1.CustomFormat = "";
            this.rdags1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdags1.Location = new System.Drawing.Point(11, 64);
            this.rdags1.Name = "rdags1";
            this.rdags1.Size = new System.Drawing.Size(97, 20);
            this.rdags1.TabIndex = 1;
            this.rdags1.Value = new System.DateTime(2010, 3, 10, 0, 0, 0, 0);
            // 
            // rdags2
            // 
            this.rdags2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdags2.Location = new System.Drawing.Point(133, 64);
            this.rdags2.Name = "rdags2";
            this.rdags2.Size = new System.Drawing.Size(96, 20);
            this.rdags2.TabIndex = 2;
            this.rdags2.Value = new System.DateTime(2010, 3, 10, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr,
            this.Texti,
            this.Verd,
            this.magn,
            this.afs,
            this.samtals});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(11, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 280);
            this.dataGridView1.TabIndex = 43;
            // 
            // nr
            // 
            this.nr.FillWeight = 50F;
            this.nr.HeaderText = "Nr";
            this.nr.Name = "nr";
            this.nr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nr.Width = 50;
            // 
            // Texti
            // 
            this.Texti.FillWeight = 270F;
            this.Texti.HeaderText = "Texti";
            this.Texti.Name = "Texti";
            this.Texti.Width = 270;
            // 
            // Verd
            // 
            this.Verd.HeaderText = "Verð";
            this.Verd.Name = "Verd";
            // 
            // magn
            // 
            this.magn.FillWeight = 45F;
            this.magn.HeaderText = "Magn";
            this.magn.Name = "magn";
            this.magn.Width = 45;
            // 
            // afs
            // 
            this.afs.FillWeight = 45F;
            this.afs.HeaderText = "Afsláttur";
            this.afs.Name = "afs";
            this.afs.Width = 45;
            // 
            // samtals
            // 
            this.samtals.HeaderText = "Samtals";
            this.samtals.Name = "samtals";
            // 
            // rhaus1
            // 
            this.rhaus1.Enabled = false;
            this.rhaus1.Location = new System.Drawing.Point(-4, -1);
            this.rhaus1.Multiline = true;
            this.rhaus1.Name = "rhaus1";
            this.rhaus1.Size = new System.Drawing.Size(416, 78);
            this.rhaus1.TabIndex = 44;
            this.rhaus1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Endurprenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textrdags
            // 
            this.textrdags.Enabled = false;
            this.textrdags.Location = new System.Drawing.Point(559, 67);
            this.textrdags.Name = "textrdags";
            this.textrdags.ReadOnly = true;
            this.textrdags.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textrdags.Size = new System.Drawing.Size(104, 20);
            this.textrdags.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Bókaðir reikningar";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(251, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.Text = "Reikningar";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyPress);
            // 
            // textafsl
            // 
            this.textafsl.Location = new System.Drawing.Point(391, 568);
            this.textafsl.Name = "textafsl";
            this.textafsl.Size = new System.Drawing.Size(100, 20);
            this.textafsl.TabIndex = 79;
            this.textafsl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Afsláttur Kr.";
            // 
            // t2vsk
            // 
            this.t2vsk.Location = new System.Drawing.Point(391, 539);
            this.t2vsk.Name = "t2vsk";
            this.t2vsk.Size = new System.Drawing.Size(100, 20);
            this.t2vsk.TabIndex = 77;
            this.t2vsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "VSK 7%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Samtals";
            // 
            // tmvsk
            // 
            this.tmvsk.Location = new System.Drawing.Point(563, 566);
            this.tmvsk.Name = "tmvsk";
            this.tmvsk.Size = new System.Drawing.Size(100, 20);
            this.tmvsk.TabIndex = 74;
            this.tmvsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // t1vsk
            // 
            this.t1vsk.Location = new System.Drawing.Point(563, 539);
            this.t1vsk.Name = "t1vsk";
            this.t1vsk.Size = new System.Drawing.Size(100, 20);
            this.t1vsk.TabIndex = 73;
            this.t1vsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "25.5% VSK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(474, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Samtals án VSK";
            // 
            // tsamtals
            // 
            this.tsamtals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsamtals.Location = new System.Drawing.Point(563, 505);
            this.tsamtals.Name = "tsamtals";
            this.tsamtals.Size = new System.Drawing.Size(100, 23);
            this.tsamtals.TabIndex = 70;
            this.tsamtals.Text = "0";
            this.tsamtals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // solumadur
            // 
            this.solumadur.Enabled = false;
            this.solumadur.Location = new System.Drawing.Point(343, 65);
            this.solumadur.Name = "solumadur";
            this.solumadur.ReadOnly = true;
            this.solumadur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.solumadur.Size = new System.Drawing.Size(161, 20);
            this.solumadur.TabIndex = 80;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 81;
            this.button2.Text = "Kreditfæra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rhaus2
            // 
            this.rhaus2.Enabled = false;
            this.rhaus2.Location = new System.Drawing.Point(0, 0);
            this.rhaus2.Multiline = true;
            this.rhaus2.Name = "rhaus2";
            this.rhaus2.Size = new System.Drawing.Size(401, 70);
            this.rhaus2.TabIndex = 82;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(247, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 99);
            this.tabControl1.TabIndex = 83;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rhaus1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 73);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aukatexti";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rhaus2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 73);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vinnulýsing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // endurp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 601);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.solumadur);
            this.Controls.Add(this.textafsl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t2vsk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tmvsk);
            this.Controls.Add(this.t1vsk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tsamtals);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textrdags);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdags2);
            this.Controls.Add(this.rdags1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "endurp";
            this.Text = "Reikningar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker rdags1;
        private System.Windows.Forms.DateTimePicker rdags2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verd;
        private System.Windows.Forms.DataGridViewTextBoxColumn magn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afs;
        private System.Windows.Forms.DataGridViewTextBoxColumn samtals;
        private System.Windows.Forms.TextBox rhaus1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textrdags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textafsl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t2vsk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tmvsk;
        private System.Windows.Forms.TextBox t1vsk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tsamtals;
        private System.Windows.Forms.TextBox solumadur;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rhaus2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}