using System;
using System.Linq;

namespace Colegio_Mariano
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("cantidad de estudiantes a valorar");
            int num_estudiantes = int.Parse(Console.ReadLine());
     
            int[] edad = new int[num_estudiantes];
            string[] nombre = new string[num_estudiantes];
            int prom=0;
            int v1 =0 ;
            string v2;

            for (int x = 0; x <= num_estudiantes-1; x++)
            {
                Console.WriteLine("Nombre del estudiante: ");
                v2 = Console.ReadLine();
                nombre[x] = v2;

                Console.WriteLine("Edad estudiantes");
                v1 = int.Parse(Console.ReadLine());
                edad[x] = v1;
                prom = prom + edad[x];

            }
            prom = prom / num_estudiantes;

            Console.Write("la edad promedio de los estudiantes es  " + prom);
            Console.Write("\n\nla edad mayor es : " + edad.Max() );
            Console.Write("\n\nla edad menor es : " + edad.Min());


        }
    }
}
