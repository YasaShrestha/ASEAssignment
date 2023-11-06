namespace Shapes
{
    
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;

        public Rectangle(Graphics graphics, Pen pen,int xpos,int ypos, int width, int height) : base(graphics,pen, xpos,ypos)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.width = width;
            this.height = height;
        }

        public override void Draw(bool fillColor)
        {
            if(fillColor) { 
            SolidBrush brush = new SolidBrush(Color.Blue);
            graphics.FillRectangle(brush, Xpos, Ypos, width, height);
        }else
            graphics.DrawRectangle(pen, Xpos, Ypos, width, height);
        }
    }
}
    
