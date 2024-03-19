

namespace _0_DataLayer
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Instanciando o PokemonService
    //        var pokemonService = new PokemonService();

    //        // Obter a lista de Pokémon usando o serviço
    //        var pokemonList = pokemonService.GetAllPokemon();

    //        // Listar os Pokémon no console
    //        Console.WriteLine("Lista de Pokémon:");
    //        foreach (var pokemon in pokemonList)
    //        {
    //            Console.WriteLine($"ID: {pokemon.Id}, Nome: {pokemon.Name}, Tipo: {pokemon.Type}");
    //        }
    //    }

    //}

    public class PokemonService
    {
        public List<Pokemon> GetAllPokemon()
        {
            // Aqui você implementa a lógica para obter todos os Pokémon
            // Por exemplo, você pode chamar um método em PokemonData ou acessar um banco de dados
            return PokemonData.GetAllPokemon();
        }
    }

}
    
