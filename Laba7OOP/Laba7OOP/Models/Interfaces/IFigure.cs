using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7OOP.Models.Interfaces
{
    interface IFigure
    {
        double? getArea();
        double? getPerimeter();
        List<Point> getCoord();
        string getTextCoord();
        void moveAround(Vector vector); 
    }
}
