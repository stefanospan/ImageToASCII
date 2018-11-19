using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToASCII
{
    public partial class Form1 : Form
    {

        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }

        //Uploads Image

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter ="JPG Files (*.jpg)|*.jpg| PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bmp = new Bitmap(ofd.FileName);
                bmp = new Bitmap(bmp, 250, 250);
                imageOriginal.Image = bmp;
            }
        }

        //Converts Image To ASCII

        private void convertButton_Click(object sender, EventArgs e)
        {
            //Gets Image Width And Height
            int imageWidth = imageOriginal.Image.Size.Width;
            int imageHeight = imageOriginal.Image.Size.Height;

            //Converts Image To GreyScale
            Color p;
            string str = "";
            imageTextBox.Text = "";
            for(int x = 0; x < imageWidth; x++)
            {
                for(int y = 0; y < imageHeight; y++)
                {
                    p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;

                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }

            //Converts to ASCII

            for(int y = 0; y < imageHeight; y++)
            {
                for(int x = 0; x < imageWidth; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    if (c.R > 231)
                    {
                        str += ". ";
                    }
                    else if (c.R > 207)
                    {
                        str += ". ";
                    }
                    else if (c.R > 183)
                    {
                        str += ": ";
                    }
                    else if (c.R > 159)
                    {
                        str += "- ";
                    }
                    else if (c.R > 135)
                    {
                        str += "= ";
                    }
                    else if (c.R > 111)
                    {
                        str += "+ ";
                    }
                    else if (c.R > 87)
                    {
                        str += "* ";
                    }
                    else if (c.R > 63)
                    {
                        str += "# ";
                    }
                    else if (c.R > 39)
                    {
                        str += "% ";
                    }
                    else
                    {
                        str += "@ ";
                    }
                }
                str += "\r\n";
            }
            imageTextBox.AppendText(str);
        }
    }
}
