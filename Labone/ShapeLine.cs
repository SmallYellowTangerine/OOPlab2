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
    class ShapeLine
    {        
        List<int> coordArrayLine = new List<int>();

        public List<int> getLineCoord(List<int> coordArrayLine, int x, int y, int x2, int y2)
        {
            coordArrayLine.Add(x);
            coordArrayLine.Add(y);
            coordArrayLine.Add(x2);
            coordArrayLine.Add(y2);
            return (coordArrayLine);
        }

        public List<int> getCoord(int x, int y)
        {
            return (getLineCoord(coordArrayLine, x, y, x+30, y));
        }
    }
}
