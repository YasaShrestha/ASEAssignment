namespace GUI_Program
{
   
    public class Line : Shapes
    {
        protected int startPoint;
        protected int endPoint;


        public Line(Graphics graphics, Pen pen, int xpos, int ypos,int startPoint, int endPoint) : base(graphics, pen, xpos, ypos)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.endPoint = endPoint;
            this.startPoint = startPoint;
        }

        public override void Draw(bool fillColor)
        {

            // Create points that define line.
            PointF point1 = new PointF(this.Xpos, this.Ypos);
            PointF point2 = new PointF(startPoint, endPoint);

            // Draw line to screen.
            graphics.DrawLine(pen, point1, point2);
            
        }
    }
}

