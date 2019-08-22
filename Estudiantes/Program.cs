using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno0 = new Alumno();

            Console.WriteLine("Alumno 0:");
            Console.WriteLine("Nombre: " + alumno0.Nombre);
            Console.WriteLine("Matricula: " + alumno0.Matricula);

            Alumno alumno1 = new Alumno();

            alumno1.Nombre = "Jesus";
            alumno1.Matricula = "000000";

            Console.WriteLine("Alumno 1:");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);

            Alumno alumno2 = new Alumno("Eduardo", "189289");

            Console.WriteLine("Alumno 2:");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);


            Console.ReadKey();
        }
    }
}
