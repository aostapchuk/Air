using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_8_1_lab
{
    // 0) allow unsafe code in build submenu of properties window of project
    class PointerOperation
    {
        // 5) Add public field nullInt as nullable int;
        // add public field noNullInt as int

        int noNullInt;
        int? nullInt = null;

        // 1) Add parameter(-s) to method ConvertToByte().
        // Parameter(-s) - number(-s) to convert
        public void ConvertToByte(int number)
        {
            // 2) Convert number to poiter to byte type
            unsafe
            {
                // Convert to byte:
                //int* n = &number;
                //int a = (int)n;
                //byte b = (byte)n;
                //Console.WriteLine($"Int {a}");

                //Console.WriteLine($"Byte {b}");
                //byte* p = (byte*)n;

                //// 3) Display all bytes of number with poiter
                //// use loop and sizeof(type)
                //// increment the poiter

                //System.Console.Write("The  bytes of the integer:");
                //// Display the  bytes of the int variable:
                //for (int i = 0; i < sizeof(int); ++i)
                //{
                //    System.Console.Write(" {0:X2}", *p);
                //    // Increment the pointer:
                //    p++;
                //}
                //System.Console.WriteLine();
                //System.Console.WriteLine("The value of the integer: {0}", number);

                // Note: don't forget to use unsafe
            }
        }



        unsafe public int* Power(int* p_pow, int* p_a)
        {
            int aInit = *p_a;
            int a = *p_a;
            int* p_aInit = &aInit;
            int* p_pwr = &a;
            if (*p_pow <= 0)
                throw new ArgumentException(String.Format("Power {0} <= 0 ", *p_pow),
                                          "pow");
            //cycle i=1 to pow mltply = a; mltply = mltply*a; return multply
            for (int i = 1; i < *p_pow; i++)
            {
                int mltpl = 0;
                int* p_mltpl = &mltpl; //pointer to 0

                for (int j = 0; j < *p_aInit; j++)                //  a = pwr * a      by "+"               
                    *p_mltpl = *p_mltpl + *p_pwr;

                *p_pwr = *p_mltpl;
            }
            return p_pwr;
        }


        public void Nullable()
        {
            // 6) use operator ?? to set default value for noNullInt for nullable nullInt
            // in case of nullable nillInt, set noNullInt in 0

            noNullInt = nullInt ?? 0;
            Console.WriteLine("null -> {0}", noNullInt);
            nullInt = 33;
            noNullInt = nullInt ?? 0;
            Console.WriteLine("33 -> {0}", noNullInt);
        }
    }
}
