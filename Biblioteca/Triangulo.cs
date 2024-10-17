using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Triangulo
    {
        public void falo()
        {
            int a = 0, b = 0, c = 0, total = 0 ;
            a = 1;
            b = 2;
            total = a + b + c;

            Console.WriteLine("El valor es : "+total);
        }
        public int valor21(int x=0 , int y=0)
        {
            
            Console.Write("Pon un numero = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Pon otro numero = ");
            y=int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de los numeros es = " + (x + y));
            return 1;
            
        }
        public int valor222()
        {
            int a=0, b=0,total=0;
            Console.Write("valor = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("valor = ");
            b= int.Parse(Console.ReadLine());
            total = a + b;
            Console.WriteLine("suma es = "+total);
            return 1;

        }
    }
}
