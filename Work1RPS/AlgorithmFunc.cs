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

        const decimal EPS = 1E-9m;

        public struct Point
        {
            public decimal x, y;
        }

        public struct Line
        {
            public decimal a, b, c;

            public Line(Point p, Point q)
            {
                a = p.y - q.y;
                b = q.x - p.x;
                c = -a * p.x - b * p.y;
                Norm();
            }

            private void Norm()
            {
                decimal z = (decimal)Math.Sqrt((double)(a * a + b * b));
                if (Math.Abs(z) > EPS)
                {
                    a /= z;
                    b /= z;
                    c /= z;
                }
            }
        }

        public static decimal Dist(Line l, Point p)
        {
            return l.a * p.x + l.b * p.y + l.c;
        }

        public static bool Intersect(Point a, Point b, Point c, Point d, out Point left, out Point right)
        {
            left = new Point();
            right = new Point();

            if (!Intersect1D(a.x, b.x, c.x, d.x) || !Intersect1D(a.y, b.y, c.y, d.y))
                return false;

            Line m = new Line(a, b);
            Line n = new Line(c, d);

            decimal zn = Det(m.a, m.b, n.a, n.b);
            if (Math.Abs(zn) < EPS)
            {
                if (Math.Abs(Dist(m, c)) > EPS || Math.Abs(Dist(n, a)) > EPS)
                    return false;

                if (b.x < a.x)
                {
                    Point temp = a;
                    a = b;
                    b = temp;
                }

                if (d.x < c.x)
                {
                    Point temp = c;
                    c = d;
                    d = temp;
                }

                left.x = Math.Max(a.x, c.x);
                right.x = Math.Min(b.x, d.x);

                left.y = Math.Max(a.y, c.y);
                right.y = Math.Min(b.y, d.y);

                return true;
            }
            else
            {
                left.x = right.x = -Det(m.c, m.b, n.c, n.b) / zn;
                left.y = right.y = -Det(m.a, m.c, n.a, n.c) / zn;

                return Betw(a.x, b.x, left.x)
                    && Betw(a.y, b.y, left.y)
                    && Betw(c.x, d.x, left.x)
                    && Betw(c.y, d.y, left.y);
            }
        }

        private static bool Betw(decimal l, decimal r, decimal x)
        {
            return Math.Min(l, r) <= x + EPS && x <= Math.Max(l, r) + EPS;
        }

        private static bool Intersect1D(decimal a, decimal b, decimal c, decimal d)
        {
            if (a > b)
            {
                decimal temp = a;
                a = b;
                b = temp;
            }

            if (c > d)
            {
                decimal temp = c;
                c = d;
                d = temp;
            }

            return Math.Max(a, c) <= Math.Min(b, d) + EPS;
        }

        private static decimal Det(decimal a, decimal b, decimal c, decimal d)
        {
            return a * d - b * c;
        }


        public static string StartAlgorithm(ref decimal x1, ref decimal y1, ref decimal x2, ref decimal y2,
                                            ref decimal x3, ref decimal y3, ref decimal x4, ref decimal y4)
        {
            string message;

            Point a = new Point { x = x1, y = y1 };
            Point b = new Point { x = x2, y = y2 };
            Point c = new Point { x = x3, y = y3 };
            Point d = new Point { x = x4, y = y4 };

            Point left, right;
            bool isIntersect = Intersect(a, b, c, d, out left, out right);

            if (isIntersect)
            {
                if (left.x == right.x && left.y == right.y)
                {
                    decimal x_intersection = left.x, y_intersection = left.y;
                    message = 
                        "Отрезки пересекаются." + Environment.NewLine +
                        "Точка пересечения:"    + Environment.NewLine +
                        "x = " + Math.Round(x_intersection, 3).ToString("0.000") + ", y = " + Math.Round(y_intersection, 3).ToString("0.000");
                }
                else
                {
                    decimal x1_overlap = left.x, y1_overlap = left.y,
                            x2_overlap = right.x, y2_overlap = right.y;
                    message = 
                        "Отрезки накладываются друг на друга." + Environment.NewLine +
                        "Точки наложения:" + Environment.NewLine +
                        "x1 = " + Math.Round(x1_overlap, 3).ToString("0.000") + ", y1 = " + Math.Round(y1_overlap, 3).ToString("0.000") + Environment.NewLine +
                        "x2 = " + Math.Round(x2_overlap, 3).ToString("0.000") + ", y2 = " + Math.Round(y2_overlap, 3).ToString("0.000");
                }
            }
            else
            {
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


