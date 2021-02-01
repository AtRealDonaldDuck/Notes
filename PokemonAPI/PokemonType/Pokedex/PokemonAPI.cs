using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class PokemonAPI
    {
        private static readonly Uri pokeAPI = new Uri(@"https://pokeapi.co/api/v2/pokemon");

        public static JObject GetJObj(string pokemonName)
        {
            var webClient = new WebClient();
            var pokemonJsonFile = JObject.Parse(webClient.DownloadString($@"{pokeAPI}/{pokemonName}"));

            return pokemonJsonFile;
        }
    }
}
