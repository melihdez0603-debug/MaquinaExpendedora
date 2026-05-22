using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaquinaExpendedora
{
    internal class Producto
    {
        private string nombre;
        private float precio;
        private int existencia;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }

        // Constructor
        public Producto(string nombre, float precio, int existencia)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.existencia = existencia;
        }

    }

}
