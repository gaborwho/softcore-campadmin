namespace AdminFelulet.IfjusagiVezeto
{
    partial class TaborozoCsoporthozSzobahozRendeles
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelNev = new System.Windows.Forms.Label();
            this.comboCsoportok = new System.Windows.Forms.ComboBox();
            this.comboSzobak = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btMent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Név";
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(280, 9);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(0, 13);
            this.labelNev.TabIndex = 20;
            this.labelNev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboCsoportok
            // 
            this.comboCsoportok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCsoportok.FormattingEnabled = true;
            this.comboCsoportok.Location = new System.Drawing.Point(121, 32);
            this.comboCsoportok.Name = "comboCsoportok";
            this.comboCsoportok.Size = new System.Drawing.Size(203, 21);
            this.comboCsoportok.TabIndex = 23;
            // 
            // comboSzobak
            // 
            this.comboSzobak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSzobak.FormattingEnabled = true;
            this.comboSzobak.Location = new System.Drawing.Point(121, 59);
            this.comboSzobak.Name = "comboSzobak";
            this.comboSzobak.Size = new System.Drawing.Size(203, 21);
            this.comboSzobak.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Csoport";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Szoba";
            // 
            // btMent
            // 
            this.btMent.Location = new System.Drawing.Point(205, 88);
            this.btMent.Name = "btMent";
            this.btMent.Size = new System.Drawing.Size(119, 23);
            this.btMent.TabIndex = 27;
            this.btMent.Text = "Mentés";
            this.btMent.UseVisualStyleBackColor = true;
            this.btMent.Click += new System.EventHandler(this.btMent_Click);
            // 
            // TaborozoCsoporthozSzobahozRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 124);
            this.Controls.Add(this.btMent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSzobak);
            this.Controls.Add(this.comboCsoportok);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.label3);
            this.Name = "TaborozoCsoporthozSzobahozRendeles";
            this.Text = "Csoporthoz, illetve Szobához rendelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.ComboBox comboCsoportok;
        private System.Windows.Forms.ComboBox comboSzobak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btMent;
    }
}