

namespace _0_DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonService = new PokemonService();

            // Listar todos os Pokémon no console
            ListarPokemon(pokemonService);

            // Loop para continuar solicitando tipos de busca até que o usuário decida parar
            while (true)
            {
                Console.WriteLine("Escolha o tipo de busca:");
                Console.WriteLine("1. Busca por ID");
                Console.WriteLine("2. Busca por nome");
                Console.WriteLine("3. Busca por tipo");
                Console.WriteLine("4. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o ID do Pokémon: ");
                        int id = int.Parse(Console.ReadLine());
                        var pokemonById = pokemonService.GetPokemonById(id);
                        if (pokemonById != null)
                            Console.WriteLine($"Pokémon encontrado: {pokemonById.Name}, Tipo: {pokemonById.Type}");
                        else
                            Console.WriteLine("Nenhum Pokémon encontrado com esse ID.");
                        break;
                    case "2":
                        Console.Write("Digite o nome do Pokémon: ");
                        string nomePokemon = Console.ReadLine();
                        var pokemonByName = pokemonService.GetPokemonByName(nomePokemon);
                        if (pokemonByName.Count > 0)
                            Console.WriteLine($"Pokémon encontrado: {pokemonByName[0].Name}, Tipo: {pokemonByName[0].Type}");
                        else
                            Console.WriteLine("Nenhum Pokémon encontrado com esse nome.");
                        break;
                    case "3":
                        Console.Write("Digite o tipo do Pokémon: ");
                        string tipoPokemon = Console.ReadLine();
                        var pokemonByType = pokemonService.GetPokemonByType(tipoPokemon);
                        if (pokemonByType.Count > 0)
                            Console.WriteLine($"Pokémon encontrado: {pokemonByType[0].Name}, Tipo: {pokemonByType[0].Type}");
                        else
                            Console.WriteLine("Nenhum Pokémon encontrado com esse tipo.");
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
        public class PokemonService
        {
            public List<Pokemon> GetAllPokemon()
            {
                return PokemonData.GetAllPokemon();
            }

            public Pokemon GetPokemonById(int id)
            {
                return PokemonData.GetAllPokemon().FirstOrDefault(p => p.Id == id);
            }

            public List<Pokemon> GetPokemonByName(string name)
            {
                return PokemonData.GetAllPokemon().Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
            }

            public List<Pokemon> GetPokemonByType(string type)
            {
                return PokemonData.GetAllPokemon().Where(p => p.Type.ToLower().Contains(type.ToLower())).ToList();
            }
        }


        static void ListarPokemon(PokemonService pokemonService)
        {
            var pokemonList = pokemonService.GetAllPokemon();
            Console.WriteLine("Lista de Pokémon:");
            foreach (var pokemon in pokemonList)
            {
                Console.WriteLine($"ID: {pokemon.Id}, Nome: {pokemon.Name}, Tipo: {pokemon.Type}");
            }
        }
    }


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
    
