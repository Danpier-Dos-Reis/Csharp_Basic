// See https://aka.ms/new-console-template for more information
using Listas.Engine;
using Listas.Modelo;

List<Pais> lista = new CreateList().GetList();

if(lista.Any(pais => pais.Nombre == "Canadá"))
{
    List<Pais> Canada = lista.Where(p => p.Nombre == "Canadá").ToList();

    foreach(var index in Canada)
    {
        //Tenemos las propiedades del Modelo 'Pais'
        var properties = index.GetType().GetProperties();
        foreach(var property in properties)
        {
            //Nombre de la propieda y el valor de la propiedad
            Console.WriteLine($"{property.Name}: {property.GetValue(index)}");
        }
    }
}