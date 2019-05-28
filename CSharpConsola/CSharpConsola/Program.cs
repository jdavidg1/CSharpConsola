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
          

            Console.ReadLine();

         }
            
        static void AgregarBalance(ICuentaBancaria cuentaBancaria, double balance)
        {

            cuentaBancaria.AgregarABalance(balance);
            Console.WriteLine($"El valor de balance es: {cuentaBancaria.Balance}"); // Porque la propiedad Balance si es publica a diferencia de balance

        }

    }

    class Matematicas   // Definición de clase matemáticas, cada clase resuevle un problema
    {

        public static int Suma(int n1, int n2)   //Definición de método. El public permite que sea accesible fuera de la clase
        {
            return n1 + n2;
        }

        public static int Suma(int[] valores)
        {
            int resultado = 0;

            foreach(int i in valores)
            {
                resultado += i;
            }
            return resultado;

        }


        public virtual int Resta(int n1, int n2)   //Definición de método
        {
            return n1 - n2;
        }

        public static int Multiplicacion(int n1, int n2)   //Definición de método
        {
            return n1 * n2;
        }

        public static int Division(int n1, int n2)   //Definición de método
        {
            return n1 / n2;
        }
      
    }

    class Geometria:Matematicas   //Hereda las propiedades de matemáticas
    {

        public static int AreaCuadrado (int lado)
        {

            return Multiplicacion(lado, lado);

        }

        public override int Resta(int n1, int n2)
        {
            return n2 - n1;
        }

    }

}
