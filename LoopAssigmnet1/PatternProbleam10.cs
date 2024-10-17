using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssigmnet1
{
    internal class PatternProbleam10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 pattern Program");

            // Generate your own function to satisfy the relationship between the inputs and outputs.
            //Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
            //Examples
            //832 ➞ 594 
            //51 ➞ 36

            Console.WriteLine("ENter your input");
            int input = Convert.ToInt32(Console.ReadLine());
            //832->594=3+2=5;8+3=9; first digit half=8/2=4
            //51->36=5+1=6;
            //832->594=>8-3=5;8+3=9;out1-op2=9-5=4=>594
        }
    }
}
