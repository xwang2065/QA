using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            int[] inputIntegers = new int[3];

            do
            {
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit ");
                Console.WriteLine("**********************************");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        for (int i = 0; i < inputIntegers.Length; i++)
                        {
                            do
                            {
                                Console.Write("Please enter a positive interger for one side of the triangle:\t");
                                if (!int.TryParse(Console.ReadLine(), out inputIntegers[i]) || inputIntegers[i] <= 0)
                                {
                                    Console.WriteLine("Wrong input!");
                                    Console.WriteLine("**********************************");

                                    inputIntegers[i] = -1;
                                }
                            } while (inputIntegers[i] <= 0);
                        }

                        Console.WriteLine("**********************************");
                        Console.WriteLine($"These three integers can form " +
                            $"{TriangleSolver.Analyze(inputIntegers[0], inputIntegers[1], inputIntegers[2])}");
                        Console.WriteLine("**********************************");
                        option = "";
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect input! Please choose again:");
                        break;
                }
            } while (option != "1" && option != "2");

            Console.ReadKey();
        }
    }
}
