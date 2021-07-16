using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViveroPrueba2
{
    class Optimize
    {

        public static int ValInt()
        {
            int number = 0;
            while (number == 0)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Digite un numero");
                }
            }
            return number;
        }
        public static string ValString()
        {
            string text = "";
            while (text == "")
            {
                try
                {
                    text = Console.ReadLine();
                    text = text.ToUpper();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Ingrese algun caracter");
                }
            }
            return text;
        }
    }
}
