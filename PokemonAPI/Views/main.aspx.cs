using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PokemonAPI.Models;
using PokemonAPI.Controller;

namespace PokemonAPI.Views
{
    public partial class main : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            PokemonController pokemoncontroller = new PokemonController();
            List<PokemonData> pokemonList = await pokemoncontroller.GetPokemons(string.Empty);

            pokemonRepeater.DataSource = pokemonList;
            pokemonRepeater.DataBind();
        }
    }
}