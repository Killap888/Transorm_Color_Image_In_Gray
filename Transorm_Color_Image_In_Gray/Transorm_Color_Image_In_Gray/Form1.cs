using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Transorm_Color_Image_In_Gray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Bitmap image;

        private void download_image_Click(object sender, EventArgs e)// кнопка загрузки изображения
        {
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(ofd.FileName);
                    pictureBoxInput.Image = image;                    

                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
       
        private void convert_image_Click(object sender, EventArgs e)
        {
            if (pictureBoxInput.Image != null) // если изображение в pictureBoxInput имеется
            {               
                ProcessUsingLockbits(image);
            }

            // выводим черно-белый Bitmap в pictureBoxOutput
            pictureBoxOutput.Image = image;
        
        }


        public void ProcessUsingLockbits(Bitmap processedBitmap)
        {
            BitmapData bitmapData = processedBitmap.LockBits(new Rectangle(0, 0, processedBitmap.Width, processedBitmap.Height), ImageLockMode.ReadWrite, processedBitmap.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(processedBitmap.PixelFormat) / 8;
            int byteCount = bitmapData.Stride * processedBitmap.Height;
            byte[] pixels = new byte[byteCount];
            IntPtr ptrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;

            //Color ArGBformat;

            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * bitmapData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    int oldBlue = pixels[currentLine + x];
                    int oldGreen = pixels[currentLine + x + 1];
                    int oldRed = pixels[currentLine + x + 2];                    

                    int avrColor = (oldBlue + oldGreen + oldRed) / 3;

                    int newBlue = avrColor;
                    int newGreen = avrColor;
                    int newRed = avrColor;

                    //ArGBformat = Color.FromArgb(oldBlue, oldGreen, oldRed);

                    // calculate new pixel value
                    pixels[currentLine + x] = (byte)newBlue;
                    pixels[currentLine + x + 1] = (byte)newGreen;
                    pixels[currentLine + x + 2] = (byte)newRed;

                    

                }
            }

            
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            processedBitmap.UnlockBits(bitmapData);
        }






    }
}
