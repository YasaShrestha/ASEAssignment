namespace Shapes
{
    
    public class Triangle : Shape
    {
        protected int width;
        protected int height;

        public Triangle(Graphics graphics, Pen pen, int xpos, int ypos, int width, int height) : base(graphics, pen, xpos, ypos)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.width = width;
            this.height = height;
        }

        public override void Draw(bool fillColor)
        {
            Point[] trianglePoints = {
            new Point(Xpos, Ypos), // Top point
            new Point(Xpos, height+Ypos),    // Bottom-left point
            new Point(height+Ypos,width+Xpos) // Bottom-right point
            };

            graphics.DrawPolygon(pen, trianglePoints);
        }
    }
}

