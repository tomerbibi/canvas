using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class MyCanvas
    {
        public const int MaxWidth = 800;
        public const int MaxHeight = 600;
        private static int ButtonIndex = 0;
        private static int MaxButtons = 3;
        private static Button[] buttons = new Button[MaxButtons];
        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (ButtonIndex < 3)
            {
                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);
                buttons[ButtonIndex] = new Button(point1, point2);
                ButtonIndex++;
                return true;
            }
            return false;
        }
        public static bool MooveButton(int buttonnumber, int x1, int y1, int x2, int y2)
        {
            if (buttonnumber >= 0 && buttonnumber <= 3)
            {
                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);
                    if (!buttons[buttonnumber].SetTopLeft(point1))
                {
                    return false;
                }
                   if (!buttons[buttonnumber].SetBottomRight(point2))
                {
                    return false;
                }
            }
            return true;
        }
      
        public static bool RemoveLastButton ()
        {
         if (ButtonIndex == 0)
            {
                return false;
            }
            else
            {
                buttons[ButtonIndex] = null;
                ButtonIndex--;
                return true;
            }
        }
        public static void ClearAllButtons ()
        {
            for (int i = 0; i < ButtonIndex; i++)
            {
                buttons[i] = null;
                ButtonIndex--;
            }
        }
      public static int GetCurrentNumberOfButtons()
        {
            return ButtonIndex;
        }
        public static int GetMaxNumberOFButtons()
        {
            return MaxButtons;
        }
        public static int GetMaxWidthOfAButton()
        {
            if(ButtonIndex == 0)
            {
                return 0;
            }
            else
            {
                int widestButton = 0;
                    for (int i = 0; i < ButtonIndex; i++)
                {
                    if (buttons[i].GetWidth() > widestButton)
                    {
                        widestButton = buttons[i].GetWidth();
                    }
                }
                return widestButton;
            }
        }
        public static int GetMaxhightOfAButton()
        {
            if (ButtonIndex == 0)
            {
                return 0;
            }
            else
            {
                int highestButton = 0;
                for (int i = 0; i < ButtonIndex; i++)
                {
                    if (buttons[i].GetHight() > highestButton)
                    {
                        highestButton = buttons[i].GetHight();
                    }
                }
                return highestButton;
            }
        }



    }
}
