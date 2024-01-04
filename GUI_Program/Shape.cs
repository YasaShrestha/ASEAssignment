using System;
namespace GUI_Program
{ 
    // Parent class
    public abstract class Shapes
{
    protected Graphics graphics;
    protected Pen pen;
    protected int Xpos;
    protected int Ypos;

    public Shapes(Graphics graphics, Pen pen, int xpos, int ypos)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.Xpos = xpos;
            this.Ypos = ypos;
        }


        public abstract void Draw(bool fillColor);

}
}

