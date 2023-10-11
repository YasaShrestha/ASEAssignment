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
            if (textBox1.Text.ToLower().Equals("circle"))
            {
                drawCircle();
            }else if(textBox1.Text.ToLower().Equals("rectangle"))
            {
                drawRectangle();
            }
            else if(textBox1.Text.ToLower().Equals("drawto"))
            {
                drawTo();
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

       

        private void drawCircle()
        {

            Graphics g = panel1.CreateGraphics();

            // Define the circle's position and size
            int x = 100; // X-coordinate of the circle's center
            int y = 100; // Y-coordinate of the circle's center
            int radius = 50; // Radius of the circle

            // Create a Pen for drawing the outline of the circle
            Pen pen = new Pen(Color.Black);

            // Fill the circle with a color
            Brush brush = new SolidBrush(Color.Red);

            // Draw the circle
           // g.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(pen, x - radius, y - radius, 2 * radius, 2 * radius);

            // Clean up resources
            pen.Dispose();
        }

        private void drawTrangle()
        {
            Graphics g = panel1.CreateGraphics();
        }

        private void drawTo()
        {
            Graphics g = panel1.CreateGraphics();
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(500.0F, 100.0F);

            // Draw line to screen.
            g.DrawLine(blackPen, point1, point2);
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