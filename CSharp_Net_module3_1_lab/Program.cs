using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_8_1_lab
{
    // 0) allow unsafe code in build submenu of properties window of project
    class Program
    {

      

        static void Main(string[] args)
        {
            // 7) Declare variables for parameters, set some value
            // declare object of class PointerOperator
            int number = 1024;
            PointerOperation pOpers = new PointerOperation();
            pOpers.ConvertToByte(number);

            //8) invoke all methods
            // use declared variables as parameters of methods
            try
            {
                int a = 3;
                int pow = 3;
                int apow;
                unsafe
                {
                    apow = *pOpers.Power(&pow, &a);
                }
                Console.WriteLine();
                Console.WriteLine("{1} raised to a power {2} = {0}", apow, a, pow);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
            }

                Console.WriteLine();
            pOpers.Nullable();
            // Keep the console window open in debug mode
            Console.ReadKey();
        }
    }
}
