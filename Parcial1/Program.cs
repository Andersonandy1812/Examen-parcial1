using System;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija el numero de un dia");
            Console.WriteLine("1-Lunes");
            Console.WriteLine("2-Martes");
            Console.WriteLine("3-Miercoles");
            Console.WriteLine("4-Jueves");
            Console.WriteLine("5-Viernes");
            Console.WriteLine("6-Sabado");
            Console.WriteLine("7-Domingo");
            int dia = Convert.ToInt32(Console.ReadLine());
            if (dia > 5 & dia > 7)
            {
                Console.WriteLine("Cacon ese no es un dia de la semana");
            }
            else if (dia < 5 & dia > 0)
            {
                Console.WriteLine("Eligio un dia de la semana");
            }
            else if (dia > 5 & dia < 7)
            {
                Console.WriteLine("Eligio un fin de semana");
            }
            else
            {
                Console.WriteLine("No hagas trampa cacon, eso  tampoco es un dia de la semana");
            }
        }
        private static void tarjeta()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Cual es el precio del producto que desea comprar");
            string precio = Console.ReadLine();
            Console.WriteLine("En que forma lo quiere pagar, efectivo o tarjeta?");
            string formapago = Console.ReadLine();
            if (formapago == "efectivo")
            {
                Console.WriteLine("Gracias por realizar su compra");
            }
            else if (formapago == "tarjeta")
            {
                Console.Write("*Solo 12 digitos*Numero de tarjeta:");
                long tarjeta = Convert.ToInt32(Console.ReadLine());
                if(tarjeta > 99999999999 & tarjeta > 999999999999)
                {
                    Console.WriteLine("Este digito es invalido");
                }
                else
                {
                    Console.WriteLine("gracias por efectuar su pago");
                }
            }
        }
    }
}
