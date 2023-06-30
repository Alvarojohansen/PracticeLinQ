


using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;

List<Personaje> personajes = new List<Personaje>();
personajes.Add(new Personaje() { Name = "Felipe", Age = 19 });
personajes.Add(new Personaje() { Name = "Constanza", Age = 8 });
personajes.Add(new Personaje() { Name = "Alvaro", Age = 19 });
personajes.Add(new Personaje() { Name = "Martin", Age = 15 });
personajes.Add(new Personaje() { Name = "Vero", Age = 12 });
personajes.Add(new Personaje() { Name = "Pedro", Age = 43 });

//ej 3, 4
List<int> numeros = new List<int>();
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);
numeros.Add(6);
numeros.Add(7);
numeros.Add(8);
numeros.Add(9);
numeros.Add(10);
numeros.Add(11);
numeros.Add(12);

// ej 8
List<Producto> productos = new List<Producto>();
productos.Add(new Producto() { Id = 1, Nombre = "Manzana" });
productos.Add(new Producto() { Id = 2, Nombre = "Narnaja" });
productos.Add(new Producto() { Id = 3, Nombre = "Banana" });
productos.Add(new Producto() { Id = 4, Nombre = "Pera" });


// ej1
var list = personajes
    .Where(w => w.Age > 18)
    .ToList();

//ej2
var list2 = personajes
    .OrderBy(x => x.Age) // ordena las propiedades por anio
    .ToList();

//ej 3
var list3 = numeros
    .Where(w => w % 2 != 0)
    .ToList();

//ej 4
var promedio = numeros
    .Average();
//Console.WriteLine(promedio);
//ej 5
var list5 = numeros
    .Where(w => w > 3 & w < 10); 

//ej 6
var list6 = numeros
    .FirstOrDefault(); // para encontrar su primer elemneto de una lista
//  .LastOrDefault();  || .Last();         (para encontrar el ultimo elemento)
//Console.WriteLine(list6);

//ej 7
var list7 = numeros
    .Sum();
//Console.WriteLine(list7);


//ej 8
var list8 = productos.Where(w => w.Nombre.Contains("na"));


foreach (var item in list2)
{
    //ej2
    string descripcion = $" tiene {item.Age} años";
    Console.WriteLine(descripcion);

    //ej3
    //Console.WriteLine(item);
    //ej 5
    //Console.WriteLine(item);

    //ej 8
    //Console.WriteLine($"Id: {item.Id}, Producto {item.Nombre}.");

}




public class Personaje
{
    public string Name { get; set; }
    public int Age { get; set; }
}


public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}