using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FFCwinforms
{
    public partial class Form1 : Form
    {
        public int size = 30;
        public double[,] rawImage, darkFrame, flatFrame, correctedImage;
        public int pixelSize = 8;
        public double interval = 1;

        public Form1()
        {
            InitializeComponent();
            size = 30;
            rawImage = new double[size, size];
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            rawImage = LoadImage(size, dialog.FileName);
            DisplayImage(rawPanel, rawImage, pixelSize);
        }

        private void loadDarkButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            darkFrame = LoadImage(size, dialog.FileName);
            DisplayImage(darkPanel, darkFrame, pixelSize);
        }

        private void loadFlatButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            flatFrame = LoadImage(size, dialog.FileName);
            DisplayImage(flatPanel, flatFrame, pixelSize);
        }

        private void updateSizeButton_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(sizeBox.Text);
            sizeLabel.Text = "Size " + size;
        }

        private void correctButton_Click(object sender, EventArgs e)
        {
            correctedImage = CorrectImage(rawImage, darkFrame, flatFrame);
            DisplayImage(correctedPanel, correctedImage, pixelSize);
        }

        private void updateIntervalButton_Click(object sender, EventArgs e)
        {
            interval = Convert.ToDouble(intervalBox.Text);
            intervalLabel.Text = "Interval " + interval;
        }

        private void updatePixelSizeButton_Click(object sender, EventArgs e)
        {
            pixelSize = Convert.ToInt32(pixelSizeBox.Text);
            pixelSizeLabel.Text = "Pixel size " + pixelSize;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string output = "";

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    output += correctedImage[j, i];
                    if (!(i == size - 1 && j == size - 1))
                        output += " ";
                }
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "file.txt";
            dialog.DefaultExt = ".txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, output);
            }
        }

        private double[,] LoadImage(int width, string filename)
        {
            double[,] output = new double[width, width];

            StreamReader reader = new StreamReader(filename);

            string str = reader.ReadToEnd();
            int row = 0;
            string[] numsStrings = str.Split(new char[] { ' ' });
            double[] rownums = new double[width];

            for (int i = 0; i <= numsStrings.Length; i++)
            {
                if (i != 0)
                {
                    if (i % (width) == 0)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            output[j, row] = rownums[j];
                        }
                        rownums = new double[width];
                        row++;
                    }
                }
                if (i != size * size)
                    rownums[i % (width)] = Convert.ToDouble(numsStrings[i]) / interval;
            }
            return output;
        }

        private void DisplayImage(Panel panel, double[,] image, int cellSize)
        {
            panel.Controls.Clear();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    PictureBox cell = new PictureBox();
                    cell.Width = cell.Height = cellSize;
                    int color = (int)(255f * image[i, j]);

                    cell.BackColor = Color.FromArgb(color, Color.Black);
                    cell.Location = new Point(i * cellSize, j * cellSize);

                    panel.Controls.Add(cell);
                }
            }
        }

        public double[,] CorrectImage(double[,] rawImage, double[,] darkFrame, double[,] flatFrame)
        {
            double m = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    m += flatFrame[i, j] - darkFrame[i, j];
                }
            }
            m /= flatFrame.Length;

            double gain;
            double[,] correctedImage = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    gain = m / (flatFrame[i, j] - darkFrame[i, j]);
                    correctedImage[i, j] = (rawImage[i, j] - darkFrame[i, j]) * gain;
                    if (correctedImage[i, j] < 0)
                        correctedImage[i, j] = 0;
                    if (correctedImage[i, j] > 1)
                        correctedImage[i, j] = 1;
                }
            }
            return correctedImage;
        }


    }
}
