using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Steganography_154048G
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = null;
        private string extractedText = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            dataTextBox.Text = "";
            textBox1.Text = "";
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
                textBox1.Text = open_dialog.FileName;
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            

            if (bmp == null)
            {
                MessageBox.Show("No Image file", "Error");

                return;
            }

            int h = bmp.Height;
            int w = bmp.Width;
            int pixels = h * w;

            
            string text = dataTextBox.Text;

            if (pixels * 3 <(text.Length*8)+8) {

                MessageBox.Show("Image is not enough", "Error");

                return;
            }

                if (text.Equals(""))
            {
                MessageBox.Show("The text you want to hide can't be empty", "Error");

                return;
            }

            if (text.Length > 255)
            {
                MessageBox.Show("The text is too big !!! Maximum length is 255", "Error");

                return;
            }

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] < 32 || text[i] > 125)
                {

                    MessageBox.Show("Message contain invalid character(s)", "Error");
                    return;
                }
            }


            bmp = SteganographyOps.embedText(text, bmp);

            MessageBox.Show("Your text was hidden in the image successfully!", "OK");
            dataTextBox.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                           
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

                textBox1.Text = save_dialog.FileName;
            }
           
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string extractedText = SteganographyOps.extractText(bmp);

            if (extractedText==null || extractedText.Equals(""))
            {
                MessageBox.Show("Not contain a secret message", "Error");
            }
            else
            {
                dataTextBox.Text = extractedText;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
