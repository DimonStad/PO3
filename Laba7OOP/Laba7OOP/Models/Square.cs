using Laba7OOP.Models;
using Laba7OOP.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7OOP 
    /// <summary>
    /// Класс квадрат
    /// </summary>
    public class Square:IFigure
    {
        private Point A { get; set; }
        private Point B { get; set; }
        private Point C { get; set; }
        private Point D { get; set; }
        /// <summary>
        /// Создание квадрата
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public Square(Point a, Point b, Point c, Point d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }

        public double? getArea()
        {
            if (isSquare())
            {
                var Line = GetLine(this.A, this.B);
                return Math.Pow(Line, 2);
            }
            return null;
        }
        /// <summary>
        /// Получение периметра
        /// </summary>
        /// <returns></returns>
        public double? getPerimeter()
        {
            if (isSquare())
            {
                var Line = GetLine(this.A, this.B);
                return 4 * Line;
            }
            return null;
        }
        /// <summary>
        /// Получение координат
        /// </summary>
        /// <returns></returns>
        public List<Point> getCoord()
        {
            if(this.A == null || this.B == null || this.C == null || this.D == null)
            {
                throw new ArgumentException("Argument not found");
            }
            return new List<Point>
            {
                A,
                B,
                C,
                D
            };
        }
        /// <summary>
        /// Получение координат в виде текста
        /// </summary>
        /// <returns></returns>
        public string getTextCoord()
        {
            var coord = getCoord();
            return $"A({coord[0].x};{coord[0].y})," +
                   $"B({coord[1].x};{coord[1].y})," +
                   $"C({coord[2].x};{coord[2].y})," +
                   $"D({coord[3].x};{coord[3].y})";
        }
        /// <summary>
        /// Здвиг квадрата
        /// </summary>
        /// <param name="vector"></param>
        public void moveAround(Vector vector)
        {
            if (isSquare())
            {
                if(vector.P1 != null && vector.P2 != null)
                {
                    var x = vector.P2.x - vector.P1.x;
                    var y = vector.P2.y - vector.P1.y;
                    this.A = moveTo(this.A, x, y);
                    this.B = moveTo(this.B, x, y);
                    this.C = moveTo(this.C, x, y);
                    this.D = moveTo(this.D, x, y);
                }
            }
        }
        private double GetLine(Point p1,Point p2)
        {
            if(p1 == null || p2 == null)
            {
                throw new ArgumentException("Argument not found");
            }
            return Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
        }
        /// <summary>
        /// Проверка на квадрат 
        /// </summary>
        /// <returns></returns>
        private bool isSquare()
        {
            var AB = GetLine(A, B);
            var CD = GetLine(C, D);
            var BC = GetLine(B, C);
            var AD = GetLine(A, D);

            if (AB == BC && AB == CD && AB == AD) return true;
            return false;
        }

        private Point moveTo(Point p, int x, int y)
        {
            return new Point
            {
                x = p.x + x,
                y = p.y + y
            };
        }
    }
}
