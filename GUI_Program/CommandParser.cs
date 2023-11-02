using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program
{
    public class CommandParser
    {
        private Color PenColor = Color.Black;

        private int Xpos = 0;
        private int Ypos = 0;

        public void CommandParserProcess(Graphics g, String inputCommand) {
            //google string split on the basis of  new line 
            String[] lineByLineCmdReader = inputCommand.Split("\n");
            for (int i = 0; i < lineByLineCmdReader.Length; i++)
            {
                Pen pen = new Pen(PenColor);

                var cmd = lineByLineCmdReader[i];
                var splitted = cmd.Split(' ', 2);
                var inputCommandPartOnly = splitted[0].ToLower().Trim();

                var inputParam = "";
                if (splitted.Length > 1)
                {
                    inputParam = splitted[1];
                }


                String[] paramArray = inputParam.Split(",");

                if (inputCommandPartOnly.ToLower().Equals("circle") || inputCommandPartOnly.ToLower().Equals("circle"))
                {
                    int raduis = Int32.Parse(paramArray[0]); ;
                    Shape shape = new Shapes.Circle(g, pen, Xpos, Ypos, raduis);
                    shape.Draw();
                }
                else if (inputCommandPartOnly.Equals("rectangle") || inputCommandPartOnly.Equals("rectangle"))
                {


                    int width = Int32.Parse(paramArray[0]);
                    int height = Int32.Parse(paramArray[1]);
                    Shape shape = new Shapes.Rectangle(g, pen, Xpos, Ypos, width, height);
                    shape.Draw();

                }
                else if (inputCommandPartOnly.Equals("drawto") || inputCommandPartOnly.Equals("drawto"))
                {
                    int startingPoint = Int32.Parse(paramArray[0]);
                    int endPoint = Int32.Parse(paramArray[1]);
                    Shape shape = new Shapes.Line(g, pen, Xpos, Ypos, startingPoint, endPoint);
                    shape.Draw();
                }
                else if (inputCommandPartOnly.Equals("trangle") || inputCommandPartOnly.Equals("trangle"))
                {

                    int width = Int32.Parse(paramArray[0]);
                    int height = Int32.Parse(paramArray[1]);
                    Shape shape = new Shapes.Triangle(g, pen, Xpos, Ypos, width, height);
                    shape.Draw();
                }
                else if (inputCommandPartOnly.Equals("clear") || inputCommandPartOnly.Equals("clear"))
                {
                    clearDraw(g);
                }
                else if (inputCommandPartOnly.Equals("reset") || inputCommandPartOnly.Equals("reset"))
                {

                    reset(g);
                }
                else if (inputCommandPartOnly.Equals("moveto") || inputCommandPartOnly.Equals("moveto"))
                {
                    int Xpos = Int32.Parse(paramArray[0]);
                    int Ypos = Int32.Parse(paramArray[1]);
                    moveTo(Xpos, Ypos);
                }
                else if (inputCommandPartOnly.Equals("pen") || inputCommandPartOnly.Equals("pen"))
                {

                    var colorVal = paramArray[0];


                    PenColor = Color.FromName(colorVal);
                }
                //code block end
                else
                {

                    MessageBox.Show("Command not supported.");
                }
            }
        
        }

        private void clearDraw(Graphics g)
        {
            g.Clear(Color.SkyBlue);
        }

        private void reset(Graphics g)
        {
            // Create pen.
            Pen pen = new Pen(PenColor);

            pen.ResetTransform();
            pen.Dispose();
            //this.moveTo(0,0);
            this.Xpos = 0;
            this.Ypos = 0;
            this.clearDraw(g);

        }

        private void moveTo(int Xpos, int Ypos)
        {
            this.Xpos = Xpos;
            this.Ypos = Ypos;


        }


    }


}
