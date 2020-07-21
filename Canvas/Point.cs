using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Point
    {
        private int _x;
        private int _y;

        internal Point(int x, int y)
        {
            _x = x;
            _y = y;
        }



        internal int GetX ()
        {
            return _x;
        }
        internal int GetY()
        {
            return _y;
        }
        internal void SetX (int newX)
        {
            if (newX < 0 || newX > 800)
            {
                Console.WriteLine("you need to put a number between 0 to 800");
            }
            else
            {
                _x = newX;
            }
        }
        internal void SetY(int newY)
        {
            if (newY < 0 || newY > 600)
            {
                Console.WriteLine("you need to put a number between 0 to 600");
            }
            else
            {
                _x = newY;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $": x = {_x}, y = {_y}"; 
        }
    }
}
