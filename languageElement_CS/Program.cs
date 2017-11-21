using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace languageElement_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            //for Loop       
//*******************************************************************************************************
            //#region Loops;

            //for (int a = 10; a <=20; a++ )
            //{
            //    Console.WriteLine("value of a: {0}", a);
            //}
            //Console.ReadLine();

            //_OR >>

            //for(int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine(counter);

            //}
            //Console.WriteLine("Press any key....");
            //Console.ReadKey();

            //#endregion
//**********************************************************************************************************
            //foreach loop

            //#region Loops;

            //int[] list = new int[] { 5, 45, 7, 12, 37, 3, 9, };
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //#endregion;
//***********************************************************************************************************
            //while loop

            //#region Loops;

            //int number = 0;
            //while (number < 10)
            //{
              //  Console.WriteLine(number);
                //number++;
            //}
            //Console.ReadKey();

            //#endregion;
//************************************************************************************************************
            //do while loop

            #region Loops;

            int number = 0;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number < 100);

            Console.ReadKey();

            #endregion;

        }
    }
}
