using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new HashTable(13);
            string input = Console.ReadLine();
            while (input != ".")
            {
                switch (input)
                {
                    case "A":
                        input = Add(table);
                        break;
                    case "D":
                        input = Console.ReadLine();
                        if (!table.Delete(int.Parse(input)))
                        {
                            Console.WriteLine("I don't deteted you number :(");
                        }
                        break;
                    case "P":
                        table.PrintAllTable();
                        break;
                    case "F":
                        input = Console.ReadLine();
                        if (table.Find(int.Parse(input)))
                        {
                            Console.WriteLine($"This number was found locally {table.x}:{table.y}");
                        }
                        else
                        {
                            Console.WriteLine("I don't found you number :(");
                        }
                        break;
                    default:
                        Console.WriteLine("I don't know this kod :(");
                        break;
                }
                if (input != ".")
                {
                    input = Console.ReadLine();
                }

            }
            table.PrintAllTable();
            Console.ReadKey();
        }
        static string Add(HashTable table)
        {
            string input = Console.ReadLine();
            while (input != ";" && input != ".")
            {
                table.Add(int.Parse(input));
                input = Console.ReadLine();
            }
            return input;
        }

    }


}
