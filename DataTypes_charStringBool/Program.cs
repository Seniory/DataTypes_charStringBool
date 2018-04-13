using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_charStringBool
{
    class Program
    {
        static void Main(string[] args)
        {
            int CharMin = Char.MinValue;
            int CharMax = char.MaxValue;

            //تصريح عن متغير وتحويل قيمته لرقم
            char MyVarvalue2 = Convert.ToChar(90);
            //متغير يأخذ قيمة المتغيرالمحوله إلى أحرف ويحولها إلى قيمتها الرقمية
            int VarValue = MyVarvalue2;
            Boolean TrueFalse = true;
            Console.WriteLine("\nMin Char = {0} \nMax Char = {1}\nMy Variable Number={2} \nMy Conversion Value is = {3}",
                CharMin, CharMax, VarValue ,MyVarvalue2);
            Console.ReadKey();
            Console.WriteLine("Is it True what I've heared.......?     {0}", TrueFalse);
            Console.ReadKey();
            String myString = "This is my string";
            Console.WriteLine("\nMy String is {0}", myString);
            Console.ReadKey();




        }
    }
}
