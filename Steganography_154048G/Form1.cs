using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Steganography_154048G
{
    public partial class Form1 : Form
    {
        //catch the image
        private Bitmap bmp = null;
        //catch the message
        private string extractedText = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        //activate after click on the upload image tab
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

        //activate after click hide message button
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
            //check whether image is enough to hold the message
            if (pixels * 3 <(text.Length*8)+8) {

                MessageBox.Show("Image is not enough", "Error");

                return;
            }

            //check message box is empty
            if (text.Equals(""))
            {
                MessageBox.Show("You have not entered any message ", "Error");

                return;
            }
            // check message is greater than 255 characters
            if (text.Length > 255)
            {
                MessageBox.Show("The text is too big !!! Maximum length is 255", "Error");

                return;
            }
            //check message contain invalid chracters
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] < 32 || text[i] > 125)
                {

                    MessageBox.Show("Message contain invalid character(s)", "Error");
                    return;
                }
            }


            bmp = SteganographyOps.embedText(text, bmp);

            MessageBox.Show("Message was hidden in the image successfully!", "OK");
            dataTextBox.Text = "";

        }

        //activate after click save image button
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("No Image file", "Error");

                return;
            }

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
        //activate after click extract message button
        private void extractButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            if (bmp == null)
            {
                MessageBox.Show("No Image file", "Error");

                return;
            }

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
