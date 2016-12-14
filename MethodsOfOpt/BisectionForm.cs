using System;
using System.Windows.Forms;
using info.lundin.math;
using System.Globalization;

namespace testing_project
{
    public partial class BisectionForm : Form
    {


        public BisectionForm()
        {
            InitializeComponent();


        }



        private void runButton_Click(object sender, EventArgs e)
        {
                if (leftTextBox.Text == "" || rightTextBox.Text == "" || tolerTextBox.Text == "" || maxIterTextBox.Text == "")
                {
                    MessageBox.Show("Не все данные введены!");
                }
                else
                {
                    try
                    {
                        resultTextBox.Text = "";
                        functionResultTextBox.Text = "";
                        toler2TextBox.Text = "";
                        iterationsTextBox.Text = "";
                        progressBar1.Value = 0;
                        elapsedTimeTextBox.Text = "";
                        label13.Text = "";
                        decimal left = Decimal.Parse(leftTextBox.Text);
                        decimal right = Decimal.Parse(rightTextBox.Text);
                        decimal toler = Decimal.Parse(tolerTextBox.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                        int iter = Int32.Parse(maxIterTextBox.Text);
                        int time = Int32.Parse(timeTextBox.Text);

                        int elTime;
                        decimal result;
                        decimal y;
                        decimal toler2;

                        progressBar1.Visible = true;
                        progressBar1.Maximum = iter + 1;
                        BisectionMethod.iterations = 0;
                        BisectionMethod.function = functionTextBox.Text;
                        result = BisectionMethod.BisectionCount(left, right, toler, progressBar1, iter, time);
                        y = Math.Round(BisectionMethod.funcResult, 28);
                        toler2 = (BisectionMethod.endRight - BisectionMethod.endLeft);
                        iter = BisectionMethod.iterations;
                        elTime = BisectionMethod.elapsedTime;
                        resultTextBox.Text = result.ToString();
                        functionResultTextBox.Text = y.ToString();
                        toler2TextBox.Text = toler2.ToString("0e0");
                        iterationsTextBox.Text = iter.ToString();
                        elapsedTimeTextBox.Text = elTime.ToString();
                        if (toler2 != toler)
                        {
                            label13.Text = "Результат с заданной точностью не достигнут!";
                        }
                        if (iter == 0)
                        {
                            label13.Text = "Ошибка";
                            resultTextBox.Text = "";
                            functionResultTextBox.Text = "";
                            toler2TextBox.Text = "";
                            iterationsTextBox.Text = "";
                            progressBar1.Value = 0;
                            elapsedTimeTextBox.Text = "";
                        }
                    }
                    catch (ParserException ex)
                    {
                        BisectionMethod.tm.Stop();
                        MessageBox.Show("Неверно введена функция!");
                        progressBar1.Visible = false;
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Неверно введены начальные значения!");
                    }
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            functionResultTextBox.Text = "";
            toler2TextBox.Text = "";
            iterationsTextBox.Text = "";
            progressBar1.Value = 0;
            elapsedTimeTextBox.Text = "";
            label13.Text = "";
        }

        private void leftTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (leftTextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                if (leftTextBox.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void rightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (rightTextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == '-')
            {
                if (rightTextBox.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void maxTolTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (maxIterTextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void tolerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == 'e')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (maxIterTextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }
    }
}
