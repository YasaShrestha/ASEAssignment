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

            //
            if (codeTextBox.Text.ToLower().Equals("circle"))
            {
                drawCircle();
            }else if(codeTextBox.Text.ToLower().Equals("rectangle"))
            {
                drawRectangle();
            }
            else if(codeTextBox.Text.ToLower().Equals("drawto"))
            {
                drawTo();
    }
            else if (codeTextBox.Text.ToLower().Equals("trangle"))
            {
                drawTrangle();
                //MessageBox.Show("Trangle");
            }
            else if (codeTextBox.Text.ToLower().Equals("clear"))
            {
                clearDraw();
            }
            else
            {
               
                MessageBox.Show("nothing or not defined.");
            }



        }

        private void drawRectangle()
        {
           
            Graphics g = drawingBoard.CreateGraphics();
            Pen penen = new Pen(Color.Black);
            g.DrawRectangle(penen, 10, 10, 50, 50);
            g.Dispose();
        }

       

        private void drawCircle()
        {

            Graphics g = drawingBoard.CreateGraphics();

            // Define the circle's position and size
            int x = 100; // X-coordinate of the circle's center
            int y = 100; // Y-coordinate of the circle's center
            int radius = 50; // Radius of the circle

            // Create a Pen for drawing the outline of the circle
            Pen pen = new Pen(Color.Black);

            // Fill the circle with a color
            Brush brush = new SolidBrush(Color.Black);

            // Draw the circle
           // g.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(pen, x - radius, y - radius, 2 * radius, 2 * radius);

            // Clean up resources
            pen.Dispose();
        }

        private void drawTrangle()
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            int width = 100;
            int height = 100;

            Point[] trianglePoints = {
            new Point(width / 2, 0), // Top point
            new Point(0, height),    // Bottom-left point
            new Point(width,height) // Bottom-right point
            };

            g.DrawPolygon(pen, trianglePoints);
            pen.Dispose();

        }

        private void drawTo()
        {
            Graphics g = drawingBoard.CreateGraphics();
            // Create pen.
            Pen pen = new Pen(Color.Black);

            // Create points that define line.
            PointF point1 = new PointF(100, 100);
            PointF point2 = new PointF(250, 100);

            // Draw line to screen.
            g.DrawLine(pen, point1, point2);
        }

        private void clearDraw()
        {
            Graphics g = drawingBoard.CreateGraphics();
            g.Clear(Color.SkyBlue);
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
    }
}