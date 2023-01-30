using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededler siyahisindaki en boyuk ededi tapan proqram


            Console.WriteLine("Eddelerin sayini daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);


            int[] numbers = new int[count];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. ededi daxil edin:");
                string numStr = Console.ReadLine();
                int num = Convert.ToInt32(numStr);

                numbers[i] = num;
            }



            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"Siyahidaki en boyuk eded: {max}");

            
            string name = "Hikmet";
            string newName = "";

            Console.WriteLine(newName);

            for (int i = 0; i < name.Length; i++)
            {
                newName += name[i];
            }

            Console.WriteLine(newName);


            Console.WriteLine("Yazi daxil edin");
            string input = Console.ReadLine();

            string reverseInput = "";

            for(int i = input.Length-1; i>=0; i--)
            {
                reverseInput += input[i];
            }


            Console.WriteLine(reverseInput);



        }
    }
}
