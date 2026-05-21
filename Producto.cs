using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaquinaExpendedora
{
    class Producto
    {
        public string Nombre;
        public float Precio;
        public int Existencia;

        // Constructor
        public Producto(string nombre, float precio, int existencia)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Existencia = existencia;
        }

    }

}
