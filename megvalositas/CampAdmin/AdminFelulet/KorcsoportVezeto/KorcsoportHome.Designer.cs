namespace AdminFelulet.KorcsoportVezeto
{
    partial class KorcsoportHome
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
            this.btCsoportok = new System.Windows.Forms.Button();
            this.btKorcsoportok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCsoportok
            // 
            this.btCsoportok.Location = new System.Drawing.Point(12, 64);
            this.btCsoportok.Name = "btCsoportok";
            this.btCsoportok.Size = new System.Drawing.Size(168, 46);
            this.btCsoportok.TabIndex = 2;
            this.btCsoportok.Text = "Csoportok";
            this.btCsoportok.UseVisualStyleBackColor = true;
            this.btCsoportok.Click += new System.EventHandler(this.btCsoportok_Click);
            // 
            // btKorcsoportok
            // 
            this.btKorcsoportok.Location = new System.Drawing.Point(12, 12);
            this.btKorcsoportok.Name = "btKorcsoportok";
            this.btKorcsoportok.Size = new System.Drawing.Size(168, 46);
            this.btKorcsoportok.TabIndex = 3;
            this.btKorcsoportok.Text = "Korcsoportok";
            this.btKorcsoportok.UseVisualStyleBackColor = true;
            this.btKorcsoportok.Click += new System.EventHandler(this.btKorcsoportok_Click);
            // 
            // KorcsoportHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 172);
            this.Controls.Add(this.btKorcsoportok);
            this.Controls.Add(this.btCsoportok);
            this.Name = "KorcsoportHome";
            this.Text = "Korcsoportvezetés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCsoportok;
        private System.Windows.Forms.Button btKorcsoportok;
    }
}