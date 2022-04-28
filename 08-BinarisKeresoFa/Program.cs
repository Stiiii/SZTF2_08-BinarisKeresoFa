using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BinarisKeresoFa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Test 'number' is only node ..\n{BinaryExpressionTree.Build("7").ToString()}\t\t={BinaryExpressionTree.Build("7").Convert()}\t\t={BinaryExpressionTree.Build("7").Evaluate()}\n");
                Console.WriteLine($"Test 'simple' operators\n{BinaryExpressionTree.Build("28+").ToString()}\t\t={BinaryExpressionTree.Build("28+").Convert()}\t\t={BinaryExpressionTree.Build("28+").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("28-").ToString()}\t\t={ BinaryExpressionTree.Build("28-").Convert()}\t\t={ BinaryExpressionTree.Build("28-").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("28*").ToString()}\t\t={ BinaryExpressionTree.Build("28*").Convert()}\t\t={ BinaryExpressionTree.Build("28*").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("28/").ToString()}\t\t={ BinaryExpressionTree.Build("28/").Convert()}\t\t={ BinaryExpressionTree.Build("28/").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("28^").ToString()}\t\t={ BinaryExpressionTree.Build("28^").Convert()}\t\t={ BinaryExpressionTree.Build("28^").Evaluate()}\n");
                Console.WriteLine($"Test 'example' expressions\n{BinaryExpressionTree.Build("234*+").ToString()}\t\t={BinaryExpressionTree.Build("234*+").Convert()}\t\t={BinaryExpressionTree.Build("234*+").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("23*4+").ToString()}\t\t={ BinaryExpressionTree.Build("23*4+").Convert()}\t\t={ BinaryExpressionTree.Build("23*4+").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("23*45*+").ToString()}\t\t={ BinaryExpressionTree.Build("23*45*+").Convert()}\t\t={ BinaryExpressionTree.Build("23*45*+").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("23+45-/").ToString()}\t\t={ BinaryExpressionTree.Build("23+45-/").Convert()}\t\t={ BinaryExpressionTree.Build("23+45-/").Evaluate()}");
                Console.WriteLine($"{ BinaryExpressionTree.Build("23+4*5+67^8+/").ToString()}\t\t={ BinaryExpressionTree.Build("23+4*5+67^8+/").Convert()}\t\t={ BinaryExpressionTree.Build("23+4*5+67^8+/").Evaluate()}\n");
                Console.WriteLine($"{ BinaryExpressionTree.Build("12-3-A-45").ToString()}\t\t={ BinaryExpressionTree.Build("12-3-A-45").Convert()}\t\t={ BinaryExpressionTree.Build("12-3-A-45").Evaluate()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
