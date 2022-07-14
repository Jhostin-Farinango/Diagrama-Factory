using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Factory
{
    public abstract class Creator
    {
        public String Nombre { get; set; }
        public Creator(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SomeOperation() 
        {
            Console.WriteLine("Estoy en Creator");
            IProduct product = CreateProduct(Nombre);
            product.doStuf();
        }

        public abstract IProduct CreateProduct(String Nombre);
    }
}
