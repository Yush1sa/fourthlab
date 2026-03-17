namespace fourthlab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            addButton = new Button();
            takeButton = new Button();
            txtOut = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_10;
            pictureBox1.Location = new Point(22, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(232, 144);
            addButton.Name = "addButton";
            addButton.Size = new Size(98, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Пополнить";
            addButton.UseVisualStyleBackColor = true;
            // 
            // takeButton
            // 
            takeButton.Location = new Point(244, 316);
            takeButton.Name = "takeButton";
            takeButton.Size = new Size(75, 46);
            takeButton.TabIndex = 2;
            takeButton.Text = "Взять";
            takeButton.UseVisualStyleBackColor = true;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(53, 316);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(167, 46);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 424);
            Controls.Add(txtOut);
            Controls.Add(takeButton);
            Controls.Add(addButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button addButton;
        private Button takeButton;
        private RichTextBox txtOut;
    }
}
