namespace list_ornek2_777
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.btnBuyuk = new System.Windows.Forms.Button();
            this.btnKucuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(32, 24);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(167, 329);
            this.lbSayilar.TabIndex = 0;
            // 
            // btnBuyuk
            // 
            this.btnBuyuk.Location = new System.Drawing.Point(223, 65);
            this.btnBuyuk.Name = "btnBuyuk";
            this.btnBuyuk.Size = new System.Drawing.Size(159, 61);
            this.btnBuyuk.TabIndex = 1;
            this.btnBuyuk.Text = "büyük sayılar";
            this.btnBuyuk.UseVisualStyleBackColor = true;
            this.btnBuyuk.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnKucuk
            // 
            this.btnKucuk.Location = new System.Drawing.Point(223, 190);
            this.btnKucuk.Name = "btnKucuk";
            this.btnKucuk.Size = new System.Drawing.Size(159, 61);
            this.btnKucuk.TabIndex = 2;
            this.btnKucuk.Text = "küçük sayılar";
            this.btnKucuk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 361);
            this.Controls.Add(this.btnKucuk);
            this.Controls.Add(this.btnBuyuk);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.Button btnBuyuk;
        private System.Windows.Forms.Button btnKucuk;
    }
}

