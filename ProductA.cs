using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Factory 
{
    public class ProductA : IProduct
    {
        public String Nombre { get; set; }

        public string Marca { get; set; }

        public ProductA(String Marca)
        {
            this.Marca = Marca;
        }
        public void doStuf()
        {
            Console.WriteLine("--Estoy en productA / doStuf()");
            Console.WriteLine("Nombre " + this.Nombre);
            Console.WriteLine("Marca " + this.Marca);
        }
    }
}
