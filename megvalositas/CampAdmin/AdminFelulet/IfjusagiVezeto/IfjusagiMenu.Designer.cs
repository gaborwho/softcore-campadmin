namespace AdminFelulet.IfjusagiVezeto
{
    partial class IfjusagiMenu
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
            this.btTaborozok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTaborozok
            // 
            this.btTaborozok.Location = new System.Drawing.Point(12, 12);
            this.btTaborozok.Name = "btTaborozok";
            this.btTaborozok.Size = new System.Drawing.Size(168, 46);
            this.btTaborozok.TabIndex = 0;
            this.btTaborozok.Text = "Táborozók";
            this.btTaborozok.UseVisualStyleBackColor = true;
            this.btTaborozok.Click += new System.EventHandler(this.btTaborozok_Click);
            // 
            // IfjusagiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 74);
            this.Controls.Add(this.btTaborozok);
            this.Name = "IfjusagiMenu";
            this.Text = "Ifjúsági vezetés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTaborozok;
    }
}