using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

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