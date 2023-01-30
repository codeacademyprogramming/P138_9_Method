using System;

namespace Lesson
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ShowSum(10, 44);

            var result = Sum(10, 45, 45);

            Console.WriteLine(result);

            var reverse = Reverse("Salam");

            Console.WriteLine(reverse);

            var digitsSum = SumOfDigits(203);

            Console.WriteLine(digitsSum);

            int[] numbers = { 34, 12, 43, 230 };

            var sumOfArr = Sum(numbers);

            Console.WriteLine(sumOfArr);


            Console.WriteLine("eded1");
            string num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            Console.WriteLine("eded2");
            string num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);


            var r = Hasil(num1,num2);


            Console.WriteLine(r);

            r = Calc(10, 2, '+');

            Console.WriteLine(r);

            //iki integer ve bir char gonderilir. Chara esasen ededler uerinde riyazi emeliyyat aparilir

        }

        static int Calc(int num1,int num2,char cr)
        {

            if (cr == '-')
            {
                return num1 - num2;
            }
            else if(cr == '+')
            {
                return num1 + num2;
            }
            else if(cr == '*')
            {
                return num1 * num2;
            }
            else if(cr == '/')
            {
                return num1 / num2;
            }

            return 0;
        }

        static void ShowSum(int num1,int num2)
        {
            var result = num1 + num2;
            Console.WriteLine(result);
        }

        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        static int Sum(int num1,int num2)
        {
            var result = num1 + num2;
            return result;
        }

        static int Sum(int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        static int Sum(int x,int y,int z)
        {
            var result = x + y+z;
            return result;
        }

        static string Reverse(string str)
        {
            string newStr = "";

            for (int i = str.Length-1;  i>=0; i--)
            {
                newStr += str[i];
            }

            return newStr;
        }

        static int Hasil(int num1,int num2)
        {
            var result = num1 * num2;

            return result;
        }







    }
}
