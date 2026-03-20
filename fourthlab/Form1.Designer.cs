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
            btnRefill = new Button();
            btnGet = new Button();
            txtOut = new RichTextBox();
            warriorInfo = new TextBox();
            mageInfo = new TextBox();
            archerInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_10;
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 495);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(81, 340);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(90, 23);
            btnRefill.TabIndex = 1;
            btnRefill.Text = "Пополнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.BackColor = SystemColors.MenuHighlight;
            btnGet.FlatStyle = FlatStyle.Popup;
            btnGet.ForeColor = Color.WhiteSmoke;
            btnGet.Location = new Point(243, 392);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(75, 46);
            btnGet.TabIndex = 2;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // txtOut
            // 
            txtOut.BorderStyle = BorderStyle.None;
            txtOut.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOut.Location = new Point(43, 386);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(172, 58);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            txtOut.TextChanged += txtOut_TextChanged;
            // 
            // warriorInfo
            // 
            warriorInfo.BorderStyle = BorderStyle.None;
            warriorInfo.Location = new Point(70, 133);
            warriorInfo.Name = "warriorInfo";
            warriorInfo.ReadOnly = true;
            warriorInfo.Size = new Size(123, 16);
            warriorInfo.TabIndex = 4;
            // 
            // mageInfo
            // 
            mageInfo.BorderStyle = BorderStyle.None;
            mageInfo.Location = new Point(70, 190);
            mageInfo.Name = "mageInfo";
            mageInfo.ReadOnly = true;
            mageInfo.Size = new Size(123, 16);
            mageInfo.TabIndex = 5;
            mageInfo.TextChanged += mageInfo_TextChanged;
            // 
            // archerInfo
            // 
            archerInfo.BorderStyle = BorderStyle.None;
            archerInfo.Location = new Point(70, 246);
            archerInfo.Name = "archerInfo";
            archerInfo.ReadOnly = true;
            archerInfo.Size = new Size(123, 16);
            archerInfo.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 515);
            Controls.Add(archerInfo);
            Controls.Add(mageInfo);
            Controls.Add(warriorInfo);
            Controls.Add(txtOut);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtOut;
        private TextBox warriorInfo;
        private TextBox mageInfo;
        private TextBox archerInfo;
    }
}
