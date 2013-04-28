namespace AdminFelulet.KorcsoportVezeto
{
    partial class KorcsoportLista
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxKorcsoportlista = new System.Windows.Forms.ListBox();
            this.buttonKorcsSzerk = new System.Windows.Forms.Button();
            this.buttonKorcsFeltolt = new System.Windows.Forms.Button();
            this.buttonUjKorcs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korcsoport neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "státusz / adatok";
            // 
            // listBoxKorcsoportlista
            // 
            this.listBoxKorcsoportlista.FormattingEnabled = true;
            this.listBoxKorcsoportlista.Items.AddRange(new object[] {
            "2008/1 - HU - Kicsik",
            "2008/2 - HU - Közepes",
            "2009/3 - SK - Nagyok",
            "2012/1- US - Nagyok"});
            this.listBoxKorcsoportlista.Location = new System.Drawing.Point(17, 50);
            this.listBoxKorcsoportlista.Name = "listBoxKorcsoportlista";
            this.listBoxKorcsoportlista.Size = new System.Drawing.Size(316, 264);
            this.listBoxKorcsoportlista.TabIndex = 2;
            // 
            // buttonKorcsSzerk
            // 
            this.buttonKorcsSzerk.Location = new System.Drawing.Point(17, 320);
            this.buttonKorcsSzerk.Name = "buttonKorcsSzerk";
            this.buttonKorcsSzerk.Size = new System.Drawing.Size(110, 43);
            this.buttonKorcsSzerk.TabIndex = 4;
            this.buttonKorcsSzerk.Text = "Korcsoport szerkesztése";
            this.buttonKorcsSzerk.UseVisualStyleBackColor = true;
            this.buttonKorcsSzerk.Click += new System.EventHandler(this.buttonKorcsSzerk_Click);
            // 
            // buttonKorcsFeltolt
            // 
            this.buttonKorcsFeltolt.Location = new System.Drawing.Point(133, 320);
            this.buttonKorcsFeltolt.Name = "buttonKorcsFeltolt";
            this.buttonKorcsFeltolt.Size = new System.Drawing.Size(110, 43);
            this.buttonKorcsFeltolt.TabIndex = 5;
            this.buttonKorcsFeltolt.Text = "Korcsoport feltöltése";
            this.buttonKorcsFeltolt.UseVisualStyleBackColor = true;
            this.buttonKorcsFeltolt.Click += new System.EventHandler(this.buttonKorcsFeltolt_Click);
            // 
            // buttonUjKorcs
            // 
            this.buttonUjKorcs.Enabled = false;
            this.buttonUjKorcs.Location = new System.Drawing.Point(249, 320);
            this.buttonUjKorcs.Name = "buttonUjKorcs";
            this.buttonUjKorcs.Size = new System.Drawing.Size(84, 43);
            this.buttonUjKorcs.TabIndex = 6;
            this.buttonUjKorcs.Text = "Új korcsoport";
            this.buttonUjKorcs.UseVisualStyleBackColor = true;
            this.buttonUjKorcs.Click += new System.EventHandler(this.buttonUjKorcs_Click);
            // 
            // KorcsoportLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 375);
            this.Controls.Add(this.buttonUjKorcs);
            this.Controls.Add(this.buttonKorcsFeltolt);
            this.Controls.Add(this.buttonKorcsSzerk);
            this.Controls.Add(this.listBoxKorcsoportlista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KorcsoportLista";
            this.Text = "Korsoportok Listája";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxKorcsoportlista;
        private System.Windows.Forms.Button buttonKorcsSzerk;
        private System.Windows.Forms.Button buttonKorcsFeltolt;
        private System.Windows.Forms.Button buttonUjKorcs;
    }
}

