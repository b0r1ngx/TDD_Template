using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            ModuleTest moduleTest = new();
            System.Console.WriteLine(
                moduleTest.tooMuchNumbersAfterDotTest()
            );
        }
    }
}
