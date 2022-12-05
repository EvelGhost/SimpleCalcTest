using System;
using System.Data;
namespace SimpleCalcTest
{
    class Program
    {
        private static void Main()
        {
            Console.Title = "SimpleCalcTest";
            Console.WriteLine("(Enter cos,sin,tg,ctg,sqrt,round,log,tenLog,ToSqrt,ToCube and number after it to do this\nEnter pi or e to get this constants\n!You can't use them in math line!)\n----------------------------\nEnter your math line:");
            string someVar = Console.ReadLine();
            if (someVar.StartsWith("cos"))
            {
                Console.WriteLine($"Answer: {Math.Cos(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("sin"))
            {
                Console.WriteLine($"Answer: {Math.Sin(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("tg"))
            {
                Console.WriteLine($"Answer: {Math.Tan(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("ctg"))
            {
                Console.WriteLine($"Answer: {1 / Math.Tan(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("sqrt"))
            {
                Console.WriteLine($"Answer: {Math.Sqrt(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("round"))
            {
                Console.WriteLine($"Answer: {Math.Round(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("log"))
            {
                Console.WriteLine($"Answer: {Math.Log(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("tenLog"))
            {
                Console.WriteLine($"Answer: {Math.Log10(Convert.ToDouble(someVar.Split(' ')[1]))}");
            }
            else if (someVar.StartsWith("ToSqrt"))
            {
                Console.WriteLine($"Answer: {Math.Pow(Convert.ToDouble(someVar.Split(' ')[1]), 2)}");
            }
            else if (someVar.StartsWith("ToCube"))
            {
                Console.WriteLine($"Answer: {Math.Pow(Convert.ToDouble(someVar.Split(' ')[1]), 3)}");
            }
            else if (someVar == "pi")
            {
                Console.WriteLine($"pi = {Math.PI}");
            }
            else if (someVar == "e")
            {
                Console.WriteLine($"e = {Math.E}");
            }
            else
            {
                Console.WriteLine($"Answer: {new DataTable().Compute(someVar, null)}");

            }
            Console.WriteLine("----------------------------\nSource on Github:\n\n----------------------------");
            Console.WriteLine("Press [Enter] to continue...");
            Console.ReadKey();
        }
    }
}
