namespace PokeDL
{
    /// <summary>
    /// Data layer project is reasonbible for interacting with our database and doing CRUD operations
    /// C - Create, R - Read, U - Update, D - Delete
    /// It must not havelogical operations that will also manipulate the data it is grabbing
    /// Just think of Data layer as the delivery man of your uber eats. You definately don't want your delivery man to
    /// touch the food he is delivering and just give it to you so you can do whatever you want wtih it
    /// </summary>

    public class IRepository
    {
        /// <summary>
        /// f
        /// f
        /// </summary>
        
        Pokemon AddPokemon(Pokemon p_poke);

    }
}
