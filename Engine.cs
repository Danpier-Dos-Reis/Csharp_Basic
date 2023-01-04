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

            string endpoint = "https://pokeapi.co/api/v2/pokemon-species/25/";

            using (HttpClient client = new HttpClient()){

                string res = await client.GetStringAsync(endpoint) ;

                if(!string.IsNullOrEmpty(res)){
                   dynamic? response = null == null ? JsonConvert.DeserializeObject(res)?.ToString():""; //Partimos el json
                   res = JsonConvert.SerializeObject(response,Formatting.Indented); //Retornamos el Json más bonito
                }
                return res;
            }
        }
    }
}