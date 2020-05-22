using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInterface
{
    class Rectangle : IDrawable

    {
        private int Height;
        private int Width;

        public Rectangle(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; i++)
            {
                DrawLine(this.Width, ' ', '*');
            }
            DrawLine(this.Width, '*', '*');
        }
        private void DrawLine(int Width, char end, char mid)
        {

            Console.Write(end);
            for (int i = 1; i < Width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.Write(end);
        }
    }
}
