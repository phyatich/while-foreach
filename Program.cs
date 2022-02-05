using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Bir sayı giriniz: ");
            // int num = int.Parse(Console.ReadLine());
            // int counter = 1;
            // int sum = 0;
            // while (counter <= num)
            // {
            //     sum += counter;
            //     counter++;
            // }

            // Console.WriteLine(sum / num);

            // char character = 'a';
            // while (character <= 'z')
            // {
            //     Console.Write(character);
            //     character++;
            // }
            // Console.WriteLine();

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
