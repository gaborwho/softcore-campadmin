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
            this.lbNev = new System.Windows.Forms.Label();
            this.listBoxKorcsoportlista = new System.Windows.Forms.ListBox();
            this.buttonKorcsSzerk = new System.Windows.Forms.Button();
            this.buttonUjKorcs = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNev
            // 
            this.lbNev.AutoSize = true;
            this.lbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNev.Location = new System.Drawing.Point(12, 9);
            this.lbNev.Name = "lbNev";
            this.lbNev.Size = new System.Drawing.Size(0, 25);
            this.lbNev.TabIndex = 0;
            // 
            // listBoxKorcsoportlista
            // 
            this.listBoxKorcsoportlista.FormattingEnabled = true;
            this.listBoxKorcsoportlista.Location = new System.Drawing.Point(17, 50);
            this.listBoxKorcsoportlista.Name = "listBoxKorcsoportlista";
            this.listBoxKorcsoportlista.Size = new System.Drawing.Size(290, 264);
            this.listBoxKorcsoportlista.TabIndex = 2;
            this.listBoxKorcsoportlista.SelectedIndexChanged += new System.EventHandler(this.listBoxKorcsoportlista_SelectedIndexChanged);
            // 
            // buttonKorcsSzerk
            // 
            this.buttonKorcsSzerk.Location = new System.Drawing.Point(17, 320);
            this.buttonKorcsSzerk.Name = "buttonKorcsSzerk";
            this.buttonKorcsSzerk.Size = new System.Drawing.Size(97, 43);
            this.buttonKorcsSzerk.TabIndex = 4;
            this.buttonKorcsSzerk.Text = "Korcsoport szerkesztése";
            this.buttonKorcsSzerk.UseVisualStyleBackColor = true;
            this.buttonKorcsSzerk.Click += new System.EventHandler(this.buttonKorcsSzerk_Click);
            // 
            // buttonUjKorcs
            // 
            this.buttonUjKorcs.Location = new System.Drawing.Point(120, 320);
            this.buttonUjKorcs.Name = "buttonUjKorcs";
            this.buttonUjKorcs.Size = new System.Drawing.Size(90, 43);
            this.buttonUjKorcs.TabIndex = 6;
            this.buttonUjKorcs.Text = "Új korcsoport";
            this.buttonUjKorcs.UseVisualStyleBackColor = true;
            this.buttonUjKorcs.Click += new System.EventHandler(this.buttonUjKorcs_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(216, 320);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(90, 43);
            this.buttonTorles.TabIndex = 7;
            this.buttonTorles.Text = "Korcsoport törlése";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // KorcsoportLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 375);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonUjKorcs);
            this.Controls.Add(this.buttonKorcsSzerk);
            this.Controls.Add(this.listBoxKorcsoportlista);
            this.Controls.Add(this.lbNev);
            this.Name = "KorcsoportLista";
            this.Text = "Korsoportok Listája";
            this.Load += new System.EventHandler(this.KorcsoportLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNev;
        private System.Windows.Forms.ListBox listBoxKorcsoportlista;
        private System.Windows.Forms.Button buttonKorcsSzerk;
        private System.Windows.Forms.Button buttonUjKorcs;
        private System.Windows.Forms.Button buttonTorles;
    }
}

