using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Factory
{
    public class CreateProductA : Creator
    {
        public CreateProductA(String Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IProduct CreateProduct(String Nombre)
        {
            Console.WriteLine(" - CreateProductA / CreateProduct() ");

            ProductA product = new ProductA("Dell");
            product.Nombre = Nombre;

            return product;
        }
    }
}
