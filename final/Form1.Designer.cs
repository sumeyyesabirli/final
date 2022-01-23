
namespace final
{
    partial class Form1
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
            this.btnSayiTahimi = new System.Windows.Forms.Button();
            this.btnKronometre = new System.Windows.Forms.Button();
            this.btnNesneleriHareketEttir = new System.Windows.Forms.Button();
            this.btnKoselereCarpma = new System.Windows.Forms.Button();
            this.btnSepetleMeyveYakala = new System.Windows.Forms.Button();
            this.btnHesapMakinesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayiTahimi
            // 
            this.btnSayiTahimi.Location = new System.Drawing.Point(61, 29);
            this.btnSayiTahimi.Name = "btnSayiTahimi";
            this.btnSayiTahimi.Size = new System.Drawing.Size(177, 70);
            this.btnSayiTahimi.TabIndex = 0;
            this.btnSayiTahimi.Text = "Sayı Tahmini Oyunu";
            this.btnSayiTahimi.UseVisualStyleBackColor = true;
            this.btnSayiTahimi.Click += new System.EventHandler(this.btnSayiTahimi_Click);
            // 
            // btnKronometre
            // 
            this.btnKronometre.Location = new System.Drawing.Point(293, 29);
            this.btnKronometre.Name = "btnKronometre";
            this.btnKronometre.Size = new System.Drawing.Size(177, 70);
            this.btnKronometre.TabIndex = 1;
            this.btnKronometre.Text = "Kronometre";
            this.btnKronometre.UseVisualStyleBackColor = true;
            this.btnKronometre.Click += new System.EventHandler(this.btnKronometre_Click);
            // 
            // btnNesneleriHareketEttir
            // 
            this.btnNesneleriHareketEttir.Location = new System.Drawing.Point(61, 122);
            this.btnNesneleriHareketEttir.Name = "btnNesneleriHareketEttir";
            this.btnNesneleriHareketEttir.Size = new System.Drawing.Size(177, 70);
            this.btnNesneleriHareketEttir.TabIndex = 2;
            this.btnNesneleriHareketEttir.Text = "Nesneleri Hareket Ettirme";
            this.btnNesneleriHareketEttir.UseVisualStyleBackColor = true;
            this.btnNesneleriHareketEttir.Click += new System.EventHandler(this.btnNesneleriHareketEttir_Click);
            // 
            // btnKoselereCarpma
            // 
            this.btnKoselereCarpma.Location = new System.Drawing.Point(293, 122);
            this.btnKoselereCarpma.Name = "btnKoselereCarpma";
            this.btnKoselereCarpma.Size = new System.Drawing.Size(177, 70);
            this.btnKoselereCarpma.TabIndex = 3;
            this.btnKoselereCarpma.Text = "Köşelere Çarpma";
            this.btnKoselereCarpma.UseVisualStyleBackColor = true;
            this.btnKoselereCarpma.Click += new System.EventHandler(this.btnKoselereCarpma_Click);
            // 
            // btnSepetleMeyveYakala
            // 
            this.btnSepetleMeyveYakala.Location = new System.Drawing.Point(61, 217);
            this.btnSepetleMeyveYakala.Name = "btnSepetleMeyveYakala";
            this.btnSepetleMeyveYakala.Size = new System.Drawing.Size(177, 70);
            this.btnSepetleMeyveYakala.TabIndex = 4;
            this.btnSepetleMeyveYakala.Text = "Sepetle Meyve Yakalama";
            this.btnSepetleMeyveYakala.UseVisualStyleBackColor = true;
            this.btnSepetleMeyveYakala.Click += new System.EventHandler(this.btnSepetleMeyveYakala_Click);
            // 
            // btnHesapMakinesi
            // 
            this.btnHesapMakinesi.Location = new System.Drawing.Point(293, 217);
            this.btnHesapMakinesi.Name = "btnHesapMakinesi";
            this.btnHesapMakinesi.Size = new System.Drawing.Size(177, 70);
            this.btnHesapMakinesi.TabIndex = 5;
            this.btnHesapMakinesi.Text = "Hesap Makinesi";
            this.btnHesapMakinesi.UseVisualStyleBackColor = true;
            this.btnHesapMakinesi.Click += new System.EventHandler(this.btnHesapMakinesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 299);
            this.Controls.Add(this.btnHesapMakinesi);
            this.Controls.Add(this.btnSepetleMeyveYakala);
            this.Controls.Add(this.btnKoselereCarpma);
            this.Controls.Add(this.btnNesneleriHareketEttir);
            this.Controls.Add(this.btnKronometre);
            this.Controls.Add(this.btnSayiTahimi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayiTahimi;
        private System.Windows.Forms.Button btnKronometre;
        private System.Windows.Forms.Button btnNesneleriHareketEttir;
        private System.Windows.Forms.Button btnKoselereCarpma;
        private System.Windows.Forms.Button btnSepetleMeyveYakala;
        private System.Windows.Forms.Button btnHesapMakinesi;
    }
}

