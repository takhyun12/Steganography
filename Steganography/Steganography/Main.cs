/**
 * 제작자 : 군수전산소 정보보호실 하사 정택현 
 * 작품설명 : 이미지의 픽셀에 문자열을 고도로 암호화하여 숨기는 프로그램
 **/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Steganography
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Bitmap ImgBmp = null;
        SteganographyConvert stgpcvt = new SteganographyConvert();


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (this.pbImgView.Image == null)
            {
                MessageBox.Show("이미지를 선택해 주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImgBmp = (Bitmap)this.pbImgView.Image;

            string HiddenText = this.txtData.Text;

            if (String.IsNullOrEmpty(HiddenText) == true)
            {
                MessageBox.Show("이미지에 숨길 문자열을 입력하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtData.Focus();
                return;
            }

            if (this.txtKey.Text.Length < 8)
            {
                MessageBox.Show("비밀키는 8자리 이상 문자를 입력하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtKey.Focus();
                return;
            }
            else
            {
                HiddenText = Crypto.EncryptStringAES(HiddenText, this.txtKey.Text);
            }
            stgpcvt.runNum += new SteganographyConvert.ProcessEventHandler(StegaStatus);
            ImgBmp = stgpcvt.embedText(HiddenText, ImgBmp);

            if (this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                switch (this.sfdFile.FilterIndex)
                {
                    case 0:
                        {
                            ImgBmp.Save(this.sfdFile.FileName, ImageFormat.Png);
                        } break;
                    case 1:
                        {
                            ImgBmp.Save(this.sfdFile.FileName, ImageFormat.Bmp);
                        } break;
                }
            }
            ControlClearAll();
        }

        private void ControlClearAll()
        {
            this.pbImgView.Image = null;
            this.txtData.Clear();
            this.txtKey.Clear();
            this.btnEncrypt.Enabled = false;
            this.btnDecrypt.Enabled = false;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            ImgBmp = (Bitmap)this.pbImgView.Image;

            stgpcvt.runNum += new SteganographyConvert.ProcessEventHandler(StegaStatus);
            string ExtractedText = stgpcvt.ExtractText(ImgBmp);

            try
            {
                ExtractedText = Crypto.DecryptStringAES(ExtractedText, this.txtKey.Text);
            }
            catch
            {
                MessageBox.Show("비밀키가 일치하지 않습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtKey.Focus();
                return;
            }

            this.txtData.Text = ExtractedText;
        }

        private void StegaStatus(int Current)
        {
            Application.DoEvents();
        }


        private void pbImgView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var directoryName = (string[])e.Data.GetData(DataFormats.FileDrop);
                pbImgView.Image = Image.FromFile(directoryName[0], true);

                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
