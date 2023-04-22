using pokemonReviewApp.model;

namespace pokemonReviewApp.Interface
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        
        Pokemon GetPokemon(int Id);
        Pokemon GetPokemon(string name);
        Pokemon GetPokemonRating(int pokeId);
        Pokemon PokemonExists(int pokeId);
    }
}
