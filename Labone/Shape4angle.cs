using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Labone
{
    class Shape4angle : ShapeTriangle
    {
        List<int> coordArray4angle = new List<int>();

        public List<int> get4angleCoord(List<int> coordArray4angle, int x, int y, int x2, int y2)
        {
            getTriangleCoord(coordArray4angle, x, y, x2, y2);
            getTriangleCoord(coordArray4angle, x2, y2, x2 - 15, y2 + 30);
            return (coordArray4angle);
        }

        new public List<int> getCoord(int x, int y)
        {
            return (get4angleCoord(coordArray4angle, x, y, x + 30, y));
        }
    }
}
