// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using CsharpApis.Model;

#region Deserilize
/*
using CsharpApis;
using QuickType;

var engine = new Engine();
string content = await engine.GetResponse();

SwPeople? person = new SwPeople();

person = JsonConvert.DeserializeObject<SwPeople>(content);

Console.WriteLine(person?.Name); //Luke Skywalker
foreach(var prop in person.Films){
    Console.WriteLine(prop);
}

////Print Name's Properties 
// foreach(var prop in person.GetType().GetProperties()){
//     Console.WriteLine(prop.Name);
// }
*/
#endregion

//Serialize
var engine = new Engine();
Country[] countries = engine.GetCountries();
string SerializeCountries = JsonConvert.SerializeObject(countries);
Console.WriteLine(SerializeCountries);