namespace AdminFelulet.TaborVezeto
{
    partial class TaborVezetoMenu
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
            this.btHázak = new System.Windows.Forms.Button();
            this.btSzobák = new System.Windows.Forms.Button();
            this.btTurnusok = new System.Windows.Forms.Button();
            this.btStatisztikák = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btHázak
            // 
            this.btHázak.Location = new System.Drawing.Point(21, 64);
            this.btHázak.Name = "btHázak";
            this.btHázak.Size = new System.Drawing.Size(168, 46);
            this.btHázak.TabIndex = 4;
            this.btHázak.Text = "Házak";
            this.btHázak.UseVisualStyleBackColor = true;
            this.btHázak.Click += new System.EventHandler(this.btHázak_Click);
            // 
            // btSzobák
            // 
            this.btSzobák.Location = new System.Drawing.Point(21, 116);
            this.btSzobák.Name = "btSzobák";
            this.btSzobák.Size = new System.Drawing.Size(168, 46);
            this.btSzobák.TabIndex = 5;
            this.btSzobák.Text = "Szobák";
            this.btSzobák.UseVisualStyleBackColor = true;
            this.btSzobák.Click += new System.EventHandler(this.btSzobák_Click);
            // 
            // btTurnusok
            // 
            this.btTurnusok.Location = new System.Drawing.Point(21, 12);
            this.btTurnusok.Name = "btTurnusok";
            this.btTurnusok.Size = new System.Drawing.Size(168, 46);
            this.btTurnusok.TabIndex = 6;
            this.btTurnusok.Text = "Turnusok";
            this.btTurnusok.UseVisualStyleBackColor = true;
            this.btTurnusok.Click += new System.EventHandler(this.btTurnusok_Click);
            // 
            // btStatisztikák
            // 
            this.btStatisztikák.Location = new System.Drawing.Point(21, 168);
            this.btStatisztikák.Name = "btStatisztikák";
            this.btStatisztikák.Size = new System.Drawing.Size(168, 46);
            this.btStatisztikák.TabIndex = 7;
            this.btStatisztikák.Text = "Statisztikák";
            this.btStatisztikák.UseVisualStyleBackColor = true;
            this.btStatisztikák.Click += new System.EventHandler(this.btStatisztikák_Click);
            // 
            // TaborVezetoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 227);
            this.Controls.Add(this.btStatisztikák);
            this.Controls.Add(this.btTurnusok);
            this.Controls.Add(this.btSzobák);
            this.Controls.Add(this.btHázak);
            this.Name = "TaborVezetoMenu";
            this.Text = "Táborvezetés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHázak;
        private System.Windows.Forms.Button btSzobák;
        private System.Windows.Forms.Button btTurnusok;
        private System.Windows.Forms.Button btStatisztikák;
    }
}