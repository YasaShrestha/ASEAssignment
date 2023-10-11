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

        private void button1_Click(object sender, EventArgs e)
        {

            //
            if (textBox1.Text.ToLower().Equals("rectangle"))
            {
                drawRectangle();
            }else
            {
                MessageBox.Show("nothing or not defined.");
            }



        }

        private void drawRectangle()
        {
           
            Graphics g = panel1.CreateGraphics();
            Pen selPen = new Pen(Color.Blue);
            g.DrawRectangle(selPen, 10, 10, 50, 50);
            g.Dispose();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Syntax button message");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}