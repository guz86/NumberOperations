using System;
using System.Globalization;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // конвертация строки parse tryperse
            // разделитель дробных чисел

            // string str = "5.5";
            // double a = double.Parse(str);

            string str = "5.5";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = double.Parse(str, numberFormatInfo);
            



        }
    }
}
