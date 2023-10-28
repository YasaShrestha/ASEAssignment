using System.Net;
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

        private Color PenColor = Color.Black;

        // all this method logic will be shifted to CommandParser class
        private void runButton_Click(object sender, EventArgs e)
        {
            String inputCommand = codeTextBox.Text;
            if (inputCommand == null ||  inputCommand.Length == 0)
            {
                inputCommand = richcodeTextBox.Text;
            }

            //google string split on the basis of  new line 
            //return will be array list
            //iterated/loop through that array list and each item will be passed as inputCommand to below code

            //code block start
            // reason: it will cover box text field i.e multiple command as well as single command enable

            //after first space split that one string then we will get cmd and parameter seperately
            //split param section on the basis of comma, then trim all space one by one from each param
            if (inputCommand.ToLower().Equals("circle")|| inputCommand.ToLower().Equals("circle"))
            {
                float raduis = 10;
                drawCircle(raduis);
            }else if(inputCommand.ToLower().Equals("rectangle")|| inputCommand.ToLower().Equals("rectangle"))
            {
                float width = 10;
                float height = 10;
                drawRectangle(width, height);
            }
            else if(inputCommand.Equals("drawto") || inputCommand.ToLower().Equals("drawto"))
            {
                float startingPoint = 10;
                float endPoint = 20;
                drawTo(startingPoint,endPoint);
    }
            else if (inputCommand.ToLower().Equals("trangle") || richcodeTextBox.Text.ToLower().Equals("trangle"))
            {
                
                int width = 10;
            int height = 10;
                drawTrangle(width,height);
                //MessageBox.Show("Trangle");
            }
            else if (codeTextBox.Text.ToLower().Equals("clear") || richcodeTextBox.Text.ToLower().Equals("clear"))
            {
                clearDraw();
            }
            else if (codeTextBox.Text.ToLower().Equals("reset") || richcodeTextBox.Text.ToLower().Equals("reset"))
            {
                reset();
            }
            else if (codeTextBox.Text.ToLower().Equals("moveto") || richcodeTextBox.Text.ToLower().Equals("moveto"))
            {
                moveTo(Xpos,Ypos);
            }
            else if (codeTextBox.Text.ToLower().Equals("pen") || richcodeTextBox.Text.ToLower().Equals("pen"))
            {
                PenColor = Color.Red;
            }
            //code block end
            else
            {
               
                MessageBox.Show("nothing or not defined.");
            }
           



        }

        private void drawPen(String penColor)
        {

            this.PenColor = Color.Red; // penColor change TO Color instance
        }

        private void drawRectangle(float width, float height)
        {
           
            Graphics g = drawingBoard.CreateGraphics();
            Pen penen = new Pen(PenColor);
            g.DrawRectangle(penen, Xpos, Ypos, width, height);
            g.Dispose();
        }

       

        private void drawCircle(float radius)
        {

            Graphics g = drawingBoard.CreateGraphics();
            // Create a Pen for drawing the outline of the circle
            Pen pen = new Pen(PenColor);

            
           

            // Fill the circle with a color
            Brush brush = new SolidBrush(PenColor);

            // Draw the circle
           // g.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(pen, Xpos- radius, Ypos - radius, 2 * radius, 2 * radius);

            pen.Dispose();
        }

        private void drawTrangle(int width, int height)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen pen = new Pen(PenColor);


            Point[] trianglePoints = {
            new Point(width / 2, height), // Top point
            new Point(width, height),    // Bottom-left point
            new Point(width,height) // Bottom-right point
            };

            g.DrawPolygon(pen, trianglePoints);
            pen.Dispose();

        }

        private void drawTo(float Xpos, float Ypos)
        {
            Graphics g = drawingBoard.CreateGraphics();
            // Create pen.
            Pen pen = new Pen(PenColor);

            // Create points that define line.
            PointF point1 = new PointF(this.Xpos, Ypos);
            PointF point2 = new PointF(this.Ypos, Xpos);

            // Draw line to screen.
            g.DrawLine(pen, point1, point2);
            pen.Dispose();
        }

        private void clearDraw()
        {
            Graphics g = drawingBoard.CreateGraphics();
            g.Clear(Color.SkyBlue);
        }

        private float Xpos = 200;
        private float Ypos = 200;

        private void moveTo(float Xpos, float Ypos)
        {
            Graphics g = drawingBoard.CreateGraphics();
            // Create pen.
            Pen pen = new Pen(PenColor);
            this.Xpos = 50;
            this.Ypos = 100;


        }

       

        private void reset()
        {
            Graphics g = drawingBoard.CreateGraphics();
            // Create pen.
            Pen pen = new Pen(PenColor);

            pen.ResetTransform();
            pen.Dispose();
            //this.moveTo(0,0);
            this.Xpos = 0;
            this.Ypos = 0;
           
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