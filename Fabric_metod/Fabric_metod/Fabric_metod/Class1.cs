using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric_metod
{
    public class SquareFactory : IShapeFactory
    {
        public Shape CreateShape() => new Square();
    }
    public class LineFactory : IShapeFactory
    {
        public Shape CreateShape() => new Line();
    }
    public class CircleFactory : IShapeFactory
    {
        public Shape CreateShape() => new Circle();
    }
    public interface IShapeFactory
    {
        Shape CreateShape();
    }
    public abstract class Shape
    {
        public abstract void Draw(Graphics g, Point location, int h, int k);
    }

    public class Square : Shape
    {
        public override void Draw(Graphics g, Point location, int h, int k)
        {
            g.DrawRectangle(Pens.Black, location.X, location.Y, h, k);
        }
    }

    public class Circle : Shape
    {
        public override void Draw(Graphics g, Point location, int h, int k)
        {
            g.DrawEllipse(Pens.Black, location.X, location.Y, h, k);
        }
    }
    public class Line : Shape
    {
        public override void Draw(Graphics g, Point location, int h, int k)
        {
            g.DrawLine(Pens.Black, location.X, location.Y, h, k);
        }
    }
}
