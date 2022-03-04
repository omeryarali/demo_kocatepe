namespace demo_kocatepe.admin
{
    partial class frmBooks
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtAthr = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.txtsayfasayı = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.Label();
            this.txtyayinevi = new System.Windows.Forms.TextBox();
            this.yayin = new System.Windows.Forms.Label();
            this.txtbasimyil = new System.Windows.Forms.TextBox();
            this.txtbasimyili = new System.Windows.Forms.Label();
            this.rchaciklama = new System.Windows.Forms.Label();
            this.rchacikla = new System.Windows.Forms.RichTextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(146, 68);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(176, 21);
            this.txtBookName.TabIndex = 1;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(146, 94);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(176, 21);
            this.txtyazar.TabIndex = 3;
            // 
            // txtAthr
            // 
            this.txtAthr.AutoSize = true;
            this.txtAthr.Location = new System.Drawing.Point(103, 94);
            this.txtAthr.Name = "txtAthr";
            this.txtAthr.Size = new System.Drawing.Size(37, 13);
            this.txtAthr.TabIndex = 2;
            this.txtAthr.Text = "Yazarı:";
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(146, 120);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(176, 21);
            this.txtsayfa.TabIndex = 5;
            // 
            // txtsayfasayı
            // 
            this.txtsayfasayı.AutoSize = true;
            this.txtsayfasayı.Location = new System.Drawing.Point(77, 120);
            this.txtsayfasayı.Name = "txtsayfasayı";
            this.txtsayfasayı.Size = new System.Drawing.Size(64, 13);
            this.txtsayfasayı.TabIndex = 4;
            this.txtsayfasayı.Text = "Sayfa Sayısı:";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(146, 146);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(176, 21);
            this.txtprice.TabIndex = 7;
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Location = new System.Drawing.Point(113, 146);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(30, 13);
            this.fiyat.TabIndex = 6;
            this.fiyat.Text = "Fiyat";
            // 
            // txtyayinevi
            // 
            this.txtyayinevi.Location = new System.Drawing.Point(146, 172);
            this.txtyayinevi.Name = "txtyayinevi";
            this.txtyayinevi.Size = new System.Drawing.Size(176, 21);
            this.txtyayinevi.TabIndex = 9;
            // 
            // yayin
            // 
            this.yayin.AutoSize = true;
            this.yayin.Location = new System.Drawing.Point(92, 172);
            this.yayin.Name = "yayin";
            this.yayin.Size = new System.Drawing.Size(48, 13);
            this.yayin.TabIndex = 8;
            this.yayin.Text = "Yayınevi:";
            // 
            // txtbasimyil
            // 
            this.txtbasimyil.Location = new System.Drawing.Point(146, 198);
            this.txtbasimyil.Name = "txtbasimyil";
            this.txtbasimyil.Size = new System.Drawing.Size(176, 21);
            this.txtbasimyil.TabIndex = 11;
            // 
            // txtbasimyili
            // 
            this.txtbasimyili.AutoSize = true;
            this.txtbasimyili.Location = new System.Drawing.Point(88, 198);
            this.txtbasimyili.Name = "txtbasimyili";
            this.txtbasimyili.Size = new System.Drawing.Size(54, 13);
            this.txtbasimyili.TabIndex = 10;
            this.txtbasimyili.Text = "Basım Yılı:";
            // 
            // rchaciklama
            // 
            this.rchaciklama.AutoSize = true;
            this.rchaciklama.Location = new System.Drawing.Point(90, 227);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(53, 13);
            this.rchaciklama.TabIndex = 12;
            this.rchaciklama.Text = "Açıklama:";
            // 
            // rchacikla
            // 
            this.rchacikla.Location = new System.Drawing.Point(146, 224);
            this.rchacikla.Name = "rchacikla";
            this.rchacikla.Size = new System.Drawing.Size(174, 181);
            this.rchacikla.TabIndex = 13;
            this.rchacikla.Text = "";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(146, 411);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(176, 23);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.rchacikla);
            this.Controls.Add(this.rchaciklama);
            this.Controls.Add(this.txtbasimyil);
            this.Controls.Add(this.txtbasimyili);
            this.Controls.Add(this.txtyayinevi);
            this.Controls.Add(this.yayin);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.txtsayfasayı);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.txtAthr);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmBooks";
            this.Text = "fromBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Label txtAthr;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label txtsayfasayı;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.TextBox txtyayinevi;
        private System.Windows.Forms.Label yayin;
        private System.Windows.Forms.TextBox txtbasimyil;
        private System.Windows.Forms.Label txtbasimyili;
        private System.Windows.Forms.Label rchaciklama;
        private System.Windows.Forms.RichTextBox rchacikla;
        private System.Windows.Forms.Button btnsave;
    }
}