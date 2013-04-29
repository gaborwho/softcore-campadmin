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
            this.btModosit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTurnusok
            // 
            this.lbTurnusok.FormattingEnabled = true;
            this.lbTurnusok.Location = new System.Drawing.Point(12, 14);
            this.lbTurnusok.Name = "lbTurnusok";
            this.lbTurnusok.Size = new System.Drawing.Size(410, 238);
            this.lbTurnusok.TabIndex = 0;
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
            // btModosit
            // 
            this.btModosit.Location = new System.Drawing.Point(312, 258);
            this.btModosit.Name = "btModosit";
            this.btModosit.Size = new System.Drawing.Size(110, 23);
            this.btModosit.TabIndex = 2;
            this.btModosit.Text = "Turnus módosítása";
            this.btModosit.UseVisualStyleBackColor = true;
            this.btModosit.Click += new System.EventHandler(this.btModosit_Click);
            // 
            // TurnusLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.btModosit);
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
        private System.Windows.Forms.Button btModosit;
    }
}