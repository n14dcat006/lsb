using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N14DCAT006_TRANGIABAONGOC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            NewMethod();
        }

        private void NewMethod()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        Bitmap bfimage, decodeimg;


        private void encodeOpenFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Bitmap image (*.bmp)|*.bmp|Png image (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
            
                bfimage = new Bitmap(ofd.FileName);
                beforeImage.Image = bfimage;
               
            }
        }

        private void hiddenSecret_Click(object sender, EventArgs e)
        {
            if (bfimage == null || textEncode.Text == "")
                return;
            string secret = String.Empty;
            foreach (char c in textEncode.Text)
                secret += Convert.ToString((int)c, 2).PadLeft(8, '0');
            int current = 0;
            for(int j =0; j < bfimage.Height; j++)
                for( int i=0; i < bfimage.Width; i++)
                {
                    Color rgb = bfimage.GetPixel(i,j);
                    Color sauKhiDau = changeBit(rgb,secret,ref current);
                    bfimage.SetPixel(i,j, sauKhiDau); 
                    
                }
            afterImage.Image = bfimage;
        }

        private void decodeOpenFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Bitmap image (*.bmp)|*.bmp|Png image (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                decodeimg = new Bitmap(ofd.FileName);
                imageDecode.Image = decodeimg;
            }
        }

        private void giaiMa_Click(object sender, EventArgs e)
        {
            if (decodeimg == null)
                return;
            String secret = string.Empty;
            String eightBit = string.Empty;
            String result = string.Empty;
            for (int j = 0; j < decodeimg.Height; j++)
                for (int i = 0; i < decodeimg.Width; i++)
                {
                    Color rgb = decodeimg.GetPixel(i, j);
                    secret += Convert.ToString(rgb.R, 2).PadLeft(8, '0').Substring(7, 1);
                    secret += Convert.ToString(rgb.G, 2).PadLeft(8, '0').Substring(7, 1);
                    secret += Convert.ToString(rgb.B, 2).PadLeft(8, '0').Substring(7, 1);
                    if (secret.Length>8){
                        eightBit = secret.Substring(0, 8);
                        if (eightBit.Contains("00000000")) { textExtract.Text = result; return; }
                        char x=(char)(Convert.ToByte(eightBit, 2));
                        result += x.ToString();
                        secret = secret.Substring(8, secret.Length - 8);
                    }
                }
            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap image (*.bmp)|*.bmp|Png image (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
                bfimage.Save(sfd.FileName);

        }
        

        private Color changeBit (Color rgb, String secret,ref int current)
        {
            string currentR = Convert.ToString(rgb.R,2).PadLeft(8,'0');
            if(current < secret.Length)
            {
                currentR = currentR.Substring(0, 7) + secret.Substring(current, 1);
                current++;
            }
            else currentR = currentR.Substring(0, 7) + '0';
            string currentG = Convert.ToString(rgb.G,2).PadLeft(8,'0');
            if (current < secret.Length)
            {
                currentG = currentG.Substring(0, 7) + secret.Substring(current, 1);
                current++;
            }
            else currentG = currentG.Substring(0, 7) + '0';
            string currentB = Convert.ToString(rgb.B,2).PadLeft(8,'0');
            if (current < secret.Length)
            {
                currentB = currentB.Substring(0, 7) + secret.Substring(current, 1);
                current++;
            }
            else currentB = currentB.Substring(0, 7) + '0';
            return Color.FromArgb(Convert.ToByte(currentR, 2), Convert.ToByte(currentG, 2), Convert.ToByte(currentB, 2));
        }
        
    }
   }
