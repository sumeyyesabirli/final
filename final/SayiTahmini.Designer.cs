
namespace final
{
    partial class SayiTahmini
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
            this.txtSayiGirisi = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblKalanTamin = new System.Windows.Forms.Label();
            this.btnOyunaBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayiGirisi
            // 
            this.txtSayiGirisi.Location = new System.Drawing.Point(71, 27);
            this.txtSayiGirisi.Name = "txtSayiGirisi";
            this.txtSayiGirisi.Size = new System.Drawing.Size(220, 22);
            this.txtSayiGirisi.TabIndex = 0;
            this.txtSayiGirisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayiGirisi_KeyPress);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(71, 69);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(220, 40);
            this.btnTahmin.TabIndex = 1;
            this.btnTahmin.Text = "Tahim Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblKalanTamin
            // 
            this.lblKalanTamin.AutoSize = true;
            this.lblKalanTamin.Location = new System.Drawing.Point(68, 136);
            this.lblKalanTamin.Name = "lblKalanTamin";
            this.lblKalanTamin.Size = new System.Drawing.Size(107, 17);
            this.lblKalanTamin.TabIndex = 2;
            this.lblKalanTamin.Text = "Kalan Tahmin : ";
            // 
            // btnOyunaBasla
            // 
            this.btnOyunaBasla.Location = new System.Drawing.Point(71, 69);
            this.btnOyunaBasla.Name = "btnOyunaBasla";
            this.btnOyunaBasla.Size = new System.Drawing.Size(220, 40);
            this.btnOyunaBasla.TabIndex = 3;
            this.btnOyunaBasla.Text = "Oyuna Başla";
            this.btnOyunaBasla.UseVisualStyleBackColor = true;
            this.btnOyunaBasla.Click += new System.EventHandler(this.btnOyunaBasla_Click);
            // 
            // SayiTahmini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 252);
            this.Controls.Add(this.btnOyunaBasla);
            this.Controls.Add(this.lblKalanTamin);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtSayiGirisi);
            this.Name = "SayiTahmini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SayiTahmini";
            this.Load += new System.EventHandler(this.SayiTahmini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayiGirisi;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblKalanTamin;
        private System.Windows.Forms.Button btnOyunaBasla;
    }
}