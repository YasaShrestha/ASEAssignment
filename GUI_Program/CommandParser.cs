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
        private bool fill = false;

        private Dictionary<string, string> variableValueMap = new Dictionary<string, string>();

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

                String[] paramArrayParsed = new String[paramArray.Length];
                int count = 0;
                    foreach ( var param in paramArray )
                {
                    paramArrayParsed[count] = variableValueMap.ContainsKey(param)? variableValueMap[param] : param;
                    count++;
                }
                paramArray = paramArrayParsed;

                    if (cmd.Contains("="))
                {
                    string[] variables = cmd.Split("=", 2);
                    string variableName = variables[0].Trim();
                    string variableValue = calculation(variables[1].Trim()).ToString();

                    if (variableValueMap.ContainsKey(variableName))
                    {
                        variableValueMap.Remove(variableName);
                    }
                    variableValueMap.Add(variableName, variableValue);
                }
                else
                {
                    /* Process different commands based on the inputCommandPartOnly*/
                    switch (inputCommandPartOnly)
                    {
                        case "circle":
                            if (paramArray == null || paramArray.Length != 1 || paramArray[0].Trim().Length == 0 || !int.TryParse(paramArray[0], out _))
                            {
                                MessageBox.Show("Cirlce need one parameter. Please input the valid radius value.");
                                return;
                            }


                            int radius = Int32.Parse(paramArray[0]);

                            Shape circle = new Shapes.Circle(g, pen, Xpos, Ypos, radius);
                            circle.Draw(fill);
                            break;

                        case "rectangle":
                            if (paramArray.Length != 2 || !int.TryParse(paramArray[0], out _) || !int.TryParse(paramArray[1], out _))
                            {
                                MessageBox.Show("Please input valid width and height for rectangle ");
                                return;

                            }
                            int width = Int32.Parse(paramArray[0]);
                            int height = Int32.Parse(paramArray[1]);
                            Shape rectangle = new Shapes.Rectangle(g, pen, Xpos, Ypos, width, height);
                            rectangle.Draw(fill);
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
                            line.Draw(fill);
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
                            triangle.Draw(fill);
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
                            if (paramArray[0] != "red" && paramArray[0] != "green" && paramArray[0] != "blue")
                            {
                                MessageBox.Show("Please input valid colour :red green or blue");

                                return;
                            }
                            PenColor = Color.FromName(paramArray[0]);


                            break;
                        case "fill":
                            if (paramArray[0].ToLower() == "on")
                            {
                                fill = true;

                            }
                            else if (paramArray[0].ToLower() == "off")
                            {
                                fill = false;
                            }
                            else
                                MessageBox.Show("Please give a valid command for fill.");



                            break;
                        case "endif":
                        case "if":
                            string evalCondtion = paramArray[0].Trim();
                            if (evalCondtion.Equals("endif") || conditionEval(evalCondtion))
                            {
                                // do nothing
                            }
                            else
                            {
                                for (int ifIndex = i; ifIndex < lineByLineCmdReader.Length; ifIndex++)
                                {
                                    string nextStatement = lineByLineCmdReader[ifIndex].Trim();
                                    if (nextStatement.Equals("endif"))
                                    {
                                        i = ifIndex;
                                        break;
                                    }
                                }
                            }
                            break;
                        case "endwhile":
                        case "while":
                            string evalCondtionLoop = paramArray[0].Trim();
                            if (evalCondtionLoop.Equals("endwhile"))
                            {
                                // do nothing
                            }
                            else
                            {
                                if (conditionEval(evalCondtionLoop))
                                {
                                    for (int ifIndex = i + 1; ifIndex < lineByLineCmdReader.Length; ifIndex++)
                                    {
                                        string nextStatement = lineByLineCmdReader[ifIndex].Trim();

                                        if (!conditionEval(evalCondtionLoop))
                                        {
                                            i = ifIndex;
                                            break;
                                        }
                                        else if (nextStatement.Equals("endwhile"))
                                        {
                                            ifIndex = i;
                                        }
                                        else
                                        {
                                            CommandParserProcess(g, nextStatement);
                                        }


                                    }
                                }
                                else
                                {
                                    for (int ifIndex = i; ifIndex < lineByLineCmdReader.Length; ifIndex++)
                                    {
                                        string nextStatement = lineByLineCmdReader[ifIndex].Trim();
                                        if (nextStatement.Equals("endwhile"))
                                        {
                                            i = ifIndex;
                                            break;
                                        }
                                    }
                                }

                            }
                            break;
                        default:
                            /*If the command is not recognized*/
                            MessageBox.Show("Command not supported.");
                            break;
                    }
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

        public int calculation(string expression)
        {

            if (expression.Contains("+"))
            {
                string[] ops = expression.Split("+");
                string op1 = ops[0].Trim();
                op1 = variableValueMap.ContainsKey(op1) ? variableValueMap[op1] : op1;

                string op2 = ops[1].Trim();
                op2 = variableValueMap.ContainsKey(op2) ? variableValueMap[op2] : op2;

                return int.Parse(op1) + int.Parse(op2);


            }
            return int.Parse(expression);
        }

        public Boolean conditionEval(string expression)
        {

            if (expression.Contains(">"))
            {
                string[] ops = expression.Split(">");
                string op1 = ops[0].Trim();
                op1 = variableValueMap.ContainsKey(op1) ? variableValueMap[op1] : op1;

                string op2 = ops[1].Trim();
                op2 = variableValueMap.ContainsKey(op2) ? variableValueMap[op2] : op2;

                return int.Parse(op1) > int.Parse(op2);


            }
            return false;
        }
    }

    

}
