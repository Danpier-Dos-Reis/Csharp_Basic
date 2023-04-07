// See https://aka.ms/new-console-template for more information
using CsharpApis;
using QuickType;
using Newtonsoft.Json;

var engine = new Engine();
string content = await engine.GetResponse();

SwPeople? person = new SwPeople();

person = JsonConvert.DeserializeObject<SwPeople>(content);

Console.WriteLine(person?.Name); //Luke Skywalker
foreach(var prop in person.Films){
    Console.WriteLine(prop);
}

////Print Name's Properties from Object
// foreach(var prop in person.GetType().GetProperties()){
//     Console.WriteLine(prop.Name);
// }