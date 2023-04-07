// See https://aka.ms/new-console-template for more information
using CsharpApis;

var engine = new Engine();
string content = await engine.GetResponse();

Console.WriteLine(content);