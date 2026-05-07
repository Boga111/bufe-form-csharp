namespace abbufe
{
    partial class Form1
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
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.sorszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txkereses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plujadat = new System.Windows.Forms.Panel();
            this.lbosszeg = new System.Windows.Forms.Label();
            this.btelvet = new System.Windows.Forms.Button();
            this.btmentes = new System.Windows.Forms.Button();
            this.txtermek = new System.Windows.Forms.TextBox();
            this.txbrutto = new System.Windows.Forms.TextBox();
            this.txmenny = new System.Windows.Forms.TextBox();
            this.dtdatum = new System.Windows.Forms.DateTimePicker();
            this.txvevo = new System.Windows.Forms.TextBox();
            this.txsorszam = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmodosit = new System.Windows.Forms.RadioButton();
            this.rbuj = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.plujadat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sorszam,
            this.vevo,
            this.datum,
            this.termek,
            this.menny,
            this.brutto,
            this.fizar});
            this.dgadatok.Location = new System.Drawing.Point(14, 67);
            this.dgadatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(746, 506);
            this.dgadatok.TabIndex = 0;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
            // 
            // sorszam
            // 
            this.sorszam.HeaderText = "Sorszám";
            this.sorszam.Name = "sorszam";
            this.sorszam.ReadOnly = true;
            // 
            // vevo
            // 
            this.vevo.HeaderText = "Vevő neve";
            this.vevo.Name = "vevo";
            this.vevo.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.HeaderText = "Dátum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // termek
            // 
            this.termek.HeaderText = "Termék";
            this.termek.Name = "termek";
            this.termek.ReadOnly = true;
            // 
            // menny
            // 
            this.menny.HeaderText = "Mennyiség";
            this.menny.Name = "menny";
            this.menny.ReadOnly = true;
            // 
            // brutto
            // 
            this.brutto.HeaderText = "Bruttó ár";
            this.brutto.Name = "brutto";
            this.brutto.ReadOnly = true;
            // 
            // fizar
            // 
            this.fizar.HeaderText = "Fizetendő";
            this.fizar.Name = "fizar";
            this.fizar.ReadOnly = true;
            // 
            // txkereses
            // 
            this.txkereses.Location = new System.Drawing.Point(114, 28);
            this.txkereses.Name = "txkereses";
            this.txkereses.Size = new System.Drawing.Size(175, 20);
            this.txkereses.TabIndex = 1;
            this.txkereses.TextChanged += new System.EventHandler(this.txkereses_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keresés:";
            // 
            // plujadat
            // 
            this.plujadat.Controls.Add(this.lbosszeg);
            this.plujadat.Controls.Add(this.btelvet);
            this.plujadat.Controls.Add(this.btmentes);
            this.plujadat.Controls.Add(this.txtermek);
            this.plujadat.Controls.Add(this.txbrutto);
            this.plujadat.Controls.Add(this.txmenny);
            this.plujadat.Controls.Add(this.dtdatum);
            this.plujadat.Controls.Add(this.txvevo);
            this.plujadat.Controls.Add(this.txsorszam);
            this.plujadat.Controls.Add(this.lb);
            this.plujadat.Controls.Add(this.label7);
            this.plujadat.Controls.Add(this.label6);
            this.plujadat.Controls.Add(this.label5);
            this.plujadat.Controls.Add(this.label4);
            this.plujadat.Controls.Add(this.label3);
            this.plujadat.Controls.Add(this.label2);
            this.plujadat.Location = new System.Drawing.Point(796, 192);
            this.plujadat.Name = "plujadat";
            this.plujadat.Size = new System.Drawing.Size(263, 381);
            this.plujadat.TabIndex = 3;
            // 
            // lbosszeg
            // 
            this.lbosszeg.AutoSize = true;
            this.lbosszeg.ForeColor = System.Drawing.Color.Red;
            this.lbosszeg.Location = new System.Drawing.Point(141, 252);
            this.lbosszeg.Name = "lbosszeg";
            this.lbosszeg.Size = new System.Drawing.Size(41, 13);
            this.lbosszeg.TabIndex = 15;
            this.lbosszeg.Text = "label8";
            // 
            // btelvet
            // 
            this.btelvet.Location = new System.Drawing.Point(148, 282);
            this.btelvet.Name = "btelvet";
            this.btelvet.Size = new System.Drawing.Size(105, 38);
            this.btelvet.TabIndex = 11;
            this.btelvet.Text = "Elvet";
            this.btelvet.UseVisualStyleBackColor = true;
            this.btelvet.Click += new System.EventHandler(this.btelvet_Click);
            // 
            // btmentes
            // 
            this.btmentes.Image = global::abbufe.Properties.Resources.oke;
            this.btmentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmentes.Location = new System.Drawing.Point(13, 282);
            this.btmentes.Name = "btmentes";
            this.btmentes.Size = new System.Drawing.Size(118, 38);
            this.btmentes.TabIndex = 10;
            this.btmentes.Text = "Mentés";
            this.btmentes.UseVisualStyleBackColor = true;
            this.btmentes.Click += new System.EventHandler(this.btmentes_Click);
            // 
            // txtermek
            // 
            this.txtermek.Location = new System.Drawing.Point(96, 131);
            this.txtermek.MaxLength = 20;
            this.txtermek.Name = "txtermek";
            this.txtermek.Size = new System.Drawing.Size(147, 20);
            this.txtermek.TabIndex = 7;
            // 
            // txbrutto
            // 
            this.txbrutto.Location = new System.Drawing.Point(129, 211);
            this.txbrutto.MaxLength = 10;
            this.txbrutto.Name = "txbrutto";
            this.txbrutto.Size = new System.Drawing.Size(87, 20);
            this.txbrutto.TabIndex = 9;
            this.txbrutto.TextChanged += new System.EventHandler(this.txbrutto_TextChanged);
            // 
            // txmenny
            // 
            this.txmenny.Location = new System.Drawing.Point(96, 172);
            this.txmenny.MaxLength = 10;
            this.txmenny.Name = "txmenny";
            this.txmenny.Size = new System.Drawing.Size(66, 20);
            this.txmenny.TabIndex = 8;
            this.txmenny.TextChanged += new System.EventHandler(this.txmenny_TextChanged);
            // 
            // dtdatum
            // 
            this.dtdatum.CustomFormat = "yyyy-MM-dd";
            this.dtdatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdatum.Location = new System.Drawing.Point(96, 96);
            this.dtdatum.Name = "dtdatum";
            this.dtdatum.Size = new System.Drawing.Size(112, 20);
            this.dtdatum.TabIndex = 6;
            // 
            // txvevo
            // 
            this.txvevo.Location = new System.Drawing.Point(96, 51);
            this.txvevo.MaxLength = 20;
            this.txvevo.Name = "txvevo";
            this.txvevo.Size = new System.Drawing.Size(100, 20);
            this.txvevo.TabIndex = 5;
            // 
            // txsorszam
            // 
            this.txsorszam.Location = new System.Drawing.Point(96, 13);
            this.txsorszam.MaxLength = 4;
            this.txsorszam.Name = "txsorszam";
            this.txsorszam.Size = new System.Drawing.Size(66, 20);
            this.txsorszam.TabIndex = 4;
            this.txsorszam.TextChanged += new System.EventHandler(this.txsorszam_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(16, 252);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(109, 13);
            this.lb.TabIndex = 6;
            this.lb.Text = "Fizetendő összeg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bruttó egység ár:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mennyiség:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Termék:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vevő neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sorszám:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbmodosit);
            this.groupBox1.Controls.Add(this.rbuj);
            this.groupBox1.Location = new System.Drawing.Point(796, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Művelet";
            // 
            // rbmodosit
            // 
            this.rbmodosit.AutoSize = true;
            this.rbmodosit.Location = new System.Drawing.Point(19, 61);
            this.rbmodosit.Name = "rbmodosit";
            this.rbmodosit.Size = new System.Drawing.Size(84, 17);
            this.rbmodosit.TabIndex = 3;
            this.rbmodosit.TabStop = true;
            this.rbmodosit.Text = "Módosítás";
            this.rbmodosit.UseVisualStyleBackColor = true;
            this.rbmodosit.CheckedChanged += new System.EventHandler(this.rbmodosit_CheckedChanged);
            // 
            // rbuj
            // 
            this.rbuj.AutoSize = true;
            this.rbuj.Location = new System.Drawing.Point(19, 29);
            this.rbuj.Name = "rbuj";
            this.rbuj.Size = new System.Drawing.Size(86, 17);
            this.rbuj.TabIndex = 2;
            this.rbuj.TabStop = true;
            this.rbuj.Text = "Új felvitele";
            this.rbuj.UseVisualStyleBackColor = true;
            this.rbuj.CheckedChanged += new System.EventHandler(this.rbuj_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plujadat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txkereses);
            this.Controls.Add(this.dgadatok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katica büfé";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.plujadat.ResumeLayout(false);
            this.plujadat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn vevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek;
        private System.Windows.Forms.DataGridViewTextBoxColumn menny;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizar;
        private System.Windows.Forms.TextBox txkereses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plujadat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbmodosit;
        private System.Windows.Forms.RadioButton rbuj;
        private System.Windows.Forms.Button btelvet;
        private System.Windows.Forms.Button btmentes;
        private System.Windows.Forms.TextBox txtermek;
        private System.Windows.Forms.TextBox txbrutto;
        private System.Windows.Forms.TextBox txmenny;
        private System.Windows.Forms.DateTimePicker dtdatum;
        private System.Windows.Forms.TextBox txvevo;
        private System.Windows.Forms.TextBox txsorszam;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbosszeg;
    }
}

