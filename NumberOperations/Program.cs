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
            /*
            string str = "5.5";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = double.Parse(str, numberFormatInfo);
            */

            string str = "5,4asd";

            
            try
            {
                double a = double.Parse(str);
                Console.WriteLine("Успешная конвертация.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка конвертации.");

            }

        }
    }
}
