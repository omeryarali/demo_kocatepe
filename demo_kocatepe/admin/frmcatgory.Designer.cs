namespace demo_kocatepe.admin
{
    partial class frmcatgory
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtcatgroy = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.rchacikla = new System.Windows.Forms.RichTextBox();
            this.rchaciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(105, 36);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(176, 21);
            this.txtBookName.TabIndex = 3;
            // 
            // txtcatgroy
            // 
            this.txtcatgroy.AutoSize = true;
            this.txtcatgroy.Location = new System.Drawing.Point(35, 39);
            this.txtcatgroy.Name = "txtcatgroy";
            this.txtcatgroy.Size = new System.Drawing.Size(67, 13);
            this.txtcatgroy.TabIndex = 2;
            this.txtcatgroy.Text = "Katagori Adı:";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(105, 249);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(176, 23);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Kaydet";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // rchacikla
            // 
            this.rchacikla.Location = new System.Drawing.Point(105, 62);
            this.rchacikla.Name = "rchacikla";
            this.rchacikla.Size = new System.Drawing.Size(174, 181);
            this.rchacikla.TabIndex = 16;
            this.rchacikla.Text = "";
            // 
            // rchaciklama
            // 
            this.rchaciklama.AutoSize = true;
            this.rchaciklama.Location = new System.Drawing.Point(49, 65);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(53, 13);
            this.rchaciklama.TabIndex = 15;
            this.rchaciklama.Text = "Açıklama:";
            // 
            // frmcatgory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.rchacikla);
            this.Controls.Add(this.rchaciklama);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtcatgroy);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmcatgory";
            this.Text = "frmcatgory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label txtcatgroy;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.RichTextBox rchacikla;
        private System.Windows.Forms.Label rchaciklama;
    }
}