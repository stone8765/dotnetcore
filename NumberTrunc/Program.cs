using System;
using System.Text.RegularExpressions;

namespace NumberTrunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Trunc(11.555, 1) should be 11.5, actual: { Trunc(11.555, 1) }");
            Console.WriteLine($" Math.Round(11.555, 1) should be 11.6, actual: { Math.Round(11.555, 1) }");

            Console.WriteLine($" Trunc(11.544, 1) should be 11.5, actual: { Trunc(11.544, 1) }");
            Console.WriteLine($" Math.Round(11.544, 1) should be 11.5, actual: { Math.Round(11.544, 1) }");

            Helper.Run(delegate ()
            {
                method1();
            }, 1000000, " 1.先乘后除，再强制类型转换");

            Helper.Run(delegate ()
            {
                method2();
            }, 1000000, " 2.先乘然后使用math.floor，然后除");

            Helper.Run(delegate ()
            {
                method3();
            }, 1000000, " 3.使用正则来处理字符串数据，然后再类型转换 ");

            Helper.Run(delegate ()
            {
                method4();
            }, 1000000, " 4.使用substring截取字符串，然后转换");

            Helper.Run(delegate ()
            {
                method5();
            }, 1000000, " 5.直接先在最后一位上减0.5，然后Round");


            Console.Read();


        }

        const double num = 15.1257;

        static void method1()
        {
            var tmp = (int)(num * 100) / 100.00;
        }
        static void method2()
        {
            var tmp = Math.Floor(num * 100) / 100.00;
        }

        static void method3()
        {
            var tmp = double.Parse(Regex.Match(num.ToString(), @"[\d]+.[\d]{0,2}").Value);
        }

        static void method4()
        {
            var str = (num).ToString();
            var tmp = double.Parse(str.Substring(0, str.IndexOf('.') + 3));
        }

        static void method5()
        {
            var tmp = Trunc(num, 2);
        }

        static double Trunc(double number, int digits)
        {
            if (digits < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(digits));
            }
            // 如果这个数传进来可以少一半的计算时间
            var counteract = 0.5 / (double)Math.Pow(10, digits); 
            return Math.Round(number - counteract, digits);
        }
    }

    public static class Helper
    {
        public static void Run(Action action, int stepTotal = 10000, string description = "")
        {
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < stepTotal; i++)
            {
                action();
            }
            DateTime endTime = DateTime.Now;
            var ts = endTime - startTime;
            Console.WriteLine(description + "_运行“" + stepTotal.ToString() + "”次耗时：" + (endTime - startTime).TotalMilliseconds.ToString("0.0000") + "ms");
        }
    }
}
