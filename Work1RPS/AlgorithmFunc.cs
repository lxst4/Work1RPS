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

            //Отрезки параллельны
            if (k1 == k2 && b1 != b2)
                message = "Отрезки параллельны, точек пересечения нет.";

            //Один отрезок вертикальный, отрезки не параллельны и не накладываются друг на друга
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

            //начальные или конечные точки отрезков совпадают 

            if ((x1 == x3 && y1 == y3) || (x1 == x4 && y1 == y4))
            {
                message = "Отрезки пересекаются." + Environment.NewLine +
                   "Точка пересечения:" + Environment.NewLine +
                   "x = " + Math.Round(x1, 3).ToString("0.000") + ", y = " + Math.Round(y1, 3).ToString("0.000");
            }

            if ((x2 == x3 && y2 == y3) || (x2 == x4 && y2 == y4))
            {
                message = "Отрезки пересекаются." + Environment.NewLine +
                   "Точка пересечения:" + Environment.NewLine +
                   "x = " + Math.Round(x2, 3).ToString("0.000") + ", y = " + Math.Round(y2, 3).ToString("0.000");
            }

            //Прямые накладываются друг на друга 
            if (k1 == k2 && b1 == b2)
            {
                SwapAll(ref y1, ref y2, ref y3, ref y4,
                        ref x1, ref x2, ref x3, ref x4);

                if((x3 <= x2) && (y3 <= y2))
                    message = "Отрезки накладываются друг на друга.";
                else
                    message = "Отрезки не пересекаются.";

            }

            return message;
        }

        public static bool GetCheck(TextBox pointAx1, TextBox pointAy1,
                                    TextBox pointBx2, TextBox pointBy2,
                                    TextBox pointCx3, TextBox pointCy3,
                                    TextBox pointDx4, TextBox pointDy4)
        {
            bool all_good = true;

            if (string.IsNullOrEmpty(pointAx1.Text) ||
                string.IsNullOrEmpty(pointAy1.Text) ||
                string.IsNullOrEmpty(pointBx2.Text) ||
                string.IsNullOrEmpty(pointBy2.Text) ||
                string.IsNullOrEmpty(pointCx3.Text) ||
                string.IsNullOrEmpty(pointCy3.Text) ||
                string.IsNullOrEmpty(pointDx4.Text) ||
                string.IsNullOrEmpty(pointDy4.Text))
            {
                MessageBox.Show("Не все значения были введены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(pointAx1.Text, out decimal x1))
            {
                MessageBox.Show("Введено некорректное значение x1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (!decimal.TryParse(pointAy1.Text, out decimal y1))
            {
                MessageBox.Show("Введено некорректное значение y1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (!decimal.TryParse(pointBx2.Text, out decimal x2))
            {
                MessageBox.Show("Введено некорректное значение x2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (!decimal.TryParse(pointBy2.Text, out decimal y2))
            {
                MessageBox.Show("Введено некорректное значение y2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (!decimal.TryParse(pointCx3.Text, out decimal x3))
            {
                MessageBox.Show("Введено некорректное значение x3", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (!decimal.TryParse(pointCy3.Text, out decimal y3))
            {
                MessageBox.Show("Введено некорректное значение y3", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (!decimal.TryParse(pointDx4.Text, out decimal x4))
            {
                MessageBox.Show("Введено некорректное значение x4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (!decimal.TryParse(pointDy4.Text, out decimal y4))
            {
                MessageBox.Show("Введено некорректное значение y4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }

            if (all_good)
            {
                if (x1 == x2 && y1 == y2)
                {
                    MessageBox.Show(
                        "Координаты начала и конца отрезка 1 совпадают, вы ввели точку, а не отрезок.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                    all_good = false;
                }

                if (x3 == x4 && y3 == y4)
                {
                    MessageBox.Show(
                        "Координаты начала и конца отрезка 2 совпадают, вы ввели точку, а не отрезок.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                    all_good = false;
                }

                if (pointAx1.Text != x1.ToString())
                {
                    pointAx1.Text = x1.ToString();
                    MessageBox.Show("Значение x1 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pointAy1.Text != y1.ToString())
                {
                    pointAy1.Text = y1.ToString();
                    MessageBox.Show("Значение y1 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pointBx2.Text != x2.ToString())
                {
                    pointBx2.Text = x2.ToString();
                    MessageBox.Show("Значение x2 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pointBy2.Text != y2.ToString())
                {
                    pointBy2.Text = y2.ToString();
                    MessageBox.Show("Значение y2 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pointCx3.Text != x3.ToString())
                {
                    pointCx3.Text = x3.ToString();
                    MessageBox.Show("Значение x3 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pointCy3.Text != y3.ToString())
                {
                    pointCy3.Text = y3.ToString();
                    MessageBox.Show("Значение y3 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pointDx4.Text != x4.ToString())
                {
                    pointDx4.Text = x4.ToString();
                    MessageBox.Show("Значение x4 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (pointDy4.Text != y4.ToString())
                {
                    pointDy4.Text = y4.ToString();
                    MessageBox.Show("Значение y4 было исправлено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return all_good;
        }
    }
}


