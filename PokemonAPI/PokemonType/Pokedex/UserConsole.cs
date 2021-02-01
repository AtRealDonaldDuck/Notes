using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pokedex
{
    class UserConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Pokemon Name :");
            var pokemonName = Console.ReadLine();

            foreach(var a in PokemonType(pokemonName))
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\nEoF");
            while (true) ;
        }

        private static string[] PokemonType(string pokemonName)
        {
            return new PokemonData().GetPokemonType(pokemonName);
        }
    }
}
