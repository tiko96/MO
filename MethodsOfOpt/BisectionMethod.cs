using System;
using System.Windows.Forms;
using info.lundin.math;

namespace MethodsOfOpt
{
    static class BisectionMethod
    {
        static public int iterations;
        static public string function;
        static public decimal funcResult;
        static public decimal endLeft;
        static public decimal endRight;
        static public int timerValue;
        static public int maxTime;
        static public int elapsedTime;
        static public System.Timers.Timer tm;

        static public decimal BisectionCount(decimal leftTb, decimal rightTb, decimal tolTb, ProgressBar pb, int maxIter, int time)
        {
            elapsedTime = 0;

            maxTime = time;
            tm = new System.Timers.Timer(15);
            tm.AutoReset = true;
            tm.Elapsed += Tm_Elapsed;
            tm.Start();

            pb.Value = 1;
            decimal left = leftTb;
            decimal right = rightTb;
            decimal middle;
            int maxIterations = maxIter;
            if (Math.Sign(F(Convert.ToDouble(left))) == Math.Sign(F(Convert.ToDouble(right))))
            {
                tm.Stop();
                MessageBox.Show("Неверно выбраны границы вычисления");
            }
            else
            {
                while ((right - left) > tolTb)
                {
                    if (iterations >= maxIterations)
                    {
                        tm.Stop();
                        DialogResult dr = MessageBox.Show("Указанная точность за " + iterations + " итераций не достигнута. Продолжить вычисление? Будет добавлено " + maxIter + " итераций.", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            timerValue = 0;
                            break;
                        }
                        if (dr == DialogResult.Yes)
                        {
                            maxIterations += maxIter;
                            pb.Maximum = maxIterations + 1;
                            tm.Start();
                        }
                    }
                    if (timerValue >= maxTime)
                    {
                        tm.Stop();
                        DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + time + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            timerValue = 0;
                            break;
                        }
                        if (dr == DialogResult.Yes)
                        {
                            maxTime += time;
                            tm.Start();
                        }
                    }
                    middle = (left + right) / 2;
                    if (Math.Sign(F(Convert.ToDouble(left))) == Math.Sign(F(Convert.ToDouble(middle))))
                    {
                        left = middle;
                        pb.Value += 1;
                    }
                    else
                    {
                        right = middle;
                        pb.Value += 1;
                    }
                    iterations++;
                }
                funcResult = (decimal)F(Convert.ToDouble(left));
                endLeft = left;
                endRight = right;
                pb.Value = pb.Maximum;
                pb.Visible = false;
                tm.Stop();
                tm.Dispose();
                timerValue = 0;
            }
            return left;
        }

        private static void Tm_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerValue++;
            timerValue += 14;
            elapsedTime = timerValue;
        }

        static public double F(double par)
        {
                ExpressionParser parser = new ExpressionParser();
                parser.Values.Add("x", par);
                return parser.Parse(function);
        }

    }
}
