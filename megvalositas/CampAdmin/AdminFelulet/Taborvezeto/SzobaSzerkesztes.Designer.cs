namespace AdminFelulet.TaborVezeto
{
    partial class SzobaSzerkesztes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSzobaSzam = new System.Windows.Forms.TextBox();
            this.tbFerohely = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btMentes = new System.Windows.Forms.Button();
            this.cbHazak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szobaszám";
            // 
            // tbSzobaSzam
            // 
            this.tbSzobaSzam.Location = new System.Drawing.Point(79, 6);
            this.tbSzobaSzam.Name = "tbSzobaSzam";
            this.tbSzobaSzam.Size = new System.Drawing.Size(121, 20);
            this.tbSzobaSzam.TabIndex = 1;
            // 
            // tbFerohely
            // 
            this.tbFerohely.Location = new System.Drawing.Point(79, 32);
            this.tbFerohely.Name = "tbFerohely";
            this.tbFerohely.Size = new System.Drawing.Size(121, 20);
            this.tbFerohely.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Férőhely";
            // 
            // btMentes
            // 
            this.btMentes.Location = new System.Drawing.Point(12, 85);
            this.btMentes.Name = "btMentes";
            this.btMentes.Size = new System.Drawing.Size(188, 23);
            this.btMentes.TabIndex = 8;
            this.btMentes.Text = "Mentés";
            this.btMentes.UseVisualStyleBackColor = true;
            this.btMentes.Click += new System.EventHandler(this.btMentes_Click);
            // 
            // cbHazak
            // 
            this.cbHazak.FormattingEnabled = true;
            this.cbHazak.Location = new System.Drawing.Point(79, 58);
            this.cbHazak.Name = "cbHazak";
            this.cbHazak.Size = new System.Drawing.Size(121, 21);
            this.cbHazak.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ház";
            // 
            // SzobaSzerkesztes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 119);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHazak);
            this.Controls.Add(this.btMentes);
            this.Controls.Add(this.tbFerohely);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSzobaSzam);
            this.Controls.Add(this.label1);
            this.Name = "SzobaSzerkesztes";
            this.Text = "Szoba szerkesztés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSzobaSzam;
        private System.Windows.Forms.TextBox tbFerohely;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btMentes;
        private System.Windows.Forms.ComboBox cbHazak;
        private System.Windows.Forms.Label label3;
    }
}