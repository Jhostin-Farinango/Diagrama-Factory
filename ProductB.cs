using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Factory
{
    public class ProductB : IProduct
    {
        public String Nombre { get; set; }
        public String Modelo { get; set; }
        public int Año { get; set; }

        public ProductB(string Modelo, int Año)
        {
            this.Modelo = Modelo;
            this.Año = Año;
        }

        public void doStuf()
        {
            Console.WriteLine("--Estoy en productB / doStuf()");
            Console.WriteLine("Nombre " + this.Nombre);
            Console.WriteLine("Año " + this.Año);
            Console.WriteLine("Modelo " + this.Modelo);
        }
    }
}
