using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInterface
{
    interface IDrawable
    {
        void Draw();
    }
    class Circle : IDrawable
    {
        private double radius;
        public Circle(double radius)
        {
           this.radius = radius;
        }

        //public double Radius
        //{
        //    get { return this.radius; }
        //    set { this.radius = value; }
        //}

        public void Draw()
        {
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;

            for (double y = this.radius; y >= -this.radius; --y)
            {
                for (double x = -this.radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
