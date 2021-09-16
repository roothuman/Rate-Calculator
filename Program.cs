using System;

namespace Week_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          
            try
            {
                Console.WriteLine("Enter Price");
                var price = double.Parse(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("\nEnter Volume");
                var volume =double.Parse( Console.ReadLine() ?? string.Empty);

                while (true)
                {

                    if (volume <= 0)
                    {
                        Console.WriteLine("\nVolume can only be greater than zero");
                        Console.WriteLine("\nEnter valid volume or press 'q' to quit");

                        var input = Console.ReadLine();
                        if (input == "q")
                        {
                            Console.WriteLine("\n**ENDED**");
                            break;
                        }
                        
                        volume = double.Parse(input ?? string.Empty);
                    }

                    else
                    {
                        var r = new Calculate();

                        var rate = r.CalculateRate(price, volume);

                        Console.WriteLine($"\nThe Rate is: {rate:N5}");
                        break;
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("\nInvalid Input");
            }
        }
    }
}