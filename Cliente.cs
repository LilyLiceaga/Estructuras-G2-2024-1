﻿using System;

namespace Estructuras_G2_2024_1
{
    internal struct Cliente 
    {
        #region Atributos
        private string nombre;
        private byte edad;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        #endregion

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Edad: {0}", Edad);
        }
    }
}
