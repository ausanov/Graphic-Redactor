using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace graphic_redactor
{
    public partial class Form1 : Form
    {
        Image file;
        Bitmap newBmp;
        Graphics gr, save;
        Pen p;

        string image, size;
        int blurAmount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public Image CalculateBarChart(Image image)
        {
            Bitmap barChart = null;
            if (image != null)
            {
                int width = 488, height = 335;
                Bitmap bmp = new Bitmap(image);
                barChart = new Bitmap(width, height);
                int[] R = new int[256];
                int[] G = new int[256];
                int[] B = new int[256];
                int i, j;
                Color color;
                for (i = 0; i < bmp.Width; ++i)
                    for (j = 0; j < bmp.Height; ++j)
                    {
                        color = bmp.GetPixel(i, j);
                        ++R[color.R];
                        ++G[color.G];
                        ++B[color.B];
                    }
                int max = 0;
                for (i = 0; i < 256; ++i)
                {
                    if (R[i] > max)
                        max = R[i];
                    if (G[i] > max)
                        max = G[i];
                    if (B[i] > max)
                        max = B[i];
                }
                double point = (double)max / height;
                for (i = 0; i < width - 2; ++i)
                {
                    for (j = height - 1; j > height - R[i / 3] / point; --j)
                    {
                        barChart.SetPixel(i, j, Color.Red);
                    }
                    ++i;
                    for (j = height - 1; j > height - G[i / 3] / point; --j)
                    {
                        barChart.SetPixel(i, j, Color.Green);
                    }
                    ++i;
                    for (j = height - 1; j > height - B[i / 3] / point; --j)
                    {
                        barChart.SetPixel(i, j, Color.Blue);
                    }
                }
            }
            else
                barChart = new Bitmap(1, 1);
            return barChart;
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog;
            if (pictureBox1.Image != null)
            {
                if (MessageBox.Show("Предыдущее изображение будет заменено, вы уверены, что хотите этого?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    openFileDialog = new OpenFileDialog
                    {
                        InitialDirectory = "D:\\Lab works\\Обробка мультимедіа",
                        Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF;*.TIFF)|*.BMP;*.JPG;*.PNG;*.GIF;*.TIFF|All files (*.*)|*.*"
                    };

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            GetImageInformation(openFileDialog.FileName);
                            file = Image.FromFile(openFileDialog.FileName);
                            newBmp = new Bitmap(openFileDialog.FileName);
                            pictureBox1.Image = file;
                            image = openFileDialog.FileName;                       
                        }
                        catch
                        {
                            MessageBox.Show("Невозможно открыть выбранный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = "D:\\Lab works\\Graphic & Multimedia\\Изображения для л.р №1",
                    Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF;*.TIFF)|*.BMP;*.JPG;*.PNG;*.GIF;*.TIFF|All files (*.*)|*.*"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        GetImageInformation(openFileDialog.FileName);
                        file = Image.FromFile(openFileDialog.FileName);
                        newBmp = new Bitmap(openFileDialog.FileName);
                        pictureBox1.Image = file;
                        image = openFileDialog.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно открыть выбранный файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GetImageInformation(string fileName)
        {

            FileInfo img = new FileInfo(fileName);
            size = img.Length.ToString();
        }

        private void Frame_Click(object sender, EventArgs e)
        {
            if (file != null)
            {
                save = Graphics.FromImage(pictureBox1.Image);
                gr = pictureBox1.CreateGraphics();
                p = new Pen(Color.Red, 20);
                Rectangle rect = new Rectangle(0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height);
                Rectangle rec = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
                save.DrawRectangle(p, rect);
                gr.DrawRectangle(p, rec);
            }
            else MessageBox.Show("Не было выбрано изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            if (file != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog
                {
                    Title = "Сохранить картинку как",
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF;*.TIFF)|*.BMP;*.JPG;*.PNG;*.GIF;*.TIFF|All files (*.*)|*.*",
                    ShowHelp = true
                };
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (savedialog.FileName.Substring(savedialog.FileName.Length - 3).ToLower() == "bmp")
                            file.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        if (savedialog.FileName.Substring(savedialog.FileName.Length - 3).ToLower() == "png")
                            file.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        if (savedialog.FileName.Substring(savedialog.FileName.Length - 3).ToLower() == "jpg")
                            file.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        if (savedialog.FileName.Substring(savedialog.FileName.Length - 3).ToLower() == "gif")
                            file.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        if (savedialog.FileName.Substring(savedialog.FileName.Length - 3).ToLower() == "tiff")
                            file.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Tiff);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Не было выбрано изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Property_Click(object sender, EventArgs e)
        {
            if (file != null)
            {
                string pixel = pictureBox1.Image.PixelFormat.ToString();
                string colorDepth = "";
                char[] mas = pixel.ToCharArray();
                foreach (char h in mas)
                {
                    if (char.IsDigit(h) == true)
                        colorDepth += h;
                }

                string height = (pictureBox1.Image.Height).ToString();
                string width = (pictureBox1.Image.Width).ToString();
                string all = string.Concat("Высота: ", height, "px\nШирина: ", width, "px\nРазмер: ", size, "bytes\nГлубина цвета: ", colorDepth);
                MessageBox.Show(all, "Данные об изображении", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Не было выбрано изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Inversion_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    Color newColor;
                    newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    newBmp.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void Sync_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    int k = 25;
                    Color newColor;
                    if ((oldColor.R <= 255 && oldColor.R + k <= 255) && (oldColor.G <= 255 && oldColor.G + k <= 255) && (oldColor.B <= 255 && oldColor.B + k <= 255))
                    {
                        newColor = Color.FromArgb(oldColor.A, oldColor.R + k, oldColor.G + k, oldColor.B + k);
                        newBmp.SetPixel(x, y, newColor);
                    }
                    else k = 0;
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void CanalRed_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    int k = 25;
                    Color newColor;
                    if (oldColor.R <= 255 && oldColor.R + k <= 255)
                    {
                        newColor = Color.FromArgb(oldColor.A, oldColor.R + k, oldColor.G, oldColor.B);
                        newBmp.SetPixel(x, y, newColor);
                    }
                    else k = 0;
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void CanalGreen_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    int k = 25;
                    Color newColor;
                    if (oldColor.G <= 255 && oldColor.G + k <= 255)
                    {
                        newColor = Color.FromArgb(oldColor.A, oldColor.R, oldColor.G + k, oldColor.B);
                        newBmp.SetPixel(x, y, newColor);
                    }
                    else k = 0;
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void CanalBlue_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    int k = 25;
                    Color newColor;
                    if (oldColor.B <= 255 && oldColor.B + k <= 255)
                    {
                        newColor = Color.FromArgb(oldColor.A, oldColor.R, oldColor.G, oldColor.B + k);
                        newBmp.SetPixel(x, y, newColor);
                    }
                    else k = 0;
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void RadioBW_CheckedChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    Color newColor;
                    if (radioBW.Checked == true)
                    {
                        int grayScale = (int)((oldColor.R * .3) + (oldColor.G * .59) + (oldColor.B * .11));
                        newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                        newBmp.SetPixel(x, y, newColor);
                    }
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void RadioBG_CheckedChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    Color newColor;
                    if (radioBG.Checked == true)
                    {
                        newColor = Color.FromArgb(0, (oldColor.R + oldColor.G + oldColor.B) / 3, 0);
                        newBmp.SetPixel(x, y, newColor);
                    }
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void RadioBY_CheckedChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    Color newColor;
                    if (radioBY.Checked == true)
                    {
                        newColor = Color.FromArgb((oldColor.R + oldColor.G) / 2, (oldColor.R + oldColor.G) / 2, 255 - ((oldColor.R + oldColor.G + oldColor.B) / 3));
                        newBmp.SetPixel(x, y, newColor);
                    }
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void RadioRW_CheckedChanged(object sender, EventArgs e)
        {
            for (int x = 0; x < newBmp.Width; x++)
            {
                for (int y = 0; y < newBmp.Height; y++)
                {
                    Color oldColor = newBmp.GetPixel(x, y);
                    Color newColor;
                    if (radioRW.Checked == true)
                    {
                        newColor = Color.FromArgb(255, (oldColor.R + oldColor.G + oldColor.B) / 3, (oldColor.R + oldColor.G + oldColor.B) / 3);
                        newBmp.SetPixel(x, y, newColor);
                    }
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void CallBackImage_Click(object sender, EventArgs e)
        {
            newBmp = new Bitmap(image);
            pictureBox1.Image = newBmp;
            pictureBox1.Invalidate();
        }

        private void Histogramm_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = CalculateBarChart(pictureBox1.Image);
            pictureBox2.Invalidate();
        }

        private void Blur_Click(object sender, EventArgs e)
        {
            for (int i = blurAmount; i <= newBmp.Width - blurAmount; i++)
            {
                for (int j = blurAmount; j <= newBmp.Height - blurAmount; j++)
                {
                    try
                    {
                        Color prevX = newBmp.GetPixel(i - blurAmount, j);
                        Color nextX = newBmp.GetPixel(i + blurAmount, j);
                        Color prevY = newBmp.GetPixel(i, j - blurAmount);
                        Color nextY = newBmp.GetPixel(i, j + blurAmount);

                        int avgR = (int)((prevX.R + nextX.R + prevY.R + nextY.R) / 4);
                        int avgG = (int)((prevX.G + nextX.G + prevY.G + nextY.G) / 4);
                        int avgB = (int)((prevX.B + nextX.B + prevY.B + nextY.B) / 4);

                        newBmp.SetPixel(i, j, Color.FromArgb(avgR, avgG, avgB));
                    }
                    catch (Exception) { }
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void UpdateBlur(object sender, EventArgs e)
        {
            blurAmount = int.Parse(trackBarBlur.Value.ToString());

        }

        public static Bitmap AddBrightness(Bitmap Image, int Value)
        {
            Bitmap TempBitmap = Image;         
            float FinalValue = (float)Value / 255.0f;
            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);
            Graphics NewGraphics = Graphics.FromImage(NewBitmap);
            float[][] FloatColorMatrix = {
                                             new float[] {FinalValue, 0, 0, 0, 0},
                                             new float[] {0, FinalValue, 0, 0, 0},
                                             new float[] {0, 0, FinalValue, 0, 0},
                                             new float[] {0, 0, 0, 1, 0},
                                             new float[] {0, 0, 0, 0, 1}          
                                         };
            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();
            return NewBitmap;
        }

        private void TrackBarBrightness_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBarBrightness.Value.ToString();
            pictureBox1.Image = AddBrightness(newBmp, trackBarBrightness.Value);
        }

        private void TrackBarContrast_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBarContrast.Value.ToString();
            for (int i = 0; i < newBmp.Width; i++)
            {
                for (int j = 0; j < newBmp.Height; j++)
                {
                    Color oldColor = newBmp.GetPixel(i, j);
                    int avgR = (int)((oldColor.R * 100 - 128 * trackBarContrast.Value) / (100 - trackBarContrast.Value));
                    if (avgR < 0) avgR = 0;
                    else if (avgR > 255) avgR = 255;

                    int avgG = (int)((oldColor.G * 100 - 128 * trackBarContrast.Value) / (100 - trackBarContrast.Value));
                    if (avgG < 0) avgG = 0;
                    else if (avgG > 255) avgG = 255;

                    int avgB = (int)((oldColor.B * 100 - 128 * trackBarContrast.Value) / (100 - trackBarContrast.Value));
                    if (avgB < 0) avgB = 0;
                    else if (avgB > 255) avgB = 255;

                    newBmp.SetPixel(i, j, Color.FromArgb(avgR, avgG, avgB));
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void Emboss_Click(object sender, EventArgs e)
        {
            //вертикальный
            //double[,] filter = {
            //                       { -1.0, 0.0, 1.0 },
            //                       { -2.0, 0.0, 2.0 },
            //                       { -1.0, 0.0, 1.0}
            //                   };
            double[,] filter = {
                                   { -1.0, -1.0, -1.0 },
                                   { -1.0, 9.0, -1.0 },
                                   { -1.0, -1.0, -1.0}
                               };
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color newC;
                    int[] sum = { 0, 0, 0 };
                    for (int ky = -1; ky < 2; ky++)
                    {
                        for (int kx = -1; kx < 2; kx++)
                        {
                            newC = newBmp.GetPixel(x + kx, y + ky);
                            int[] rgb = { newC.R, newC.G, newC.B };
                            for (int i = 0; i < 3; i++)
                            {
                                sum[i] += Convert.ToInt32(rgb[i] * filter[kx + 1, ky + 1]);
                            }

                        }
                    }
                    if (sum[0] > 255) sum[0] = 255;
                    if (sum[1] > 255) sum[1] = 255;
                    if (sum[2] > 255) sum[2] = 255;
                    if (sum[0] < 0) sum[0] = 0;
                    if (sum[1] < 0) sum[1] = 0;
                    if (sum[2] < 0) sum[2] = 0;
                    newC = Color.FromArgb(1, sum[0], sum[1], sum[2]);
                    newBmp.SetPixel(x, y, newC);
                }
            }
            pictureBox1.Image = newBmp;
        }

        private void BlurGauss_Click(object sender, EventArgs e)
        {
            double v = 1.0 / 10.0;
            double[,] filter = {
                                   { v, v, v},
                                   { v, 2*v, v},
                                   { v, v, v}
                               };
            double v2 = 1.0 / 16.0;
            double[,] filter2 = {
                                     { v2, 2*v2, v2},
                                     { 2*v2, 4*v2, 2*v2},
                                     { v2, 2*v2, v2}
                                 };
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color newC;
                    int[] sum = { 0, 0, 0 };
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            newC = newBmp.GetPixel(x + kx, y + ky);
                            int[] rgb = { newC.R, newC.G, newC.B };
                            for (int i = 0; i < 3; i++)
                            {
                                sum[i] += Convert.ToInt32(rgb[i] * filter[kx + 1, ky + 1]);
                            }
                            
                        }
                    }
                    if (sum[0] > 255) sum[0] = 255;
                    if (sum[1] > 255) sum[1] = 255;
                    if (sum[2] > 255) sum[2] = 255;
                    if (sum[0] < 0) sum[0] = 0;
                    if (sum[1] < 0) sum[1] = 0;
                    if (sum[2] < 0) sum[2] = 0;
                    newC = Color.FromArgb(1, sum[0], sum[1], sum[2]);
                    newBmp.SetPixel(x, y, newC);
                }
            }
            pictureBox1.Image = newBmp;
        }

        public static Bitmap AddContrast(Bitmap Image, int Value)
        {
            Bitmap TempBitmap = Image;
            float contrast = (float)Value;
            float T = 0.5f * (1f - contrast);
            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);
            Graphics NewGraphics = Graphics.FromImage(NewBitmap);
            float[][] FloatColorMatrix = {
                                             new float[] {contrast, 0, 0, 0, 0},
                                             new float[] {0, contrast, 0, 0, 0},
                                             new float[] {0, 0, contrast, 0, 0},
                                             new float[] {0, 0, 0, 1, 0},
                                             new float[] {T, T, T, 1, 1}          
                                         };
            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();
            return NewBitmap;
        }

        private void TrackBarContrast2Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar1.Value.ToString();
            pictureBox1.Image = AddContrast(newBmp, trackBar1.Value);
        }

        private void Borderline_Click(object sender, EventArgs e)
        {
            //горизонтальный
            //-1 -2 -1
            // 0  0  0
            // 1  2  1 
            double k = -1.0 / 4.0;
            double[,] filter = {
                                  {k, k, k},
                                  {k, 3.0, k},
                                  {k, k, k}
                               };
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color newC;
                    int[] sum = { 0, 0, 0 };
                    for (int ky = -1; ky < 2; ky++)
                    {
                        for (int kx = -1; kx < 2; kx++)
                        {
                            newC = newBmp.GetPixel(x + kx, y + ky);
                            int[] rgb = { newC.R, newC.G, newC.B };
                            for (int i = 0; i < 3; i++)
                            {
                                sum[i] += Convert.ToInt32(rgb[i] * filter[kx + 1, ky + 1]);
                            }

                        }
                    }
                    if (sum[0] > 255) sum[0] = 255;
                    if (sum[1] > 255) sum[1] = 255;
                    if (sum[2] > 255) sum[2] = 255;
                    if (sum[0] < 0) sum[0] = 0;
                    if (sum[1] < 0) sum[1] = 0;
                    if (sum[2] < 0) sum[2] = 0;
                    newC = Color.FromArgb(1, sum[0], sum[1], sum[2]);
                    newBmp.SetPixel(x, y, newC);
                }
            }
            pictureBox1.Image = newBmp;
        }
    }
}
