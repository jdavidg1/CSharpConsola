using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsola
{
    class Program
    {
        static void Main(string[] args)  //El método principal se llama main, los elementos son referenciados en la parte superior
            //El espacio de nombres es donde está ubicada una clase
        {
            int numeroUno = int.Parse(Console.ReadLine());    //metodo parse, el cual está dentro de la clase int y por eso se llama primero
            int numeroDos = int.Parse(Console.ReadLine());
            int resultado = Suma(numeroUno, numeroDos);
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();

         }

        static int Suma (int n1, int n2)   //Definición de método

        {

            return n1 + n2;

        }
    }
}
