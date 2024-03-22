using ApiPokemon._0_DataLayer.Entidades;

namespace ApiPokemon._1_BusinessLogicLayer.Servico
{
    public class PokemonBuscar
    {
        public static class PokemonService
        {
            public static List<Pokemon> GetAllPokemon()
            {
                return PokemonData.GetAllPokemon();
            }

            public static Pokemon GetPokemonById(int id)
            {
                return PokemonData.GetAllPokemon().FirstOrDefault(p => p.Id == id);
            }

            public static List<Pokemon> GetPokemonByName(string name)
            {
                return PokemonData.GetAllPokemon().Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
            }

            public static List<Pokemon> GetPokemonByType(string type)
            {
                return PokemonData.GetAllPokemon().Where(p => p.Type.ToLower().Contains(type.ToLower())).ToList();
            }
        }
    }
}
