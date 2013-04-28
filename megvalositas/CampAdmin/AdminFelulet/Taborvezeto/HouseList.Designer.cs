namespace AdminFelulet.TaborVezeto
{
    partial class HazSzerkesztoLista
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
            this.tbNeve = new System.Windows.Forms.TextBox();
            this.tbMapY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMapX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btUj = new System.Windows.Forms.Button();
            this.lbHazak = new System.Windows.Forms.ListBox();
            this.btTorol = new System.Windows.Forms.Button();
            this.btSzerkeszt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ház neve";
            // 
            // tbNeve
            // 
            this.tbNeve.Location = new System.Drawing.Point(79, 12);
            this.tbNeve.Name = "tbNeve";
            this.tbNeve.Size = new System.Drawing.Size(100, 20);
            this.tbNeve.TabIndex = 1;
            // 
            // tbMapY
            // 
            this.tbMapY.Location = new System.Drawing.Point(79, 64);
            this.tbMapY.Name = "tbMapY";
            this.tbMapY.Size = new System.Drawing.Size(100, 20);
            this.tbMapY.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "MapY";
            // 
            // tbMapX
            // 
            this.tbMapX.Location = new System.Drawing.Point(79, 38);
            this.tbMapX.Name = "tbMapX";
            this.tbMapX.Size = new System.Drawing.Size(100, 20);
            this.tbMapX.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MapX";
            // 
            // btUj
            // 
            this.btUj.Location = new System.Drawing.Point(185, 10);
            this.btUj.Name = "btUj";
            this.btUj.Size = new System.Drawing.Size(75, 23);
            this.btUj.TabIndex = 12;
            this.btUj.Text = "Új Felvétele";
            this.btUj.UseVisualStyleBackColor = true;
            this.btUj.Click += new System.EventHandler(this.btUj_Click);
            // 
            // lbHazak
            // 
            this.lbHazak.FormattingEnabled = true;
            this.lbHazak.Location = new System.Drawing.Point(12, 96);
            this.lbHazak.Name = "lbHazak";
            this.lbHazak.Size = new System.Drawing.Size(248, 238);
            this.lbHazak.TabIndex = 13;
            this.lbHazak.SelectedIndexChanged += new System.EventHandler(this.lbHazak_SelectedIndexChanged);
            // 
            // btTorol
            // 
            this.btTorol.Location = new System.Drawing.Point(185, 36);
            this.btTorol.Name = "btTorol";
            this.btTorol.Size = new System.Drawing.Size(75, 23);
            this.btTorol.TabIndex = 14;
            this.btTorol.Text = "Törlés";
            this.btTorol.UseVisualStyleBackColor = true;
            this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
            // 
            // btSzerkeszt
            // 
            this.btSzerkeszt.Location = new System.Drawing.Point(185, 62);
            this.btSzerkeszt.Name = "btSzerkeszt";
            this.btSzerkeszt.Size = new System.Drawing.Size(75, 23);
            this.btSzerkeszt.TabIndex = 15;
            this.btSzerkeszt.Text = "Szerkeszt";
            this.btSzerkeszt.UseVisualStyleBackColor = true;
            this.btSzerkeszt.Click += new System.EventHandler(this.btSzerkeszt_Click);
            // 
            // HazSzerkesztoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 346);
            this.Controls.Add(this.btSzerkeszt);
            this.Controls.Add(this.btTorol);
            this.Controls.Add(this.lbHazak);
            this.Controls.Add(this.btUj);
            this.Controls.Add(this.tbMapY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMapX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNeve);
            this.Controls.Add(this.label1);
            this.Name = "HazSzerkesztoLista";
            this.Text = "Házak";
            this.Load += new System.EventHandler(this.HazSzerkesztoLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNeve;
        private System.Windows.Forms.TextBox tbMapY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMapX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btUj;
        private System.Windows.Forms.ListBox lbHazak;
        private System.Windows.Forms.Button btTorol;
        private System.Windows.Forms.Button btSzerkeszt;
    }
}