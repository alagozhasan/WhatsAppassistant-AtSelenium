namespace WhatsAppassistant_AtSelenium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_str_text = new System.Windows.Forms.Label();
            this.rtbx_metin = new System.Windows.Forms.RichTextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.help_btn = new System.Windows.Forms.Button();
            this.btn_qr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_str_text
            // 
            this.lbl_str_text.AutoSize = true;
            this.lbl_str_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_str_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_str_text.Location = new System.Drawing.Point(57, 269);
            this.lbl_str_text.Name = "lbl_str_text";
            this.lbl_str_text.Size = new System.Drawing.Size(255, 26);
            this.lbl_str_text.TabIndex = 1;
            this.lbl_str_text.Text = "Lütfen cevap metni girin :";
            this.lbl_str_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_str_text.Click += new System.EventHandler(this.lbl_str_text_Click);
            // 
            // rtbx_metin
            // 
            this.rtbx_metin.Location = new System.Drawing.Point(62, 307);
            this.rtbx_metin.Name = "rtbx_metin";
            this.rtbx_metin.Size = new System.Drawing.Size(238, 96);
            this.rtbx_metin.TabIndex = 2;
            this.rtbx_metin.Text = "Ne yazık ki mesai saatleri dışındasınız Pazartesi günü size dönüş yapacağız,\niyi " +
    "günler.";
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.Color.Transparent;
            this.btn_run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_run.Enabled = false;
            this.btn_run.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_run.Image = ((System.Drawing.Image)(resources.GetObject("btn_run.Image")));
            this.btn_run.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_run.Location = new System.Drawing.Point(62, 409);
            this.btn_run.Name = "btn_run";
            this.btn_run.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_run.Size = new System.Drawing.Size(238, 54);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Programı Çalıştır";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(985, 288);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(106, 32);
            this.btn_help.TabIndex = 3;
            this.btn_help.Text = "Galiba Sorun Var";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOŞGELDİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lbl_str_text_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Transparent;
            this.help_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.help_btn.Location = new System.Drawing.Point(291, 3);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(65, 41);
            this.help_btn.TabIndex = 3;
            this.help_btn.Text = "Bir Soun Yaşıyorum";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // btn_qr
            // 
            this.btn_qr.BackColor = System.Drawing.Color.Transparent;
            this.btn_qr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_qr.Location = new System.Drawing.Point(62, 63);
            this.btn_qr.Name = "btn_qr";
            this.btn_qr.Size = new System.Drawing.Size(238, 37);
            this.btn_qr.TabIndex = 3;
            this.btn_qr.Text = "QR OKUNDU";
            this.btn_qr.UseVisualStyleBackColor = false;
            this.btn_qr.Click += new System.EventHandler(this.btn_qr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(359, 490);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_qr);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.rtbx_metin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_str_text);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsAppAssistant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_str_text;
        private System.Windows.Forms.RichTextBox rtbx_metin;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button btn_qr;
    }
}

