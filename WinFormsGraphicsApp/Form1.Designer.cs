namespace WinFormsGraphicsApp
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
            richTextBox = new RichTextBox();
            boldButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(137, 61);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(490, 263);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // boldButton
            // 
            boldButton.Location = new Point(159, 20);
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(75, 23);
            boldButton.TabIndex = 1;
            boldButton.Text = "Red";
            boldButton.UseVisualStyleBackColor = true;
            boldButton.Click += boldButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(273, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Bold";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "size+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(23, 111);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "size-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(boldButton);
            Controls.Add(richTextBox);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
        private Button boldButton;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}