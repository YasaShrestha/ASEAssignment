namespace GUI_Program
{
    
    public class Circle : Shapes
    {
        protected int radius;
        

        public Circle(Graphics graphics, Pen pen,int xpos,int ypos, int radius) : base(graphics, pen, xpos, ypos)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.radius = radius;
        }

        public override void Draw(bool fillColor)
        {
            graphics.DrawEllipse(pen, Xpos - radius, Ypos - radius, 2 * radius, 2 * radius);
        }
    }
}

