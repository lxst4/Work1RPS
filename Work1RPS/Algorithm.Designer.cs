namespace Work1RPS
{
    partial class Algorithm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pointAx1 = new TextBox();
            pointDx4 = new TextBox();
            pointCx3 = new TextBox();
            pointBx2 = new TextBox();
            Btn_GetResult = new Button();
            Btn_SaveOriginal = new Button();
            Btn_SaveResult = new Button();
            Btn_GetFromFile = new Button();
            result_label = new Label();
            pointAy1 = new TextBox();
            pointDy4 = new TextBox();
            pointCy3 = new TextBox();
            pointBy2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(380, 37);
            label1.TabIndex = 0;
            label1.Text = "Найти пересечение отрезков";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Прямая 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(248, 32);
            label3.TabIndex = 2;
            label3.Text = "Координаты точки A:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(13, 171);
            label4.Name = "label4";
            label4.Size = new Size(247, 32);
            label4.TabIndex = 3;
            label4.Text = "Координаты точки B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 4;
            label5.Text = "Прямая 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(12, 266);
            label6.Name = "label6";
            label6.Size = new Size(248, 32);
            label6.TabIndex = 5;
            label6.Text = "Координаты точки C:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(12, 311);
            label7.Name = "label7";
            label7.Size = new Size(250, 32);
            label7.TabIndex = 6;
            label7.Text = "Координаты точки D:";
            label7.Click += label7_Click;
            // 
            // pointAx1
            // 
            pointAx1.Font = new Font("Segoe UI", 14F);
            pointAx1.Location = new Point(265, 119);
            pointAx1.Name = "pointAx1";
            pointAx1.Size = new Size(92, 39);
            pointAx1.TabIndex = 7;
            pointAx1.TextChanged += pointAx1_TextChanged;
            // 
            // pointDx4
            // 
            pointDx4.Font = new Font("Segoe UI", 14F);
            pointDx4.Location = new Point(265, 308);
            pointDx4.Name = "pointDx4";
            pointDx4.Size = new Size(92, 39);
            pointDx4.TabIndex = 8;
            pointDx4.TextChanged += pointDx4_TextChanged;
            // 
            // pointCx3
            // 
            pointCx3.Font = new Font("Segoe UI", 14F);
            pointCx3.Location = new Point(266, 263);
            pointCx3.Name = "pointCx3";
            pointCx3.Size = new Size(92, 39);
            pointCx3.TabIndex = 9;
            pointCx3.TextChanged += pointCx3_TextChanged;
            // 
            // pointBx2
            // 
            pointBx2.Font = new Font("Segoe UI", 14F);
            pointBx2.Location = new Point(266, 168);
            pointBx2.Name = "pointBx2";
            pointBx2.Size = new Size(92, 39);
            pointBx2.TabIndex = 10;
            pointBx2.TextChanged += pointBx2_TextChanged;
            // 
            // Btn_GetResult
            // 
            Btn_GetResult.Font = new Font("Segoe UI", 14F);
            Btn_GetResult.Location = new Point(68, 384);
            Btn_GetResult.Name = "Btn_GetResult";
            Btn_GetResult.Size = new Size(194, 50);
            Btn_GetResult.TabIndex = 11;
            Btn_GetResult.Text = "Выполнить";
            Btn_GetResult.UseVisualStyleBackColor = true;
            Btn_GetResult.Click += Btn_GetResult_Click;
            // 
            // Btn_SaveOriginal
            // 
            Btn_SaveOriginal.Font = new Font("Segoe UI", 14F);
            Btn_SaveOriginal.Location = new Point(496, 240);
            Btn_SaveOriginal.Name = "Btn_SaveOriginal";
            Btn_SaveOriginal.Size = new Size(270, 48);
            Btn_SaveOriginal.TabIndex = 12;
            Btn_SaveOriginal.Text = "Сохранить исходные данные";
            Btn_SaveOriginal.UseVisualStyleBackColor = true;
            Btn_SaveOriginal.Click += Btn_SaveOriginal_Click;
            // 
            // Btn_SaveResult
            // 
            Btn_SaveResult.Font = new Font("Segoe UI", 14F);
            Btn_SaveResult.Location = new Point(496, 311);
            Btn_SaveResult.Name = "Btn_SaveResult";
            Btn_SaveResult.Size = new Size(270, 48);
            Btn_SaveResult.TabIndex = 13;
            Btn_SaveResult.Text = "Сохранить результат";
            Btn_SaveResult.UseVisualStyleBackColor = true;
            Btn_SaveResult.Click += Btn_SaveResult_Click;
            // 
            // Btn_GetFromFile
            // 
            Btn_GetFromFile.Font = new Font("Segoe UI", 14F);
            Btn_GetFromFile.Location = new Point(496, 384);
            Btn_GetFromFile.Name = "Btn_GetFromFile";
            Btn_GetFromFile.Size = new Size(270, 48);
            Btn_GetFromFile.TabIndex = 14;
            Btn_GetFromFile.Text = "Ввод данных из файла";
            Btn_GetFromFile.UseVisualStyleBackColor = true;
            Btn_GetFromFile.Click += Btn_GetFromFile_Click;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Font = new Font("Segoe UI", 14F);
            result_label.Location = new Point(535, 119);
            result_label.Name = "result_label";
            result_label.Size = new Size(121, 32);
            result_label.TabIndex = 15;
            result_label.Text = "результат";
            result_label.Click += result_label_Click;
            // 
            // pointAy1
            // 
            pointAy1.Font = new Font("Segoe UI", 14F);
            pointAy1.Location = new Point(382, 119);
            pointAy1.Name = "pointAy1";
            pointAy1.Size = new Size(92, 39);
            pointAy1.TabIndex = 16;
            pointAy1.TextChanged += pointAy1_TextChanged_1;
            // 
            // pointDy4
            // 
            pointDy4.Font = new Font("Segoe UI", 14F);
            pointDy4.Location = new Point(381, 308);
            pointDy4.Name = "pointDy4";
            pointDy4.Size = new Size(92, 39);
            pointDy4.TabIndex = 17;
            pointDy4.TextChanged += pointDy4_TextChanged;
            // 
            // pointCy3
            // 
            pointCy3.Font = new Font("Segoe UI", 14F);
            pointCy3.Location = new Point(381, 263);
            pointCy3.Name = "pointCy3";
            pointCy3.Size = new Size(92, 39);
            pointCy3.TabIndex = 18;
            pointCy3.TextChanged += textBox3_TextChanged;
            // 
            // pointBy2
            // 
            pointBy2.Font = new Font("Segoe UI", 14F);
            pointBy2.Location = new Point(382, 168);
            pointBy2.Name = "pointBy2";
            pointBy2.Size = new Size(92, 39);
            pointBy2.TabIndex = 19;
            pointBy2.TextChanged += pointBy2_TextChanged;
            // 
            // Algorithm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 504);
            Controls.Add(pointBy2);
            Controls.Add(pointCy3);
            Controls.Add(pointDy4);
            Controls.Add(pointAy1);
            Controls.Add(result_label);
            Controls.Add(Btn_GetFromFile);
            Controls.Add(Btn_SaveResult);
            Controls.Add(Btn_SaveOriginal);
            Controls.Add(Btn_GetResult);
            Controls.Add(pointBx2);
            Controls.Add(pointCx3);
            Controls.Add(pointDx4);
            Controls.Add(pointAx1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Algorithm";
            Text = "Algorithm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox pointAx1;
        private TextBox pointDx4;
        private TextBox pointCx3;
        private TextBox pointBx2;
        private Button Btn_GetResult;
        private Button Btn_SaveOriginal;
        private Button Btn_SaveResult;
        private Button Btn_GetFromFile;
        private Label result_label;
        private TextBox pointAy1;
        private TextBox pointDy4;
        private TextBox pointCy3;
        private TextBox pointBy2;
    }
}