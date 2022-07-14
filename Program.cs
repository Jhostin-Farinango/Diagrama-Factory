using System;
using System.Collections.Generic;

namespace Diseño_Factory
{
    public class Program 
    {
        static void Main(string[] args)
        {
            List<Creator> lista = new List<Creator>();
            lista.Add(new CreateProductA("Cocina"));
            lista.Add(new CreateProductA("Licuadora"));
            lista.Add(new CreateProductB("Equipo Hogar"));
            lista.Add(new CreateProductB("Equipo Oficina"));
            lista.Add(new CreateProductB("Equipo de desarrollo"));

            foreach (Creator creator in lista)
            {
                creator.SomeOperation();
            }
        }
    }
}
