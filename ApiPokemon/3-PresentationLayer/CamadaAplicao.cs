
using ApiPokemon._0_DataLayer.Entidades;
using ApiPokemon._1_BusinessLogicLayer;
using ApiPokemon._1_BusinessLogicLayer.Servico;

namespace _0_DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //isso e uma instacia, ou seja vc esta trazedno dados da sua camada de dados para a camada de aplicação por uma instancia
            //var pokemonService = new PokemonService();

            //quando a classe e static vc traz dados direto sem instancia
            List<Pokemon> pegaTodosPokemon = PokemonBuscar.PokemonService.GetAllPokemon(); //pegar todos pokemon

            // Listar todos os Pokémon no console
            ListarPokemon(pegaTodosPokemon);

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
                        var pokemonById = PokemonBuscar.PokemonService.GetPokemonById(id);
                        if (pokemonById != null)
                            Console.WriteLine($"Pokémon encontrado: {pokemonById.Name}, Tipo: {pokemonById.Type}");
                        else
                            Console.WriteLine("Nenhum Pokémon encontrado com esse ID.");
                        break;
                    case "2":
                        Console.Write("Digite o nome do Pokémon: ");
                        string nomePokemon = Console.ReadLine();
                        var pokemonByName = PokemonBuscar.PokemonService.GetPokemonByName(nomePokemon);
                        if (pokemonByName.Count > 0)
                            Console.WriteLine($"Pokémon encontrado: {pokemonByName[0].Name}, Tipo: {pokemonByName[0].Type}");
                        else
                            Console.WriteLine("Nenhum Pokémon encontrado com esse nome.");
                        break;
                    case "3":
                        Console.Write("Digite o tipo do Pokémon: ");
                        string tipoPokemon = Console.ReadLine();
                        var pokemonByType = PokemonBuscar.PokemonService.GetPokemonByType(tipoPokemon);
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

        static void ListarPokemon(List<Pokemon> pegaTodosPokemon)
        {
            var pokemonList = pegaTodosPokemon;
            Console.WriteLine("Lista de Pokémon:");
            foreach (var pokemon in pokemonList)
            {
                Console.WriteLine($"ID: {pokemon.Id}, Nome: {pokemon.Name}, Tipo: {pokemon.Type}");
            }
        }
    }
}
    
