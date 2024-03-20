using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1RPS
{
    public class AlgorithmFunc
    {
        public static string GetHello () 
        { 
            string hello = "Егорова Ксения гр.425" + Environment.NewLine + 
            "Контрольная работа номер 1" + Environment.NewLine +
            "Вариант 5" + Environment.NewLine +
            "Нахождение точки пересечения отрезков";
            return hello;
        }
        static void Swap(ref decimal x, ref decimal y)
        {
            decimal tmp = x;
            x = y;
            y = tmp;
        }

        static void SwapAll(ref decimal y1, ref decimal y2, ref decimal y3, ref decimal y4,
                            ref decimal x1, ref decimal x2, ref decimal x3, ref decimal x4)
        {
            if (y1 > y2)
            {
                Swap(ref y1, ref y2);
            }

            if (x1 > x2)
            {
                Swap(ref x1, ref x2);
            }

            if (y3 > y4)
            {
                Swap(ref y3, ref y4);
            }

            if (x3 > x4)
            {
                Swap(ref x3, ref x4);
            }
        }
        public static string StartAlgorithm(ref decimal x1, ref decimal y1, ref decimal x2, ref decimal y2,
                                            ref decimal x3, ref decimal y3, ref decimal x4, ref decimal y4)
        {
            string message = "0";
            //Находим уравнения прямых
            //Первая прямая
            //Вертикальная
            decimal k1 = 0, b1 = 0, xvertical = 0, knovertical = 0, bnovertical = 0;

            if ((x2 - x1) == 0)
            {
                xvertical = x1;
                Console.WriteLine
                (Environment.NewLine +
                 "Уравнение прямой для отрезка 1" + Environment.NewLine +
                 "x = " + x1 + Environment.NewLine);

            }

            //Не вертикальная
            else
            {
                k1 = (y1 - y2) / (x1 - x2);
                b1 = y1 - k1 * x1;
                knovertical = k1;
                bnovertical = b1;
                Console.WriteLine
                (Environment.NewLine +
                 "Уравнение прямой для отрезка 1" + Environment.NewLine +
                 "y = " + Math.Round(k1, 3) + "* x + " + Math.Round(b1, 3) + Environment.NewLine);
            }

            //Вторая прямая
            //Вертикальная
            decimal k2 = 0, b2 = 0;

            if ((x4 - x3) == 0)
            {
                xvertical = x3;
                Console.WriteLine
                (Environment.NewLine +
                "Уравнение прямой для отрезка 2" + Environment.NewLine +
                "x = " + x3 + Environment.NewLine
                );
            }

            //не вертикальная
            else
            {
                k2 = (y3 - y4) / (x3 - x4);
                b2 = y3 - k2 * x3;
                knovertical = k2;
                bnovertical = b2;
                Console.WriteLine
                   (Environment.NewLine +
                   "Уравнение прямой для отрезка 2" + Environment.NewLine +
                   "y = " + Math.Round(k2, 3) + "*x + " + Math.Round(b2, 3) + Environment.NewLine
                   );
            }

            //Отрезки совпадают 
            if (k1 == k2 && b1 == b2)
                message = "Отрезки совпадают.";

            //Отрезки параллельны
            if (k1 == k2 && b1 != b2)
                message = "Отрезки параллельны, точек пересечения нет.";

            //Один отрезок вертикальный, отрезки не параллельны и не совпадают
            decimal xintersection = 0, yintersection = 0;

            if ((k1 == 0 || k2 == 0) && b1 != b2)
            {
                xintersection = xvertical;
                yintersection = knovertical * xintersection + bnovertical;

                SwapAll(ref y1, ref y2, ref y3, ref y4,
                        ref x1, ref x2, ref x3, ref x4);

                if ((y1 <= yintersection && yintersection <= y2) && (y3 <= yintersection && yintersection <= y4)
                      && (x1 <= xintersection && xintersection <= x2) && (x3 <= xintersection && xintersection <= x4))
                {

                    message = "Отрезки пересекаются. " + Environment.NewLine +
                    "Точка пересечения:" + Environment.NewLine +
                    "x = " + Math.Round(xintersection, 3).ToString("0.000") + ", y = " + Math.Round(yintersection, 3).ToString("0.000");
                }

                else
                { message = "Отрезки не пересекаются."; }

            }

            //Отрезки не параллельны и не совпадают
            if (k1 != k2 && b1 != b2)
            {
                xintersection = (b2 - b1) / (k1 - k2);
                yintersection = k1 * xintersection + b1;

                SwapAll(ref y1, ref y2, ref y3, ref y4,
                        ref x1, ref x2, ref x3, ref x4);

                if ((y1 <= yintersection && yintersection <= y2) && (y3 <= yintersection && yintersection <= y4)
                    && (x1 <= xintersection && xintersection <= x2) && (x3 <= xintersection && xintersection <= x4))
                {
                    message = "Отрезки пересекаются." + Environment.NewLine +
                    "Точка пересечения:" + Environment.NewLine +
                    "x = " + Math.Round(xintersection, 3).ToString("0.000") + ", y = " + Math.Round(yintersection, 3).ToString("0.000");
                }

                else
                { message = "Отрезки не пересекаются."; }
            }

            return message;
        }

    }
   
}
