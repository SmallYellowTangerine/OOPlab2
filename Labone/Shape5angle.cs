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
    class Shape5angle : Shape4angle 
    {
        List<int> coordArray5angle = new List<int>();

        public List<int> get5angleCoord(List<int> coordArray5angle, int x, int y, int x2, int y2)
        {
            get4angleCoord(coordArray5angle, x, y, x2, y2);
            getTriangleCoord(coordArray5angle, x+15, y+30, x2 + 15, y2 + 30);
            return (coordArray5angle);
        }

        new public List<int> getCoord(int x, int y)
        {
            return (get5angleCoord(coordArray5angle, x, y, x + 30, y));
        }
    }
}
