using System;

namespace ej3_p4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Hacer un programa para ingresar cuatro números distintos y 
            //luego mostrar por pantalla el menor de ellos.

            int n1, n2, n3, n4, menor;
            
            Console.WriteLine("Ingresar Primer Número: ");
            n1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingresar Segundo Número: ");
            n2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingresar Tercer Número: ");
            n3 = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingresar Cuarto Número: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2)
               menor = n1;
            else
              menor = n2;
            if(n3 < menor)
                menor = n3;
            if(n4 < menor)
              menor = n4;

            Console.WriteLine("El menor es: " + menor);
            

            //if(n1 < n2 && n1 < n3 && n1 < n4 ){
              //  Console.WriteLine("El menor es n1");
            //}else if(n2 < n1 && n2 < n3 && n2 < n4){
              //   Console.WriteLine("El menor es n2");
            //}else if(n3 < n1 && n3 < n2 && n3 < n4){
              //   Console.WriteLine("El menor es n3");
            //}else{
              //   Console.WriteLine("El menor es n4");
            //}

        




        }
    }
}
