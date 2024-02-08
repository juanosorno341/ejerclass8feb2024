using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerclass8feb2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el indice");
            int indice = int.Parse(Console.ReadLine());
            int[] dat = new int[indice];
            for (int i = 0; i < dat.Length; i++)
            {
                Console.WriteLine("Entra el dato [" + i + "]");
                dat[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dat.Length; i++)
            {
                Console.WriteLine("\n" + dat[i]);
            }

            Console.WriteLine("ingrese el numero a buscar");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;
            for (int i = 0; i < dat.Length; i++)

            {
                if (dat[i] == num)
                {
                    cont++;
                }
            }
            if (cont == 0)
            {
                Console.WriteLine(" El numero no se encuentra");
            }
            else
            {

                Console.WriteLine(" el numero " + num + " esta " + cont + " veces \t");
            }         
                         
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}

