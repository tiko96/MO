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

        static public double F(double par)
        {
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("x", par);
            return parser.Parse(function);
        }

    }
}
