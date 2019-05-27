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
            /*  int numeroUno = int.Parse(Console.ReadLine());    //metodo parse, el cual está dentro de la clase int y por eso se llama primero
              int numeroDos = int.Parse(Console.ReadLine());
              int resultado = Matematicas.Suma(numeroUno, numeroDos);
              Console.WriteLine($"Resultado: {resultado}");*/

            CuentaBancaria cuentaUno = new CuentaBancaria(); // Crear una instancia de la CuentaBancaria
            cuentaUno.Balance = -2000;

            CuentaBancariaKids cuentaDos = new CuentaBancariaKids(); // Crear una instancia de la CuentaBancaria
            cuentaDos.Balance = 2000;

            AgregarBalance(cuentaUno, 3000);
            AgregarBalance(cuentaDos, 3000);


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

        public static int Resta(int n1, int n2)   //Definición de método
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

    }

}
