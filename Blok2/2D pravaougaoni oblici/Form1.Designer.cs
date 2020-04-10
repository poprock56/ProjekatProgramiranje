namespace _2D_pravaougaoni_oblici
{
    partial class frmRadnaPovrsina
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
            this.pnlRadnaPovrsina = new System.Windows.Forms.Panel();
            this.rbKvadrat = new System.Windows.Forms.RadioButton();
            this.rbPravougaonik = new System.Windows.Forms.RadioButton();
            this.lblUnesiteADimenziju = new System.Windows.Forms.Label();
            this.pnlKontrole = new System.Windows.Forms.Panel();
            this.tbBDimenzija = new System.Windows.Forms.TextBox();
            this.tbADimenzija = new System.Windows.Forms.TextBox();
            this.lblUnesiteBDimenziju = new System.Windows.Forms.Label();
            this.pnlKontrole.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRadnaPovrsina
            // 
            this.pnlRadnaPovrsina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRadnaPovrsina.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRadnaPovrsina.Location = new System.Drawing.Point(0, 0);
            this.pnlRadnaPovrsina.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRadnaPovrsina.Name = "pnlRadnaPovrsina";
            this.pnlRadnaPovrsina.Size = new System.Drawing.Size(400, 600);
            this.pnlRadnaPovrsina.TabIndex = 0;
            // 
            // rbKvadrat
            // 
            this.rbKvadrat.AutoSize = true;
            this.rbKvadrat.Location = new System.Drawing.Point(56, 29);
            this.rbKvadrat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbKvadrat.Name = "rbKvadrat";
            this.rbKvadrat.Size = new System.Drawing.Size(64, 17);
            this.rbKvadrat.TabIndex = 1;
            this.rbKvadrat.Text = "Kvadrati";
            this.rbKvadrat.UseVisualStyleBackColor = true;
            this.rbKvadrat.CheckedChanged += new System.EventHandler(this.rbKvadrat_CheckedChanged);
            // 
            // rbPravougaonik
            // 
            this.rbPravougaonik.AutoSize = true;
            this.rbPravougaonik.Location = new System.Drawing.Point(56, 157);
            this.rbPravougaonik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPravougaonik.Name = "rbPravougaonik";
            this.rbPravougaonik.Size = new System.Drawing.Size(93, 17);
            this.rbPravougaonik.TabIndex = 2;
            this.rbPravougaonik.Text = "Pravougaonici";
            this.rbPravougaonik.UseVisualStyleBackColor = true;
            this.rbPravougaonik.CheckedChanged += new System.EventHandler(this.rbPravougaonik_CheckedChanged);
            // 
            // lblUnesiteADimenziju
            // 
            this.lblUnesiteADimenziju.AutoSize = true;
            this.lblUnesiteADimenziju.Location = new System.Drawing.Point(46, 58);
            this.lblUnesiteADimenziju.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnesiteADimenziju.Name = "lblUnesiteADimenziju";
            this.lblUnesiteADimenziju.Size = new System.Drawing.Size(101, 13);
            this.lblUnesiteADimenziju.TabIndex = 4;
            this.lblUnesiteADimenziju.Text = "Unesite a dimenziju:";
            // 
            // pnlKontrole
            // 
            this.pnlKontrole.Controls.Add(this.tbBDimenzija);
            this.pnlKontrole.Controls.Add(this.tbADimenzija);
            this.pnlKontrole.Controls.Add(this.lblUnesiteBDimenziju);
            this.pnlKontrole.Controls.Add(this.lblUnesiteADimenziju);
            this.pnlKontrole.Controls.Add(this.rbKvadrat);
            this.pnlKontrole.Controls.Add(this.rbPravougaonik);
            this.pnlKontrole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKontrole.Location = new System.Drawing.Point(400, 0);
            this.pnlKontrole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlKontrole.Name = "pnlKontrole";
            this.pnlKontrole.Size = new System.Drawing.Size(184, 600);
            this.pnlKontrole.TabIndex = 1;
            // 
            // tbBDimenzija
            // 
            this.tbBDimenzija.Location = new System.Drawing.Point(56, 125);
            this.tbBDimenzija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBDimenzija.Name = "tbBDimenzija";
            this.tbBDimenzija.Size = new System.Drawing.Size(76, 20);
            this.tbBDimenzija.TabIndex = 7;
            // 
            // tbADimenzija
            // 
            this.tbADimenzija.Location = new System.Drawing.Point(56, 74);
            this.tbADimenzija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbADimenzija.Name = "tbADimenzija";
            this.tbADimenzija.Size = new System.Drawing.Size(76, 20);
            this.tbADimenzija.TabIndex = 6;
            // 
            // lblUnesiteBDimenziju
            // 
            this.lblUnesiteBDimenziju.AutoSize = true;
            this.lblUnesiteBDimenziju.Location = new System.Drawing.Point(46, 108);
            this.lblUnesiteBDimenziju.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnesiteBDimenziju.Name = "lblUnesiteBDimenziju";
            this.lblUnesiteBDimenziju.Size = new System.Drawing.Size(101, 13);
            this.lblUnesiteBDimenziju.TabIndex = 5;
            this.lblUnesiteBDimenziju.Text = "Unesite b dimenziju:";
            // 
            // frmRadnaPovrsina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 600);
            this.Controls.Add(this.pnlKontrole);
            this.Controls.Add(this.pnlRadnaPovrsina);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRadnaPovrsina";
            this.Text = "Radna Povrsina";
            this.pnlKontrole.ResumeLayout(false);
            this.pnlKontrole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRadnaPovrsina;
        private System.Windows.Forms.RadioButton rbKvadrat;
        private System.Windows.Forms.RadioButton rbPravougaonik;
        private System.Windows.Forms.Label lblUnesiteADimenziju;
        private System.Windows.Forms.Panel pnlKontrole;
        private System.Windows.Forms.Label lblUnesiteBDimenziju;
        private System.Windows.Forms.TextBox tbBDimenzija;
        private System.Windows.Forms.TextBox tbADimenzija;
    }
}

