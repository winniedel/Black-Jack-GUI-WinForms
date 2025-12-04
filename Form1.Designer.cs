namespace BlackJack_GUI
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
            outputBox = new RichTextBox();
            hitButton = new Button();
            standButton = new Button();
            newGameButton = new Button();
            cardPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).BeginInit();
            SuspendLayout();
            // 
            // outputBox
            // 
            outputBox.Location = new Point(0, 0);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(425, 271);
            outputBox.TabIndex = 0;
            outputBox.Text = "";
            outputBox.TextChanged += outputBox_TextChanged;
            // 
            // hitButton
            // 
            hitButton.Location = new Point(80, 322);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(75, 23);
            hitButton.TabIndex = 1;
            hitButton.Text = "Hit";
            hitButton.UseVisualStyleBackColor = true;
            hitButton.Click += hitButton_Click;
            // 
            // standButton
            // 
            standButton.Location = new Point(201, 322);
            standButton.Name = "standButton";
            standButton.Size = new Size(75, 23);
            standButton.TabIndex = 2;
            standButton.Text = "Stand";
            standButton.UseVisualStyleBackColor = true;
            standButton.Click += standButton_Click;
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(320, 322);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(75, 23);
            newGameButton.TabIndex = 3;
            newGameButton.Text = "New Game";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newGameButton_Click;
            // 
            // cardPictureBox
            // 
            cardPictureBox.Location = new Point(396, 221);
            cardPictureBox.Name = "cardPictureBox";
            cardPictureBox.Size = new Size(29, 50);
            cardPictureBox.TabIndex = 4;
            cardPictureBox.TabStop = false;
            cardPictureBox.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(cardPictureBox);
            Controls.Add(newGameButton);
            Controls.Add(standButton);
            Controls.Add(hitButton);
            Controls.Add(outputBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox outputBox;
        private Button hitButton;
        private Button standButton;
        private Button newGameButton;
        private PictureBox cardPictureBox;
    }
}
