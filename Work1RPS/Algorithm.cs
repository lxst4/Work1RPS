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
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Запретить открытие на полный экран
            MaximizeBox = false;
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

        private void Btn_SaveOriginal_Click(object sender, EventArgs e)
        {
            Btn_SaveOriginal.Enabled = false;
            string originalValuesAsString = "0"; 

            try
            {
                bool check = AlgorithmFunc.GetCheck(pointAx1, pointAy1,
                                                    pointBx2, pointBy2,
                                                    pointCx3, pointCy3,
                                                    pointDx4, pointDy4);

                if (check)
                {
                    decimal x1 = decimal.Parse(pointAx1.Text);
                    decimal y1 = decimal.Parse(pointAy1.Text);
                    decimal x2 = decimal.Parse(pointBx2.Text);
                    decimal y2 = decimal.Parse(pointBy2.Text);
                    decimal x3 = decimal.Parse(pointCx3.Text);
                    decimal y3 = decimal.Parse(pointCy3.Text);
                    decimal x4 = decimal.Parse(pointDx4.Text);
                    decimal y4 = decimal.Parse(pointDy4.Text);

                    originalValuesAsString = x1 + Environment.NewLine
                                             + y1 + Environment.NewLine
                                             + x2 + Environment.NewLine
                                             + y2 + Environment.NewLine
                                             + x3 + Environment.NewLine
                                             + y3 + Environment.NewLine
                                             + x4 + Environment.NewLine
                                             + y4;
                            

                    // Диалог выбора места сохранения файла
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Получение пути к выбранному файлу
                        string file_path = saveFileDialog.FileName;

                        // Запись данных в файл
                        File.WriteAllText(file_path, originalValuesAsString);
                        MessageBox.Show($"Данные успешно сохранены в файл {file_path}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FormatException)
            {
                // Вывод сообщения об ошибке при некорректном вводе
                MessageBox.Show("Ошибка ввода. Пожалуйста, убедитесь, что вводимые данные корректны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Btn_SaveOriginal.Enabled = true;
        }

        private void Btn_SaveResult_Click(object sender, EventArgs e)
        {
            Btn_SaveResult.Enabled = false;
            string originalValuesAsString = "0";

            try
            {
                bool check = AlgorithmFunc.GetCheck(pointAx1, pointAy1,
                                                    pointBx2, pointBy2,
                                                    pointCx3, pointCy3,
                                                    pointDx4, pointDy4);

                if (check)
                {
                    decimal x1 = decimal.Parse(pointAx1.Text);
                    decimal y1 = decimal.Parse(pointAy1.Text);
                    decimal x2 = decimal.Parse(pointBx2.Text);
                    decimal y2 = decimal.Parse(pointBy2.Text);
                    decimal x3 = decimal.Parse(pointCx3.Text);
                    decimal y3 = decimal.Parse(pointCy3.Text);
                    decimal x4 = decimal.Parse(pointDx4.Text);
                    decimal y4 = decimal.Parse(pointDy4.Text);

                    result_label.Text = AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                     ref x3, ref y3, ref x4, ref y4);

                    originalValuesAsString =  "Исходные значения:" + Environment.NewLine
                                             + "x1: " + x1 + Environment.NewLine
                                             + "y1: " + y1 + Environment.NewLine
                                             + "x2: " + x2 + Environment.NewLine
                                             + "y2: " + y2 + Environment.NewLine
                                             + "x3: " + x3 + Environment.NewLine
                                             + "y3: " + y3 + Environment.NewLine
                                             + "x4: " + x4 + Environment.NewLine
                                             + "y4: " + y4 + Environment.NewLine
                                             + "Результат: " + result_label.Text;

                    // Диалог выбора места сохранения файла
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Получение пути к выбранному файлу
                        string file_path = saveFileDialog.FileName;

                        // Запись данных в файл
                        File.WriteAllText(file_path, originalValuesAsString);
                        MessageBox.Show($"Данные успешно сохранены в файл {file_path}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FormatException)
            {
                // Вывод сообщения об ошибке при некорректном вводе
                MessageBox.Show("Ошибка ввода. Пожалуйста, убедитесь, что вводимые данные корректны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Btn_SaveResult.Enabled = true;
        }

        private void result_label_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GetFromFile_Click(object sender, EventArgs e)
        {
            Btn_GetFromFile.Enabled = false;

            // Диалог выбора файла
            OpenFileDialog file_open_dialog = new OpenFileDialog();
            file_open_dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            file_open_dialog.FilterIndex = 1;
            file_open_dialog.RestoreDirectory = true;

            if (file_open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Чтение данных из файла
                    string file_path = file_open_dialog.FileName;
                    string initial_data = File.ReadAllText(file_path);

                    // Разделение строк
                    string[] lines = initial_data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    // Присвоение значений переменным
                    if (lines.Length >= 7)
                    {
                        string x1 = lines[0];
                        string y1 = lines[1];
                        string x2 = lines[2];
                        string y2 = lines[3];
                        string x3 = lines[4];
                        string y3 = lines[5];
                        string x4 = lines[6];
                        string y4 = lines[7];

                        pointAx1.Text = x1;
                        pointAy1.Text = y1;
                        pointBx2.Text = x2;
                        pointBy2.Text = y2;
                        pointCx3.Text = x3;
                        pointCy3.Text = y3;
                        pointDx4.Text = x4;
                        pointDy4.Text = y4;

                        MessageBox.Show($"Данные успешно загружены из файла {file_path}", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Btn_GetFromFile.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_GetResult_Click(object sender, EventArgs e)
        {
            bool check = AlgorithmFunc.GetCheck(pointAx1, pointAy1,
                                                pointBx2, pointBy2,
                                                pointCx3, pointCy3,
                                                pointDx4, pointDy4);

            if (check)
            {
                decimal x1 = decimal.Parse(pointAx1.Text);
                decimal y1 = decimal.Parse(pointAy1.Text);
                decimal x2 = decimal.Parse(pointBx2.Text);
                decimal y2 = decimal.Parse(pointBy2.Text);
                decimal x3 = decimal.Parse(pointCx3.Text);
                decimal y3 = decimal.Parse(pointCy3.Text);
                decimal x4 = decimal.Parse(pointDx4.Text);
                decimal y4 = decimal.Parse(pointDy4.Text);

                result_label.Text = AlgorithmFunc.StartAlgorithm(ref x1, ref y1, ref x2, ref y2,
                                                                 ref x3, ref y3, ref x4, ref y4);
            }
        }

        private void pointAy1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
