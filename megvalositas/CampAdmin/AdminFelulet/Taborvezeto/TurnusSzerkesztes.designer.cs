namespace AdminFelulet.TaborVezeto
{
    partial class TurnusSzerkesztes
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
            this.tbSorszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.btMent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKezd = new System.Windows.Forms.DateTimePicker();
            this.dtBef = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSorszam
            // 
            this.tbSorszam.Location = new System.Drawing.Point(109, 12);
            this.tbSorszam.Name = "tbSorszam";
            this.tbSorszam.Size = new System.Drawing.Size(200, 20);
            this.tbSorszam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sorszám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(109, 38);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(200, 20);
            this.tbNev.TabIndex = 2;
            // 
            // btMent
            // 
            this.btMent.Location = new System.Drawing.Point(15, 125);
            this.btMent.Name = "btMent";
            this.btMent.Size = new System.Drawing.Size(75, 23);
            this.btMent.TabIndex = 4;
            this.btMent.Text = "Mentés";
            this.btMent.UseVisualStyleBackColor = true;
            this.btMent.Click += new System.EventHandler(this.btMent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kezdési Dátum";
            // 
            // dtpKezd
            // 
            this.dtpKezd.Location = new System.Drawing.Point(109, 67);
            this.dtpKezd.Name = "dtpKezd";
            this.dtpKezd.Size = new System.Drawing.Size(200, 20);
            this.dtpKezd.TabIndex = 7;
            // 
            // dtBef
            // 
            this.dtBef.Location = new System.Drawing.Point(109, 93);
            this.dtBef.Name = "dtBef";
            this.dtBef.Size = new System.Drawing.Size(200, 20);
            this.dtBef.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Befejezési Dátum";
            // 
            // TurnusSzerkesztes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 170);
            this.Controls.Add(this.dtBef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpKezd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSorszam);
            this.Name = "TurnusSzerkesztes";
            this.Text = "Turnus szerkesztése";
            this.Load += new System.EventHandler(this.TurnusSzerkesztes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSorszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Button btMent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpKezd;
        private System.Windows.Forms.DateTimePicker dtBef;
        private System.Windows.Forms.Label label4;
    }
}