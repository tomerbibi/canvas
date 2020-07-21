using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Button
    {
        protected Point _topLeft;
        protected Point _bottomRight;
        private int _width;
        private int _hight;

        public Button(Point topLeft, Point bottomRight)
        {
            _topLeft = topLeft;
            _bottomRight = bottomRight;
            _width = bottomRight.GetX() - topLeft.GetX();
            _hight = topLeft.GetY() - bottomRight.GetY();
        }
        internal int GetWidth()
        {
            return _width;
        }
        internal int GetHight()
        {
            return _hight;
        }

        internal bool SetTopLeft(Point newPoint)
        {
            
            if (newPoint.GetX() < _bottomRight.GetX() && newPoint.GetY() > _bottomRight.GetY())
            {
                _topLeft = newPoint;
                _width = _bottomRight.GetX() - _topLeft.GetX();
                _hight = _topLeft.GetY() - _bottomRight.GetY();
                return true;
            }
            return false;
        }
        internal bool SetBottomRight(Point newPoint)
        {

            if (newPoint.GetX() > _topLeft.GetX() && newPoint.GetY() < _topLeft.GetY())
            {
                _bottomRight = newPoint;
                _width = _bottomRight.GetX() - _topLeft.GetX();
                _hight = _topLeft.GetY() - _bottomRight.GetY();
                return true;
            }
            return false;
        }


    }
}
