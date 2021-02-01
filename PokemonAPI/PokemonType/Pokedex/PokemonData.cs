using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class PokemonData
    {
        public string[] GetPokemonType(string pokemonName)
        {
            var pokemonJsonObject = PokemonAPI.GetJObj(pokemonName);
            var pokemonTypesJToken = pokemonJsonObject["types"];

            return ConvertToStringArrayContainingPokemonTypes(pokemonTypesJToken);
        }

        private string[] ConvertToStringArrayContainingPokemonTypes(JToken pokemonTypesJToken)
        {
            var pokemonTypesString = new string[pokemonTypesJToken.ToArray().Length];

            for (int i = 0; i < pokemonTypesString.Length; i++)
            {
                pokemonTypesString[i] = (string)pokemonTypesJToken[i]["type"]["name"];
            }

            return pokemonTypesString;
        }
    }
}
