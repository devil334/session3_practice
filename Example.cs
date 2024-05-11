using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session3_practice
{
    class Example
    {
        public readonly int ReadOnlyField;

        public Example(int value)
        {
            ReadOnlyField = value;
        }

        public void ModifyValue(int newValue)
        {
            //ReadOnlyField = newValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("Readonly Field Value: " + ReadOnlyField);
        }
        /*static void Main(string[] args)
        {
            Example example = new Example(10);
            example.PrintValue();

            example.ModifyValue(20);
            example.PrintValue();
        }*/
    }

}
