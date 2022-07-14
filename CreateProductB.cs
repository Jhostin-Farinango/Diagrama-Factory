using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Factory
{
    public class CreateProductB : Creator
    {
        public CreateProductB(String Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IProduct CreateProduct(String Nombre)
        {
            Console.WriteLine(" - CreateProductB / CreateProduct() ");
            ProductB product = new ProductB("Laptop", 2017);
            product.Nombre = Nombre;
            return product;
        }    
    }
}
