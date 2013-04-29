namespace AdminFelulet.TaborVezeto
{
    partial class Statisztikak
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
            this.dataGridViewEredmeny = new System.Windows.Forms.DataGridView();
            this.comboStatisztikaTipus = new System.Windows.Forms.ComboBox();
            this.btStatlek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEredmeny)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEredmeny
            // 
            this.dataGridViewEredmeny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEredmeny.Enabled = false;
            this.dataGridViewEredmeny.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewEredmeny.Name = "dataGridViewEredmeny";
            this.dataGridViewEredmeny.Size = new System.Drawing.Size(600, 315);
            this.dataGridViewEredmeny.TabIndex = 0;
            // 
            // comboStatisztikaTipus
            // 
            this.comboStatisztikaTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatisztikaTipus.FormattingEnabled = true;
            this.comboStatisztikaTipus.Location = new System.Drawing.Point(12, 12);
            this.comboStatisztikaTipus.Name = "comboStatisztikaTipus";
            this.comboStatisztikaTipus.Size = new System.Drawing.Size(419, 21);
            this.comboStatisztikaTipus.TabIndex = 1;
            // 
            // btStatlek
            // 
            this.btStatlek.Location = new System.Drawing.Point(437, 12);
            this.btStatlek.Name = "btStatlek";
            this.btStatlek.Size = new System.Drawing.Size(175, 23);
            this.btStatlek.TabIndex = 2;
            this.btStatlek.Text = "Lekérdezés";
            this.btStatlek.UseVisualStyleBackColor = true;
            this.btStatlek.Click += new System.EventHandler(this.btStatlek_Click);
            // 
            // Statisztikak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.btStatlek);
            this.Controls.Add(this.comboStatisztikaTipus);
            this.Controls.Add(this.dataGridViewEredmeny);
            this.Name = "Statisztikak";
            this.Text = "Statisztikák";
            this.Load += new System.EventHandler(this.Statisztikak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEredmeny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEredmeny;
        private System.Windows.Forms.ComboBox comboStatisztikaTipus;
        private System.Windows.Forms.Button btStatlek;
    }
}