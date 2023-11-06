using Shapes;
using System.Net;
using System.Reflection.Metadata;
using System.Windows.Forms;


namespace GUI_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        private void runButton_Click(object sender, EventArgs e)
        {
            String inputCommand = codeTextBox.Text;
            if (inputCommand == null || inputCommand.Length == 0)
            {
                inputCommand = richcodeTextBox.Text;
            }

            Graphics g = drawingBoard.CreateGraphics();

            CommandParser commandParser = new CommandParser();
            commandParser.CommandParserProcess(g, inputCommand);


        }


        private void syntaxButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Syntax button message");
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;


            string readText = File.ReadAllText(@"C:\Users\hp\Desktop\New folder\gpl_program.txt");
            richcodeTextBox.Text = readText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog1 = new SaveFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";


            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string selectedFileName = openFileDialog1.FileName;

            String inputCommand = codeTextBox.Text;
            if (inputCommand == null || inputCommand.Length == 0)
            {
                inputCommand = richcodeTextBox.Text;
            }

            //save inputCommand to file
            File.WriteAllText(@"C:\Users\hp\Desktop\New folder\gpl_program.txt", inputCommand);
        }
    }
}