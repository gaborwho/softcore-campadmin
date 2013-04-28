namespace AdminFelulet.TaborVezeto
{
    partial class SzobaLista
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
            this.lbSzobak = new System.Windows.Forms.ListBox();
            this.btSzerkeszt = new System.Windows.Forms.Button();
            this.btUj = new System.Windows.Forms.Button();
            this.btTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSzobak
            // 
            this.lbSzobak.FormattingEnabled = true;
            this.lbSzobak.Location = new System.Drawing.Point(12, 41);
            this.lbSzobak.Name = "lbSzobak";
            this.lbSzobak.Size = new System.Drawing.Size(180, 290);
            this.lbSzobak.TabIndex = 0;
            // 
            // btSzerkeszt
            // 
            this.btSzerkeszt.Location = new System.Drawing.Point(63, 12);
            this.btSzerkeszt.Name = "btSzerkeszt";
            this.btSzerkeszt.Size = new System.Drawing.Size(78, 23);
            this.btSzerkeszt.TabIndex = 1;
            this.btSzerkeszt.Text = "Szerkesztés";
            this.btSzerkeszt.UseVisualStyleBackColor = true;
            this.btSzerkeszt.Click += new System.EventHandler(this.btSzerkeszt_Click);
            // 
            // btUj
            // 
            this.btUj.Location = new System.Drawing.Point(12, 12);
            this.btUj.Name = "btUj";
            this.btUj.Size = new System.Drawing.Size(45, 23);
            this.btUj.TabIndex = 2;
            this.btUj.Text = "Új";
            this.btUj.UseVisualStyleBackColor = true;
            this.btUj.Click += new System.EventHandler(this.btUj_Click);
            // 
            // btTorol
            // 
            this.btTorol.Location = new System.Drawing.Point(147, 12);
            this.btTorol.Name = "btTorol";
            this.btTorol.Size = new System.Drawing.Size(45, 23);
            this.btTorol.TabIndex = 3;
            this.btTorol.Text = "Törlés";
            this.btTorol.UseVisualStyleBackColor = true;
            this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
            // 
            // SzobaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 346);
            this.Controls.Add(this.btTorol);
            this.Controls.Add(this.btUj);
            this.Controls.Add(this.btSzerkeszt);
            this.Controls.Add(this.lbSzobak);
            this.Name = "SzobaLista";
            this.Text = "Szobák";
            this.Load += new System.EventHandler(this.SzobaLista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSzobak;
        private System.Windows.Forms.Button btSzerkeszt;
        private System.Windows.Forms.Button btUj;
        private System.Windows.Forms.Button btTorol;
    }
}