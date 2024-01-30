namespace ArrayÜbung
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            string[] names = new string[5];

           
            int[] numbers = new int[5];

           
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();

                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            Console.WriteLine("\nEntered names and numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Name {i + 1}: {names[i]}, Number {i + 1}: {numbers[i]}");
            }
        }
    }
}