namespace Steganography
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.pbImgView = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.plStegano = new System.Windows.Forms.Panel();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgView)).BeginInit();
            this.plStegano.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "mage Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp\"";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "Png Image|*.png|Bitmap Image|*.bmp";
            // 
            // pbImgView
            // 
            this.pbImgView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgView.Location = new System.Drawing.Point(6, 6);
            this.pbImgView.Name = "pbImgView";
            this.pbImgView.Size = new System.Drawing.Size(705, 276);
            this.pbImgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgView.TabIndex = 1;
            this.pbImgView.TabStop = false;
            this.pbImgView.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbImgView_DragEnter);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(22, 52);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 12);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "데이터";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(73, 19);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(608, 75);
            this.txtData.TabIndex = 3;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(73, 100);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(608, 21);
            this.txtKey.TabIndex = 5;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(22, 105);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(41, 12);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "비밀키";
            // 
            // plStegano
            // 
            this.plStegano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plStegano.Controls.Add(this.btnDecrypt);
            this.plStegano.Controls.Add(this.btnEncrypt);
            this.plStegano.Controls.Add(this.txtKey);
            this.plStegano.Controls.Add(this.txtData);
            this.plStegano.Controls.Add(this.lblData);
            this.plStegano.Controls.Add(this.lblKey);
            this.plStegano.Location = new System.Drawing.Point(6, 288);
            this.plStegano.Name = "plStegano";
            this.plStegano.Size = new System.Drawing.Size(705, 180);
            this.plStegano.TabIndex = 6;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(368, 133);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(113, 34);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "복호화";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(240, 133);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(113, 34);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "암호화";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(716, 475);
            this.Controls.Add(this.plStegano);
            this.Controls.Add(this.pbImgView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Steganography";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgView)).EndInit();
            this.plStegano.ResumeLayout(false);
            this.plStegano.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.PictureBox pbImgView;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Panel plStegano;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

