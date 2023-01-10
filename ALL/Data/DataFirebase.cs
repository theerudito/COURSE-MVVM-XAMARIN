using ALL.Connection;
using ALL.Model;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALL.Data
{
    public class DataFirebase
    {
        public async Task InsertPokemon(Pokemon pokemon)
        {
            await ConnectionFirebase.firebase
                .Child("Pokemon")
                .PostAsync(new Pokemon()
                {
                    Nombre = pokemon.Nombre,
                    ColorFondo = pokemon.ColorFondo,
                    NPokemon = pokemon.NPokemon,
                    Icono = pokemon.Icono,
                    Poder = pokemon.Poder,
                    ColorPoder = pokemon.ColorPoder,
                });
        }

        public async Task<List<Pokemon>> GetPokemons()
        {
            return (await ConnectionFirebase.firebase.Child("Pokemon").OnceAsync<Pokemon>()).Select(item => new Pokemon
            {
                Id = item.Object.Id,
                Nombre = item.Object.Nombre,
                ColorFondo = item.Object.ColorFondo,
                NPokemon = item.Object.NPokemon,
                Icono = item.Object.Icono,
                Poder = item.Object.Poder,
                ColorPoder = item.Object.ColorPoder
            }).ToList();
        }

        // trear un pokemon

        public async Task<Pokemon> GetPokemon(string id)
        {
            var allPokemon = await GetPokemons();
            await ConnectionFirebase.firebase.Child("Pokemon").OnceAsync<Pokemon>();
            return allPokemon.Where(a => a.Id == id).FirstOrDefault();
        }



        public async Task UpdatePokemon(Pokemon pokemon)
        {
            var toUpdatePokemon = (await ConnectionFirebase.firebase.Child("Pokemon").OnceAsync<Pokemon>()).Where(a => a.Object.Id == pokemon.Id).FirstOrDefault();
            await ConnectionFirebase.firebase.Child("Pokemon").Child(toUpdatePokemon.Key).PutAsync(new Pokemon()
            {
                Id = pokemon.Id,
                Nombre = pokemon.Nombre,
                ColorFondo = pokemon.ColorFondo,
                NPokemon = pokemon.NPokemon,
                Icono = pokemon.Icono,
                Poder = pokemon.Poder,
                ColorPoder = pokemon.ColorPoder
            });
        }

        public async Task DeletePokemon(string id)
        {
            var toDeletePokemon = (await ConnectionFirebase.firebase.Child("Pokemon").OnceAsync<Pokemon>()).Where(a => a.Object.Id == id).FirstOrDefault();
            await ConnectionFirebase.firebase.Child("Pokemon").Child(toDeletePokemon.Key).DeleteAsync();
        }

    }
}


