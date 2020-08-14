namespace Adam_Asmaca
{
    partial class FormYeniKelimeEkle
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
            this.btnYeniKelimeEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYeniKelimeEkle
            // 
            this.btnYeniKelimeEkle.Location = new System.Drawing.Point(24, 75);
            this.btnYeniKelimeEkle.Name = "btnYeniKelimeEkle";
            this.btnYeniKelimeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniKelimeEkle.TabIndex = 0;
            this.btnYeniKelimeEkle.Text = "Ekle";
            this.btnYeniKelimeEkle.UseVisualStyleBackColor = true;
            this.btnYeniKelimeEkle.Click += new System.EventHandler(this.btnYeniKelimeEkle_Click);
            this.btnYeniKelimeEkle.Enter += new System.EventHandler(this.btnYeniKelimeEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(24, 38);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(174, 20);
            this.txtEkle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelime Girin :";
            // 
            // FormYeniKelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnYeniKelimeEkle);
            this.Name = "FormYeniKelimeEkle";
            this.Text = "Kelime Ekle-Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnYeniKelimeEkle;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtEkle;
        public System.Windows.Forms.Label label1;

    }
}