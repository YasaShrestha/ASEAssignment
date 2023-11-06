using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Program
{
    using System;
    using System.Drawing;
    /*Command Parser class to controll all the commands given by the user.*/
    public class CommandParser
    {
        private Color PenColor = Color.Black;
        private int Xpos = 0;
        private int Ypos = 0;

        public void CommandParserProcess(Graphics g, String inputCommand)
        {
            if (inputCommand == null || inputCommand.Length == 0)
            {
                MessageBox.Show("Command not found. Please input command.");
                return;
            }
                // Split input commands by line
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

                    // Process different commands based on the inputCommandPartOnly
                    switch (inputCommandPartOnly)
                    {
                        case "circle":
                        if (paramArray ==null||paramArray.Length!= 1 || paramArray[0].Trim().Length==0|| !int.TryParse(paramArray[0], out _))
                        {
                            MessageBox.Show("Cirlce need one parameter. Please input the radius value.");
                            return;
                        }
                   
                        
                            int radius = Int32.Parse(paramArray[0]);

                            Shape circle = new Shapes.Circle(g, pen, Xpos, Ypos, radius);
                            circle.Draw();
                            break;

                        case "rectangle":
                        if (paramArray.Length != 2 || !int.TryParse(paramArray[0], out _)|| !int.TryParse(paramArray[1], out _))
                        {
                            MessageBox.Show("Please input valid width and height for rectangle ");
                            return;

                        }
                        int width = Int32.Parse(paramArray[0]);
                            int height = Int32.Parse(paramArray[1]);
                            Shape rectangle = new Shapes.Rectangle(g, pen, Xpos, Ypos, width, height);
                            rectangle.Draw();
                            break;

                        case "drawto":
                        if (paramArray.Length != 2 || !int.TryParse(paramArray[0], out _) && !int.TryParse(paramArray[1], out _))
                        {
                            MessageBox.Show("Please input valid starting point value and end point value ");
                            return;

                        }
                        int startingPoint = Int32.Parse(paramArray[0]);
                            int endPoint = Int32.Parse(paramArray[1]);
                            Shape line = new Shapes.Line(g, pen, Xpos, Ypos, startingPoint, endPoint);
                            line.Draw();
                            break;

                        case "triangle":
                        if (paramArray.Length != 2 || !int.TryParse(paramArray[0], out _) || !int.TryParse(paramArray[1], out _))
                        {
                            MessageBox.Show("Please input valid width and height for the triangle ");
                            return;

                        }
                        int triWidth = Int32.Parse(paramArray[0]);
                            int triHeight = Int32.Parse(paramArray[1]);
                            Shape triangle = new Shapes.Triangle(g, pen, Xpos, Ypos, triWidth, triHeight);
                            triangle.Draw();
                            break;

                        case "clear":
                            clearDraw(g);
                            break;

                        case "reset":
                            reset(g);
                            break;

                        case "moveto":
                        if (paramArray.Length != 2 || !int.TryParse(paramArray[0], out _) || !int.TryParse(paramArray[1], out _))
                        {
                            MessageBox.Show("Please input valid X axis and Y axis ");
                            return;

                        }
                        int newXpos = Int32.Parse(paramArray[0]);
                            int newYpos = Int32.Parse(paramArray[1]);
                            moveTo(newXpos, newYpos);
                            break;

                        case "pen":
                        if ( !(paramArray[0] is string)&&paramArray[0] != "red"&& paramArray[0] != "green" && paramArray[0]!="blue")
                        {
                            MessageBox.Show("Please input valid colour :red green or blue");

                             return;
                         }
                            PenColor = Color.FromName(paramArray[0]);
                        

                            break;

                        default:
                            // If the command is not recognized
                            MessageBox.Show("Command not supported.");
                            break;
                    }
                }
            }
            

        /* Method to clear all the drawings */
        private void clearDraw(Graphics g)
        {
            g.Clear(Color.SkyBlue);
        }

        /* Method to reset graphics and move pen point to 0,0 */
        private void reset(Graphics g)
        {
            Pen pen = new Pen(PenColor);

            pen.ResetTransform();
            pen.Dispose();
            this.Xpos = 0;
            this.Ypos = 0;
            this.clearDraw(g);
        }

        /* Method to move the X,Y points in the drawing board */
        private void moveTo(int newXpos, int newYpos)
        {
            this.Xpos = newXpos;
            this.Ypos = newYpos;
        }
    }



}
