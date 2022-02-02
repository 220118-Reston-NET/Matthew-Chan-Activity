using PokeModel;

namespace PokeDL
{
    /// <summary>
    /// Data layer project is reasonbible for interacting with our database and doing CRUD operations
    /// C - Create, R - Read, U - Update, D - Delete
    /// It must not havelogical operations that will also manipulate the data it is grabbing
    /// Just think of Data layer as the delivery man of your uber eats. You definately don't want your delivery man to
    /// touch the food he is delivering and just give it to you so you can do whatever you want wtih it
    /// </summary>

    public interface IRepository
    {
        /// <summary>
        /// Data layer project is reasonible for interacting with our database and doing CRUD operation
        /// - c - create, R - Read, U - Update, D - Delete
        /// - It must not have logical operation that will also manipulate the date it is rabbing
        /// - just think of Data laywer as the delivery man of your uber eats. You definitely don't wnat your delivery man to touch the 
        /// - food he is delivering and just give it to you so you can do whatever you want with it
        /// </summary>
        
        Pokemon AddPokemon(Pokemon p_poke);

        /// <summary>
        /// Will give all pokemon in the database
        /// </summary>
        // <returns>Returns a list collction of Pokemon objects</returns>
        List<Pokemon> GetAllPokemon();

    }
}
