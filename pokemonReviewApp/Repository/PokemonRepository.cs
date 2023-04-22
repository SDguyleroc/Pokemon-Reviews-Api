using pokemonReviewApp.Data;
using pokemonReviewApp.Interface;
using pokemonReviewApp.model;

namespace pokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        { 
            _context = context;
        }

        public Pokemon GetPokemon(int Id)
        {
            throw new NotImplementedException();
        }

        public Pokemon GetPokemon(string name)
        {
            throw new NotImplementedException();
        }

        public Pokemon GetPokemonRating(int pokeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }

        public Pokemon PokemonExists(int pokeId)
        {
            throw new NotImplementedException();
        }
    }

}
