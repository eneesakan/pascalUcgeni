
namespace pascalUcgeni
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dereceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hesaplaBTN = new System.Windows.Forms.Button();
            this.yaziEkraniRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dereceTB
            // 
            this.dereceTB.Location = new System.Drawing.Point(278, 25);
            this.dereceTB.Name = "dereceTB";
            this.dereceTB.Size = new System.Drawing.Size(123, 20);
            this.dereceTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaçıncı Dereceden Pascal Üçgeni Oluşturulacak:";
            // 
            // hesaplaBTN
            // 
            this.hesaplaBTN.Location = new System.Drawing.Point(407, 23);
            this.hesaplaBTN.Name = "hesaplaBTN";
            this.hesaplaBTN.Size = new System.Drawing.Size(75, 23);
            this.hesaplaBTN.TabIndex = 2;
            this.hesaplaBTN.Text = "Hesapla";
            this.hesaplaBTN.UseVisualStyleBackColor = true;
            this.hesaplaBTN.Click += new System.EventHandler(this.hesaplaBTN_Click);
            // 
            // yaziEkraniRTB
            // 
            this.yaziEkraniRTB.Location = new System.Drawing.Point(34, 63);
            this.yaziEkraniRTB.Name = "yaziEkraniRTB";
            this.yaziEkraniRTB.ReadOnly = true;
            this.yaziEkraniRTB.Size = new System.Drawing.Size(448, 215);
            this.yaziEkraniRTB.TabIndex = 3;
            this.yaziEkraniRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 302);
            this.Controls.Add(this.yaziEkraniRTB);
            this.Controls.Add(this.hesaplaBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dereceTB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dereceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hesaplaBTN;
        private System.Windows.Forms.RichTextBox yaziEkraniRTB;
    }
}

