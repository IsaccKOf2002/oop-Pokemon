namespace ApiPokemon._1_BusinessLogicLayer
{
    public class CamadaNegocios
    {
        public static class PokemonService
        {
            public static List<Pokemon> GetAllPokemon()
            {
                return PokemonData.GetAllPokemon();
            }
        }



    }
}
