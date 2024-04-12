using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using PokemonAPI.Models;

namespace PokemonAPI.Controller
{
    public class PokemonController
    {
        private HttpClient client = new HttpClient();
        private string apiUrl = "https://pokeapi.co/api/v2/pokemon/";

        public async Task<List<PokemonData>> GetPokemons(string empty)
        {
            List<PokemonData> pokemonList = new List<PokemonData>();

            try
            {
                for (int i = 1; i <= 20; i++)
                {
                    string pokemonUrl = $"{apiUrl}{i}";
                    HttpResponseMessage response = await client.GetAsync(pokemonUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject pokemonData = JObject.Parse(responseBody);

                        string pokemonName = pokemonData["name"].ToString();
                        string imageUrl = $"https://img.pokemondb.net/artwork/large/{pokemonName}.jpg";

                        pokemonList.Add(new PokemonData { Name = pokemonName, ImageUrl = imageUrl });
                    }
                    else
                    {
                        // Handle unsuccessful response if needed
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception appropriately, maybe log it
                Console.WriteLine("Error fetching Pokémon data: " + ex.Message);
            }
            finally
            {
                client.Dispose();
            }

            return pokemonList;
        }
    }
}