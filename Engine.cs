using System;
using Newtonsoft.Json;
using CsharpApis.Model;

public class Engine
{
    public Country[] GetCountries()
    {    
        var presidents = new President[] {
            new President {Name = "Antonio Guzman Blanco"},
            new President {Name = "Bernardo O'higgins"},
            new President {Name = "Lula Da'Silva"},
            new President {Name = "Mathias Laca"}
        };
        var country = new Country[]{
            new Country {Name = "Venezuela", Population = 30000000, Founded = DateTime.Parse("10/01/1622"), Presidents = presidents},
            new Country {Name = "Chile", Population = 20000000, Founded = DateTime.Parse("10/01/1722"), Presidents = presidents},
            new Country {Name = "Brasil", Population = 130000000, Founded = DateTime.Parse("10/01/1822"), Presidents = presidents},
            new Country {Name = "Uruguay", Population = 4300000, Founded = DateTime.Parse("10/01/1922"), Presidents = presidents}
        };
        return country;
    }
}


/*
namespace CsharpApis
{
    public class Engine
    {
        public async Task<string> GetResponse(){

            string endpoint = "https://swapi.py4e.com/api/people/1";
            string response;

            using (HttpClient client = new HttpClient()){
                response = await client.GetStringAsync(endpoint);
            }
            return response;    
        }
    }
}
*/