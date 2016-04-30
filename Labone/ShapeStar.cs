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
    class ShapeStar :Shape5angle
    {
        List<int> coordArrayStar = new List<int>();

        public List<int> getStarCoord(List<int> coordArrayStar, int x, int y, int x2, int y2)
        {
            getLineCoord(coordArrayStar, x, y, x + 10, y + 30);
            getLineCoord(coordArrayStar, x, y, x - 10, y + 30);

            getLineCoord(coordArrayStar, x, y, x + 10, y + 30);
            getLineCoord(coordArrayStar, x, y, x - 10, y + 30);

            getLineCoord(coordArrayStar, x + 10, y + 30, x + 40, y + 40);
            getLineCoord(coordArrayStar, x - 10, y + 30, x - 40, y + 40);

            getLineCoord(coordArrayStar, x + 40, y + 40, x + 10, y + 50);
            getLineCoord(coordArrayStar, x - 40, y + 40, x - 10, y + 50);

            getLineCoord(coordArrayStar, x + 10, y + 50, x, y + 80);
            getLineCoord(coordArrayStar, x - 10, y + 50, x, y + 80);

            return (coordArrayStar);
        }

        new public List<int> getCoord(int x, int y)
        {
            return (getStarCoord(coordArrayStar, x, y, x + 30, y));
        }

    }
}
