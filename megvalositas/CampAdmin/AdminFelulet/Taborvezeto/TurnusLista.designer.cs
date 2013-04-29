namespace AdminFelulet.TaborVezeto
{
    partial class TurnusLista
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
            this.lbTurnusok = new System.Windows.Forms.ListBox();
            this.btUjTurnus = new System.Windows.Forms.Button();
            this.btTurnusModosit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTurnusok
            // 
            this.lbTurnusok.FormattingEnabled = true;
            this.lbTurnusok.Location = new System.Drawing.Point(12, 14);
            this.lbTurnusok.Name = "lbTurnusok";
            this.lbTurnusok.Size = new System.Drawing.Size(260, 238);
            this.lbTurnusok.TabIndex = 0;
            this.lbTurnusok.SelectedIndexChanged += new System.EventHandler(this.lbTurnusok_SelectedIndexChanged);
            // 
            // btUjTurnus
            // 
            this.btUjTurnus.Location = new System.Drawing.Point(12, 258);
            this.btUjTurnus.Name = "btUjTurnus";
            this.btUjTurnus.Size = new System.Drawing.Size(110, 23);
            this.btUjTurnus.TabIndex = 1;
            this.btUjTurnus.Text = "Új turnus";
            this.btUjTurnus.UseVisualStyleBackColor = true;
            this.btUjTurnus.Click += new System.EventHandler(this.btUjTurnus_Click);
            // 
            // btTurnusModosit
            // 
            this.btTurnusModosit.Location = new System.Drawing.Point(162, 258);
            this.btTurnusModosit.Name = "btTurnusModosit";
            this.btTurnusModosit.Size = new System.Drawing.Size(110, 23);
            this.btTurnusModosit.TabIndex = 2;
            this.btTurnusModosit.Text = "Turnus módosítása";
            this.btTurnusModosit.UseVisualStyleBackColor = true;
            this.btTurnusModosit.Click += new System.EventHandler(this.btTurnusModosit_Click);
            // 
            // TurnusLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.btTurnusModosit);
            this.Controls.Add(this.btUjTurnus);
            this.Controls.Add(this.lbTurnusok);
            this.Name = "TurnusLista";
            this.Text = "Turnusok Listája";
            this.Load += new System.EventHandler(this.TurnusLista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTurnusok;
        private System.Windows.Forms.Button btUjTurnus;
        private System.Windows.Forms.Button btTurnusModosit;
    }
}