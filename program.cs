using System;
using System.Collections.Generic;

class Producto
{
    public string Nombre {get; set;}
}

class Program
{
    static void Main()
    {
        List<Producto> productos=new List<Producto>();
        
        productos.Add(new Producto { Nombre = "Mouse"});
        productos.Add(new Producto { Nombre = "Teclado"});
        productos.Add(new Producto { Nombre = "Monitor"});
        
        Console.WriteLine("Lista: ");
        foreach (var p in productos)
        {
            Console.WriteLine(p.Nombre);
        }
    }
}
