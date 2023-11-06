namespace GUI_Program
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
            richcodeTextBox = new RichTextBox();
            runButton = new Button();
            syntaxButton = new Button();
            drawingBoard = new Panel();
            codeTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // richcodeTextBox
            // 
            richcodeTextBox.Location = new Point(3, 17);
            richcodeTextBox.Name = "richcodeTextBox";
            richcodeTextBox.Size = new Size(502, 456);
            richcodeTextBox.TabIndex = 0;
            richcodeTextBox.Text = "";
            // 
            // runButton
            // 
            runButton.BackColor = Color.SkyBlue;
            runButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            runButton.Location = new Point(1, 517);
            runButton.Name = "runButton";
            runButton.Size = new Size(153, 48);
            runButton.TabIndex = 1;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += runButton_Click;
            // 
            // syntaxButton
            // 
            syntaxButton.BackColor = SystemColors.MenuText;
            syntaxButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            syntaxButton.ForeColor = SystemColors.Control;
            syntaxButton.Location = new Point(160, 517);
            syntaxButton.Name = "syntaxButton";
            syntaxButton.Size = new Size(151, 48);
            syntaxButton.TabIndex = 2;
            syntaxButton.Text = "Syntax";
            syntaxButton.UseVisualStyleBackColor = false;
            syntaxButton.Click += syntaxButton_Click;
            // 
            // drawingBoard
            // 
            drawingBoard.BackColor = Color.SkyBlue;
            drawingBoard.Location = new Point(511, 17);
            drawingBoard.Name = "drawingBoard";
            drawingBoard.Size = new Size(428, 489);
            drawingBoard.TabIndex = 3;
            drawingBoard.Paint += drawingBoard_Paint;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(1, 479);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(502, 27);
            codeTextBox.TabIndex = 4;
            codeTextBox.TextChanged += codeTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(317, 517);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 5;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(417, 517);
            button2.Name = "button2";
            button2.Size = new Size(94, 42);
            button2.TabIndex = 6;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 753);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(codeTextBox);
            Controls.Add(drawingBoard);
            Controls.Add(syntaxButton);
            Controls.Add(runButton);
            Controls.Add(richcodeTextBox);
            Name = "Form1";
            Text = "Graphical Interface Program";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richcodeTextBox;
        private Button runButton;
        private Button syntaxButton;
        private Panel drawingBoard;
        private TextBox codeTextBox;
        private Button button1;
        private Button button2;
    }
}