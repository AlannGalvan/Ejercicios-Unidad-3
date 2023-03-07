using System;

namespace ej3_p5
{
    class Program
    {
        static void Main(string[] args)
        {   

             //Hacer un programa para ingresar cuatro números y luego
             // mostrar por pantalla cuáles son mayores a 100.

             int n1, n2, n3, n4, con = 0;


            Console.WriteLine("Ingresar Primer Número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar segundo Número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar tercer Número: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar cuarto Número: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100){
                Console.Write( n1 + " " );
                con++;
            }
            if(n2 > 100){
                 Console.Write(  n2 + " " );
                 con++;
            }
            if(n3 > 100){
                 Console.Write(  n3 + " " );
                 con++;
            }
            if(n4 > 100){
                 Console.Write( n4 + " " );
                 con++;
            }

            if(con != 0)
              Console.Write(" Son mayores a 100...");

              Console.WriteLine("Fin del programa");

            //Console.WriteLine("Hay: " + con + " mayores a 100. ");
        }
    }
}
