using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work1RPS
{
    public partial class Algorithm : Form
    {
        public Algorithm()
        {
            InitializeComponent();
            MessageBox.Show(AlgorithmFunc.GetHello(), "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pointAx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointAy1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointBx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointBy2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointCx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointDx4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointDy4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Bth_SaveOriginal_Click(object sender, EventArgs e)
        {

        }

        private void Bth_SaveResult_Click(object sender, EventArgs e)
        {

        }

        private void result_label_Click(object sender, EventArgs e)
        {

        }

        private void Bth_GetFromFile_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bth_GetResult_Click(object sender, EventArgs e)
        {
            bool all_good = true;

            if (!decimal.TryParse(pointAx1.Text, out decimal x1))
            {
                MessageBox.Show("Введено некорректное значение x1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }
            else
            {
                Console.WriteLine
                    (Environment.NewLine +
                     "x1 = " + x1 + Environment.NewLine);
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
                    "Координаты начала и конца отрезка 1 совпадают, вы ввели точку, а не отрезок.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                all_good = false;
            }

            if (all_good)
            {
                result_label.Text = AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                 ref x3, ref y3, ref x4, ref y4);
            }
        }

        private void pointAy1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
