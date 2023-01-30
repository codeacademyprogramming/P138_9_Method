using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin rəqəmləri cəmini tapan proqram
            //string numstr = Console.ReadLine();
            //int num = Convert.ToInt32(numstr);
            //int sum = 0;

            //while (num>0)
            //{
            //    sum += num % 10;
            //    //num = (num - num % 10) / 10;
            //    num /= 10;
            //}
            //Console.WriteLine(sum);


            ////task2
            //int number;
             
            //do
            //{
            //     var input = Console.ReadLine();
            //     number = Convert.ToInt32(input);
            //}
            //while (number < 0 || number > 100);

            
            //if(number>64)
            //{
            //    Console.WriteLine("mezun oldu");
            //}
            //else
            //{
            //    Console.WriteLine("mezun olmadiniz");
            //}




            //Verilmiş ədədlər siyahısındaki 21-ə bölunən ədədlərin ədədi ortasını tapan proqram

            int[] numbers = new int[6] { 41, 121, 3, 12, 53, 61 };
            int sum = 0;
            int count = 0;
            int result = 0;


            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 21 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }


            if (count == 0)
            {
                Console.WriteLine("Bole bilmirem(");
            }
            else {
                result = sum / count;
                Console.WriteLine(result);
            }
            





        }
    }
}
