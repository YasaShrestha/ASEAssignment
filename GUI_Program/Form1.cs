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


        /*this method will take the command line and process it through the command parser*/
        private void runButton_Click(object sender, EventArgs e)
        {
            String inputCommand = richcodeTextBox.Text;
            if (inputCommand == null || inputCommand.Length == 0)
            {
                inputCommand = codeTextBox.Text;
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
            openFileDialog1.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string readFileLocation = openFileDialog1.FileName;


            string readText = File.ReadAllText(readFileLocation);
            richcodeTextBox.Text = readText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*;";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory= true;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string saveFileLocation = saveFileDialog1.FileName;

            String inputCommand = codeTextBox.Text;
            if (inputCommand == null || inputCommand.Length == 0)
            {
                inputCommand = richcodeTextBox.Text;
            }

            //save inputCommand to file
            File.WriteAllText(saveFileLocation, inputCommand);
        }
    }
}