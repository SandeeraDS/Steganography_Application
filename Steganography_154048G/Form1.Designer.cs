namespace Steganography_154048G
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 334);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(520, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 268);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter the Message";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dataTextBox.Location = new System.Drawing.Point(7, 22);
            this.dataTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataTextBox.MaxLength = 300;
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(461, 226);
            this.dataTextBox.TabIndex = 2;
            this.dataTextBox.Tag = "";
            // 
            // extractButton
            // 
            this.extractButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.extractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractButton.Location = new System.Drawing.Point(724, 362);
            this.extractButton.Margin = new System.Windows.Forms.Padding(4);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(241, 57);
            this.extractButton.TabIndex = 3;
            this.extractButton.Text = "Extract Message";
            this.extractButton.UseVisualStyleBackColor = false;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.hideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hideButton.Location = new System.Drawing.Point(9, 362);
            this.hideButton.Margin = new System.Windows.Forms.Padding(4);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(241, 57);
            this.hideButton.TabIndex = 0;
            this.hideButton.Text = "Hide Message";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagePictureBox.Image = global::Steganography_154048G.Properties.Resources.click_to_upload;
            this.imagePictureBox.Location = new System.Drawing.Point(9, 34);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(495, 302);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(392, 362);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(217, 57);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.imagePictureBox);
            this.groupBox2.Controls.Add(this.hideButton);
            this.groupBox2.Controls.Add(this.extractButton);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 441);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Image Link";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(646, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(319, 51);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1021, 465);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "154048G-Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

