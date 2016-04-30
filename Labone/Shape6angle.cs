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
    class Shape6angle : ShapeLine
    {
        List<int> coordArray6angle = new List<int>();

        public List<int> get6angleCoord(List<int> coordArray6angle, int x, int y, int x2, int y2)
        {
            getLineCoord(coordArray6angle, x, y, x2, y2);
            getLineCoord(coordArray6angle, x2, y2, x2 + 15, y2 + 30);
            getLineCoord(coordArray6angle, x2 + 15, y2 + 30, x2, y2+60);

            getLineCoord(coordArray6angle, x2, y2+60, x, y+60);
            getLineCoord(coordArray6angle, x, y+60, x - 15, y + 30);
            getLineCoord(coordArray6angle, x - 15, y + 30, x, y);
            return (coordArray6angle);
        }

        new public List<int> getCoord(int x, int y)
        {
            return (get6angleCoord(coordArray6angle, x, y, x + 30, y));
        }
    }
}
