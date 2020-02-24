using System;
using System.Windows.Forms;

namespace BuildGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // Считываем с формы требуемые значения
            var Xmin = (double)nudMin.Value;
            var Xmax = (double)nudMax.Value;
            var Step = (double)nudStep.Value;
            var q = (double)nudQ.Value;

            // Количество точек графика
            var count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

            // Массив значений X
            var x = new double[count];

            // Массив значений Y
            var y = new double[count];

            // Расчитываем точки для графиков функции
            for (var i = 0; i < count; i++)
            {
                // Вычисляем значение X
                x[i] = Xmin + Step * i;

                // Вычисляем значение функций в точке X
                if (rbShX.Checked)
                    y[i] = GetVal(Sh(x[i]), x[i], q);
                else if (rbSqrX.Checked)
                    y[i] = GetVal(x[i]*x[i], x[i], q);
                else if (rbExpX.Checked)
                    y[i] = GetVal(Math.Exp(x[i]), x[i], q);
            }

            // Настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            // Определяем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            // Добавляем вычисленные значения в графики
            chart1.Series[0].Points.DataBindXY(x, y);
        }

        private double GetVal(double f, double x, double q)
        {
            if (Math.Abs(x * q) > 10.0)
                return Math.Log(Math.Abs(f) + Math.Abs(q));
            if (Math.Abs(x * q) < 10.0)
                return Math.Exp(f + q);
            // if (Math.Abs(x * q) == 10.0)
            return f + q;
        }

        //Гиперболический синус
        public double Sh(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2.0;
        }
    }


}
