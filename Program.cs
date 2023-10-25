using System;
using System.Windows.Forms; 

namespace Estructuras_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejemplo con Estructuras
            Cliente cliente = new Cliente();
            cliente.Nombre = "Armando";
            cliente.Edad = 25;

            Cliente cliente2 = cliente;

            cliente2.Nombre = "Jorge";

            Console.WriteLine("Nombre: {0}", cliente.Nombre);
            Console.ReadLine();*/
            
            Persona persona = new Persona();
            persona.Nombre = "Armando";
            persona.Edad = 25;

            Persona persona2 = persona;

            persona2.Nombre = "Jorge";

            Console.WriteLine("Nombre: {0}", persona2.Nombre);

            Console.WriteLine("Hoy es: {0}", Semana.Lunes + 2);

            Console.WriteLine(Keys.Enter);



            Console.ReadLine(); 
        }
    }
}
