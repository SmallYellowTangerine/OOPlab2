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
    class ShapeTriangle : ShapeLine
    {
        List<int> coordArrayTriangle = new List<int>();

        public List<int> getTriangleCoord(List<int> coordArrayTriangle, int x, int y, int x2, int y2)
        {
            getLineCoord(coordArrayTriangle, x, y, x2, y2);
            getLineCoord(coordArrayTriangle, x2, y2, x + 15, y + 30);
            getLineCoord(coordArrayTriangle, x + 15, y + 30, x, y);
            return (coordArrayTriangle);
        }

        new public List<int> getCoord(int x, int y)
        {
            return (getTriangleCoord(coordArrayTriangle, x, y, x + 30, y));
        }
    }
}
