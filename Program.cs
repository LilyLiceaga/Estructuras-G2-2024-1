using System;
using System.Collections.Generic;

using System.Windows.Forms; 

namespace Estructuras_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo con Estructuras
            Cliente cliente = new Cliente();
            cliente.Nombre = "Armando";
            cliente.Edad = 25;

            Cliente cliente2 = cliente;

            cliente2.Nombre = "Jorge";

            Console.WriteLine("Nombre: {0}", cliente.Nombre); //Imprime Armando

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(cliente);
            clientes.Add(cliente2);

            foreach(Cliente miCliente in clientes)
            {
                Console.WriteLine(miCliente.Nombre);
            }


            /*Persona persona = new Persona();
            persona.Nombre = "Armando";
            persona.Edad = 25;

            Persona persona2 = persona;

            persona2.Nombre = "Jorge";

            Console.WriteLine("Nombre: {0}", persona2.Nombre); //Imprime Jorge

            Console.WriteLine("Hoy es: {0}", Semana.Lunes + 2);*/

            Console.WriteLine(Keys.Enter);



            Console.ReadLine(); 
        }
    }
}
