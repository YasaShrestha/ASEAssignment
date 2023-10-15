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
            SuspendLayout();
            // 
            // richcodeTextBox
            // 
            richcodeTextBox.Location = new Point(1, 17);
            richcodeTextBox.Name = "richcodeTextBox";
            richcodeTextBox.Size = new Size(472, 295);
            richcodeTextBox.TabIndex = 0;
            richcodeTextBox.Text = "";
            // 
            // runButton
            // 
            runButton.BackColor = Color.SkyBlue;
            runButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            runButton.Location = new Point(12, 402);
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
            syntaxButton.Location = new Point(248, 402);
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
            drawingBoard.Size = new Size(428, 295);
            drawingBoard.TabIndex = 3;
            drawingBoard.Paint += drawingBoard_Paint;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(1, 339);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(472, 27);
            codeTextBox.TabIndex = 4;
            codeTextBox.TextChanged += codeTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 753);
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
    }
}