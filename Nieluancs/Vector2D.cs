using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Nieluancs
{
    class Vector2D
    {
        private int _vertices;
        private int _width;
        private int _height;
        public Vector2D(int vertices, int width, int height)
        {
            this._vertices = vertices;
            this._width = width;
            this._height = height;
        }

        public List<Point> getRandomPoint()
        {
            List<Point> lstPoint = new List<Point>();
            int x = 0;
            int y = 0; 
            for(int index = 1; index <= this._vertices; ++index)
            {
                if (index == 1)
                {
                    x = 590;
                    y = 320;
                    lstPoint.Add(new Point(x, y));
                }
                if (index == 2)
                {
                    x = 520;
                    y = 300;
                    lstPoint.Add(new Point(x, y));

                }
                if (index == 3)
                {
                    x = 603;
                    y = 383;
                    lstPoint.Add(new Point(x, y));
                }
                if (index == 4)
                {
                    x = 437;
                    y = 245;
                    lstPoint.Add(new Point(x, y));
                }
                if (index == 5)
                {
                    x = 360;
                    y = 111;
                    lstPoint.Add(new Point(x, y));
                }
                if (index == 6)
                {
                    x = 492;
                    y = 380;
                    lstPoint.Add(new Point(x, y));
                }
                if (index == 7)
                {
                    x = 328;
                    y = 327;
                    lstPoint.Add(new Point(x, y));
                }
                if (index == 8)
                {
                    x = 245;
                    y = 217;
                    lstPoint.Add(new Point(x, y));
                }
                if (index == 9)
                {
                    x = 163;
                    y = 120;
                    lstPoint.Add(new Point(x, y));
                }
                
            }
            
            return lstPoint;
        }
    }
}
    

