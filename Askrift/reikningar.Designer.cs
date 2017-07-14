namespace Askrift
{
    partial class reikningar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samtals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samt_mvsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rhaus2 = new System.Windows.Forms.TextBox();
            this.rdags = new System.Windows.Forms.DateTimePicker();
            this.simi = new System.Windows.Forms.TextBox();
            this.kennitala = new System.Windows.Forms.TextBox();
            this.pnr = new System.Windows.Forms.TextBox();
            this.heimili = new System.Windows.Forms.TextBox();
            this.debug1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rhaus1 = new System.Windows.Forms.TextBox();
            this.r_prenta = new System.Windows.Forms.Button();
            this.sanvsk = new System.Windows.Forms.TextBox();
            this.smvsk = new System.Windows.Forms.TextBox();
            this.s1vsk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.set_askrift = new System.Windows.Forms.Button();
            this.stadur = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textAfsl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.s2vsk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reikningur = new System.Windows.Forms.TabPage();
            this.Vinnulýsing = new System.Windows.Forms.TabPage();
            this.b_kredit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.b_peningar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Reikningur.SuspendLayout();
            this.Vinnulýsing.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr,
            this.Texti,
            this.Verd,
            this.magn,
            this.afs,
            this.samtals,
            this.samt_mvsk});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 345);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_CellContentClick);
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
            dataGridViewCellStyle1.NullValue = null;
            this.afs.DefaultCellStyle = dataGridViewCellStyle1;
            this.afs.FillWeight = 30F;
            this.afs.HeaderText = "Afs.";
            this.afs.Name = "afs";
            this.afs.Width = 30;
            // 
            // samtals
            // 
            this.samtals.FillWeight = 90F;
            this.samtals.HeaderText = "Samtals";
            this.samtals.Name = "samtals";
            this.samtals.Width = 90;
            // 
            // samt_mvsk
            // 
            this.samt_mvsk.FillWeight = 90F;
            this.samt_mvsk.HeaderText = "Samtals með VSK";
            this.samt_mvsk.Name = "samt_mvsk";
            this.samt_mvsk.Width = 90;
            // 
            // rhaus2
            // 
            this.rhaus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhaus2.Location = new System.Drawing.Point(6, 6);
            this.rhaus2.Multiline = true;
            this.rhaus2.Name = "rhaus2";
            this.rhaus2.Size = new System.Drawing.Size(709, 349);
            this.rhaus2.TabIndex = 45;
            this.rhaus2.TabStop = false;
            // 
            // rdags
            // 
            this.rdags.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdags.Location = new System.Drawing.Point(618, 57);
            this.rdags.Name = "rdags";
            this.rdags.Size = new System.Drawing.Size(87, 20);
            this.rdags.TabIndex = 44;
            this.rdags.TabStop = false;
            this.rdags.Value = new System.DateTime(2010, 3, 7, 0, 0, 0, 0);
            // 
            // simi
            // 
            this.simi.Location = new System.Drawing.Point(52, 152);
            this.simi.Name = "simi";
            this.simi.Size = new System.Drawing.Size(100, 20);
            this.simi.TabIndex = 41;
            this.simi.TabStop = false;
            // 
            // kennitala
            // 
            this.kennitala.Location = new System.Drawing.Point(279, 98);
            this.kennitala.Name = "kennitala";
            this.kennitala.Size = new System.Drawing.Size(97, 20);
            this.kennitala.TabIndex = 40;
            this.kennitala.TabStop = false;
            // 
            // pnr
            // 
            this.pnr.Location = new System.Drawing.Point(52, 126);
            this.pnr.Name = "pnr";
            this.pnr.Size = new System.Drawing.Size(36, 20);
            this.pnr.TabIndex = 39;
            this.pnr.TabStop = false;
            // 
            // heimili
            // 
            this.heimili.Location = new System.Drawing.Point(52, 99);
            this.heimili.Name = "heimili";
            this.heimili.Size = new System.Drawing.Size(210, 20);
            this.heimili.TabIndex = 38;
            this.heimili.TabStop = false;
            // 
            // debug1
            // 
            this.debug1.Location = new System.Drawing.Point(56, 610);
            this.debug1.Name = "debug1";
            this.debug1.Size = new System.Drawing.Size(291, 20);
            this.debug1.TabIndex = 36;
            this.debug1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(279, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.TabStop = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Viðskiptavinur";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rhaus1
            // 
            this.rhaus1.Location = new System.Drawing.Point(414, 90);
            this.rhaus1.Multiline = true;
            this.rhaus1.Name = "rhaus1";
            this.rhaus1.Size = new System.Drawing.Size(291, 83);
            this.rhaus1.TabIndex = 32;
            this.rhaus1.TabStop = false;
            // 
            // r_prenta
            // 
            this.r_prenta.Location = new System.Drawing.Point(749, 82);
            this.r_prenta.Name = "r_prenta";
            this.r_prenta.Size = new System.Drawing.Size(105, 23);
            this.r_prenta.TabIndex = 46;
            this.r_prenta.TabStop = false;
            this.r_prenta.Text = "Prenta reikning";
            this.r_prenta.UseVisualStyleBackColor = true;
            this.r_prenta.Click += new System.EventHandler(this.r_prenta_Click);
            // 
            // sanvsk
            // 
            this.sanvsk.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sanvsk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sanvsk.Location = new System.Drawing.Point(701, 581);
            this.sanvsk.Name = "sanvsk";
            this.sanvsk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sanvsk.Size = new System.Drawing.Size(71, 13);
            this.sanvsk.TabIndex = 47;
            this.sanvsk.TabStop = false;
            // 
            // smvsk
            // 
            this.smvsk.BackColor = System.Drawing.SystemColors.MenuBar;
            this.smvsk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smvsk.Location = new System.Drawing.Point(702, 607);
            this.smvsk.Name = "smvsk";
            this.smvsk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.smvsk.Size = new System.Drawing.Size(71, 13);
            this.smvsk.TabIndex = 48;
            this.smvsk.TabStop = false;
            // 
            // s1vsk
            // 
            this.s1vsk.BackColor = System.Drawing.SystemColors.MenuBar;
            this.s1vsk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.s1vsk.Location = new System.Drawing.Point(673, 635);
            this.s1vsk.Name = "s1vsk";
            this.s1vsk.Size = new System.Drawing.Size(75, 13);
            this.s1vsk.TabIndex = 49;
            this.s1vsk.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "samtals án vsk.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "samtals með vsk.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "VSK 25.5%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Auka texti á reikning ef við á.";
            // 
            // set_askrift
            // 
            this.set_askrift.Location = new System.Drawing.Point(749, 125);
            this.set_askrift.Name = "set_askrift";
            this.set_askrift.Size = new System.Drawing.Size(105, 23);
            this.set_askrift.TabIndex = 54;
            this.set_askrift.TabStop = false;
            this.set_askrift.Text = "Setja í áskrift";
            this.set_askrift.UseVisualStyleBackColor = true;
            this.set_askrift.Click += new System.EventHandler(this.set_askrift_Click);
            // 
            // stadur
            // 
            this.stadur.Location = new System.Drawing.Point(94, 125);
            this.stadur.Name = "stadur";
            this.stadur.Size = new System.Drawing.Size(214, 20);
            this.stadur.TabIndex = 55;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(202, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(174, 21);
            this.comboBox3.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(725, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 57;
            this.label6.Text = "Sölukerfi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Sölumaður";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 60;
            // 
            // textAfsl
            // 
            this.textAfsl.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textAfsl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAfsl.Location = new System.Drawing.Point(491, 597);
            this.textAfsl.Name = "textAfsl";
            this.textAfsl.Size = new System.Drawing.Size(81, 13);
            this.textAfsl.TabIndex = 61;
            this.textAfsl.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Samtals afsláttur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 635);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "VSK 7%";
            // 
            // s2vsk
            // 
            this.s2vsk.BackColor = System.Drawing.SystemColors.MenuBar;
            this.s2vsk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.s2vsk.Location = new System.Drawing.Point(497, 635);
            this.s2vsk.Name = "s2vsk";
            this.s2vsk.Size = new System.Drawing.Size(75, 13);
            this.s2vsk.TabIndex = 63;
            this.s2vsk.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 26);
            this.button1.TabIndex = 65;
            this.button1.Text = "Lesa inn viðskiptavini";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reikningur);
            this.tabControl1.Controls.Add(this.Vinnulýsing);
            this.tabControl1.Location = new System.Drawing.Point(52, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 387);
            this.tabControl1.TabIndex = 66;
            // 
            // Reikningur
            // 
            this.Reikningur.Controls.Add(this.dataGridView1);
            this.Reikningur.Location = new System.Drawing.Point(4, 22);
            this.Reikningur.Name = "Reikningur";
            this.Reikningur.Padding = new System.Windows.Forms.Padding(3);
            this.Reikningur.Size = new System.Drawing.Size(721, 361);
            this.Reikningur.TabIndex = 0;
            this.Reikningur.Text = "Reikningur";
            this.Reikningur.UseVisualStyleBackColor = true;
            // 
            // Vinnulýsing
            // 
            this.Vinnulýsing.Controls.Add(this.rhaus2);
            this.Vinnulýsing.Location = new System.Drawing.Point(4, 22);
            this.Vinnulýsing.Name = "Vinnulýsing";
            this.Vinnulýsing.Padding = new System.Windows.Forms.Padding(3);
            this.Vinnulýsing.Size = new System.Drawing.Size(721, 361);
            this.Vinnulýsing.TabIndex = 1;
            this.Vinnulýsing.Text = "Vinnulýsing";
            this.Vinnulýsing.UseVisualStyleBackColor = true;
            // 
            // b_kredit
            // 
            this.b_kredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_kredit.Location = new System.Drawing.Point(10, 178);
            this.b_kredit.Name = "b_kredit";
            this.b_kredit.Size = new System.Drawing.Size(88, 78);
            this.b_kredit.TabIndex = 9;
            this.b_kredit.Text = "KREDIT.K";
            this.b_kredit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 78);
            this.button2.TabIndex = 8;
            this.button2.Text = "DEBIT.K";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // b_peningar
            // 
            this.b_peningar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_peningar.Location = new System.Drawing.Point(10, 10);
            this.b_peningar.Name = "b_peningar";
            this.b_peningar.Size = new System.Drawing.Size(88, 78);
            this.b_peningar.TabIndex = 7;
            this.b_peningar.Text = "PENINGAR";
            this.b_peningar.UseVisualStyleBackColor = true;
            this.b_peningar.Click += new System.EventHandler(this.b_peningar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_kredit);
            this.panel1.Controls.Add(this.b_peningar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(855, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 269);
            this.panel1.TabIndex = 67;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(905, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 10);
            this.button3.TabIndex = 68;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reikningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 671);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.s2vsk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textAfsl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.stadur);
            this.Controls.Add(this.set_askrift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s1vsk);
            this.Controls.Add(this.smvsk);
            this.Controls.Add(this.sanvsk);
            this.Controls.Add(this.r_prenta);
            this.Controls.Add(this.rdags);
            this.Controls.Add(this.simi);
            this.Controls.Add(this.kennitala);
            this.Controls.Add(this.pnr);
            this.Controls.Add(this.heimili);
            this.Controls.Add(this.debug1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rhaus1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "reikningar";
            this.Text = "MetSala";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reikningar_lyklar);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Reikningur.ResumeLayout(false);
            this.Vinnulýsing.ResumeLayout(false);
            this.Vinnulýsing.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox rhaus2;
        private System.Windows.Forms.DateTimePicker rdags;
        private System.Windows.Forms.TextBox simi;
        private System.Windows.Forms.TextBox kennitala;
        private System.Windows.Forms.TextBox pnr;
        private System.Windows.Forms.TextBox heimili;
        private System.Windows.Forms.TextBox debug1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox rhaus1;
        private System.Windows.Forms.Button r_prenta;
        private System.Windows.Forms.TextBox sanvsk;
        private System.Windows.Forms.TextBox smvsk;
        private System.Windows.Forms.TextBox s1vsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button set_askrift;
        private System.Windows.Forms.TextBox stadur;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textAfsl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox s2vsk;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verd;
        private System.Windows.Forms.DataGridViewTextBoxColumn magn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afs;
        private System.Windows.Forms.DataGridViewTextBoxColumn samtals;
        private System.Windows.Forms.DataGridViewTextBoxColumn samt_mvsk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Reikningur;
        private System.Windows.Forms.TabPage Vinnulýsing;
        private System.Windows.Forms.Button b_peningar;
        private System.Windows.Forms.Button b_kredit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
       }
}