namespace AdminFelulet.TaborVezeto
{
    partial class UnitDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlsoKor = new System.Windows.Forms.TextBox();
            this.textBoxFelsoKor = new System.Windows.Forms.TextBox();
            this.textBoxOrszag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ország";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felső korhatár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(116, 6);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(159, 20);
            this.textBoxNev.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alsó korhatár";
            // 
            // textBoxAlsoKor
            // 
            this.textBoxAlsoKor.Location = new System.Drawing.Point(116, 59);
            this.textBoxAlsoKor.Name = "textBoxAlsoKor";
            this.textBoxAlsoKor.Size = new System.Drawing.Size(159, 20);
            this.textBoxAlsoKor.TabIndex = 14;
            // 
            // textBoxFelsoKor
            // 
            this.textBoxFelsoKor.Location = new System.Drawing.Point(116, 85);
            this.textBoxFelsoKor.Name = "textBoxFelsoKor";
            this.textBoxFelsoKor.Size = new System.Drawing.Size(159, 20);
            this.textBoxFelsoKor.TabIndex = 15;
            // 
            // textBoxOrszag
            // 
            this.textBoxOrszag.Location = new System.Drawing.Point(116, 32);
            this.textBoxOrszag.Name = "textBoxOrszag";
            this.textBoxOrszag.Size = new System.Drawing.Size(159, 20);
            this.textBoxOrszag.TabIndex = 16;
            // 
            // UnitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 156);
            this.Controls.Add(this.textBoxOrszag);
            this.Controls.Add(this.textBoxFelsoKor);
            this.Controls.Add(this.textBoxAlsoKor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnitDetails";
            this.Text = "Korcsoport - Szerkesztés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAlsoKor;
        private System.Windows.Forms.TextBox textBoxFelsoKor;
        private System.Windows.Forms.TextBox textBoxOrszag;
    }
}