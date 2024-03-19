using System;
using System.Linq;
using System.Collections.Generic;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
}

public class PokemonData
{
    public static List<Pokemon> GetAllPokemon()
    {
        return new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass/Poison" },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire" },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water" },
            new Pokemon { Id = 4, Name = "Greninja", Type = "Water/Dark" },
            new Pokemon { Id = 5, Name = "Mwe", Type = "Pysquico" },
            new Pokemon { Id = 6, Name = "MweTwo", Type = "Pysquico" },
            new Pokemon { Id = 7, Name = "Blastoise", Type = "Water" }
        };
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

