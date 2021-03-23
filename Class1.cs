using System;


namespace Library
{
    public class Geometry
    {
        /// <summary>
        /// Метод принимает на вход радиус окружности и возвращает её площадь
        /// </summary>
        /// <param name="r">радиус окружности в метрах</param>
        /// <returns></returns>
        public static double CircleSquare(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /// <summary>
        /// Метод возвращает площадь треугольника по трём сторонам.
        /// </summary>
        /// <param name="a">длина первой стороны в метрах</param>
        /// <param name="b">длина второй стороны в метрах</param>
        /// <param name="c">длина третьей стороны в метрах</param>
        /// <returns></returns>
        public static double TriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
