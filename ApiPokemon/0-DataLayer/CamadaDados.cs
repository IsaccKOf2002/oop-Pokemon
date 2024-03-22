﻿using ApiPokemon._0_DataLayer.Entidades;


public class PokemonData
{
    public static List<Pokemon> GetAllPokemon()
    {
        return new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass/Poison" },
            new Pokemon { Id = 2, Name = "Ivisaur", Type = "Grass/Poison" },
            new Pokemon { Id = 3, Name = "Venosar", Type = "Grass/Poison" },
            new Pokemon { Id = 4, Name = "Charmander", Type = "Fire" },
            new Pokemon { Id = 5, Name = "Charmilion", Type = "Fire" },
            new Pokemon { Id = 6, Name = "Charizard", Type = "Fire/fly" },
            new Pokemon { Id = 7, Name = "Squirtle", Type = "Water" },
            new Pokemon { Id = 8, Name = "Wartortle", Type = "Water" },
            new Pokemon { Id = 9, Name = "Blastoise", Type = "Water/Dark" },
            new Pokemon { Id = 10, Name = "Caterpie", Type = "Insect" },
            new Pokemon { Id = 11, Name = "Metapoo", Type = "Insect" },
            new Pokemon { Id = 12, Name = "Butterfree", Type = "Insect/Fly" },
            new Pokemon { Id = 13, Name = "Weedle", Type = "Insect/Poison" },
            new Pokemon { Id = 14, Name = "Kakuna", Type = "Insect/Poison" },
            new Pokemon { Id = 15, Name = "Beedrill", Type = "Insect/Poison" },
            new Pokemon { Id = 16, Name = "Pidgey", Type = "Normal/Flying" },
            new Pokemon { Id = 17, Name = "Pidgeotto", Type = "Normal/Flying" },
            new Pokemon { Id = 18, Name = "Pidgeot", Type = "Normal/Flying" },
            new Pokemon { Id = 19, Name = "Rattata", Type = "Normal" },
            new Pokemon { Id = 20, Name = "Raticate", Type = "Normal" },
            new Pokemon { Id = 21, Name = "Spearow", Type = "Normal/Flying" },
            new Pokemon { Id = 22, Name = "Fearow", Type = "Normal/Flying" },
            new Pokemon { Id = 23, Name = "Ekans", Type = "Poison" },
            new Pokemon { Id = 24, Name = "Arbok", Type = "Poison" },
            new Pokemon { Id = 25, Name = "Pikachu", Type = "Electric" },
            new Pokemon { Id = 26, Name = "Raichu", Type = "Electric" },
            new Pokemon { Id = 27, Name = "Sandshrew", Type = "Ground" },
            new Pokemon { Id = 28, Name = "Sandslash", Type = "Ground" },
            new Pokemon { Id = 29, Name = "Nidoran♀", Type = "Poison" },
            new Pokemon { Id = 30, Name = "Nidorina", Type = "Poison" },
            new Pokemon { Id = 31, Name = "Nidoqueen", Type = "Poison/Ground" },
            new Pokemon { Id = 32, Name = "Nidoran♂", Type = "Poison" },
            new Pokemon { Id = 33, Name = "Nidorino", Type = "Poison" },
            new Pokemon { Id = 34, Name = "Nidoking", Type = "Poison/Ground" },
            new Pokemon { Id = 35, Name = "Clefairy", Type = "Fairy" },
            new Pokemon { Id = 36, Name = "Clefable", Type = "Fairy" },
            new Pokemon { Id = 37, Name = "Vulpix", Type = "Fire" },
            new Pokemon { Id = 38, Name = "Ninetales", Type = "Fire" },
            new Pokemon { Id = 39, Name = "Jigglypuff", Type = "Normal/Fairy" },
            new Pokemon { Id = 40, Name = "Wigglytuff", Type = "Normal/Fairy" },
            new Pokemon { Id = 41, Name = "Zubat", Type = "Poison/Flying" },
            new Pokemon { Id = 42, Name = "Golbat", Type = "Poison/Flying" },
            new Pokemon { Id = 43, Name = "Oddish", Type = "Grass/Poison" },
            new Pokemon { Id = 44, Name = "Gloom", Type = "Grass/Poison" },
            new Pokemon { Id = 45, Name = "Vileplume", Type = "Grass/Poison" },
            new Pokemon { Id = 46, Name = "Paras", Type = "Bug/Grass" },
            new Pokemon { Id = 47, Name = "Parasect", Type = "Bug/Grass" },
            new Pokemon { Id = 48, Name = "Venonat", Type = "Bug/Poison" },
            new Pokemon { Id = 49, Name = "Venomoth", Type = "Bug/Poison" },
            new Pokemon { Id = 50, Name = "Diglett", Type = "Ground" },
            new Pokemon { Id = 51, Name = "Dugtrio", Type = "Ground" },
            new Pokemon { Id = 52, Name = "Meowth", Type = "Normal" },
            new Pokemon { Id = 53, Name = "Persian", Type = "Normal" },
            new Pokemon { Id = 54, Name = "Psyduck", Type = "Water" },
            new Pokemon { Id = 55, Name = "Golduck", Type = "Water" },
            new Pokemon { Id = 56, Name = "Mankey", Type = "Fighting" },
            new Pokemon { Id = 57, Name = "Primeape", Type = "Fighting" },
            new Pokemon { Id = 58, Name = "Growlithe", Type = "Fire" },
            new Pokemon { Id = 59, Name = "Arcanine", Type = "Fire" },
            new Pokemon { Id = 60, Name = "Poliwag", Type = "Water" },
            new Pokemon { Id = 61, Name = "Poliwhirl", Type = "Water" },
            new Pokemon { Id = 62, Name = "Poliwrath", Type = "Fighting" },
            new Pokemon { Id = 63, Name = "Abra", Type = "Psychic" },
            new Pokemon { Id = 64, Name = "Kadabra", Type = "Psychic" },
            new Pokemon { Id = 65, Name = "Alakazam", Type = "Psychic" },
            new Pokemon { Id = 66, Name = "Machop", Type = "Fighting" },
            new Pokemon { Id = 67, Name = "Machoke", Type = "Fighting" },
            new Pokemon { Id = 68, Name = "Machamp", Type = "Fighting" },
            new Pokemon { Id = 69, Name = "Bellsprout", Type = "Grass/Poison" },
            new Pokemon { Id = 70, Name = "Weepinbell", Type = "Grass/Poison" },
            new Pokemon { Id = 71, Name = "Victreebel", Type = "Grass/Poison" },
            new Pokemon { Id = 72, Name = "Tentacool", Type = "Water/Poison" },
            new Pokemon { Id = 73, Name = "Tentacruel", Type = "Water/Poison" },
            new Pokemon { Id = 74, Name = "Geodude", Type = "Rock/Ground" },
            new Pokemon { Id = 75, Name = "Graveler", Type = "Rock/Ground" },
            new Pokemon { Id = 76, Name = "Golem", Type = "Rock/Ground" },
            new Pokemon { Id = 77, Name = "Ponyta", Type = "Fire" },
            new Pokemon { Id = 78, Name = "Rapidash", Type = "Fire" },
            new Pokemon { Id = 79, Name = "Slowpoke", Type = "Water/Psychic" },
            new Pokemon { Id = 80, Name = "Slowbro", Type = "Water/Psychic" },
            new Pokemon { Id = 81, Name = "Magnemite", Type = "Electric/Steel" },
            new Pokemon { Id = 82, Name = "Magneton", Type = "Electric/Steel" },
            new Pokemon { Id = 83, Name = "Farfetch'd", Type = "Normal/Flying" },
            new Pokemon { Id = 84, Name = "Doduo", Type = "Normal/Flying" },
            new Pokemon { Id = 85, Name = "Dodrio", Type = "Normal/Flying" },
            new Pokemon { Id = 86, Name = "Seel", Type = "Water" },
            new Pokemon { Id = 87, Name = "Dewgong", Type = "Water/Ice" },
            new Pokemon { Id = 88, Name = "Grimer", Type = "Poison" },
            new Pokemon { Id = 89, Name = "Muk", Type = "Poison" },
            new Pokemon { Id = 90, Name = "Shellder", Type = "Water" },
            new Pokemon { Id = 91, Name = "Cloyster", Type = "Water/Ice" },
            new Pokemon { Id = 92, Name = "Gastly", Type = "Ghost/Poison" },
            new Pokemon { Id = 93, Name = "Haunter", Type = "Ghost/Poison" },
            new Pokemon { Id = 94, Name = "Gengar", Type = "Ghost/Poison" },
            new Pokemon { Id = 95, Name = "Onix", Type = "Rock/Ground" },
            new Pokemon { Id = 96, Name = "Drowzee", Type = "Psychic" },
            new Pokemon { Id = 97, Name = "Hypno", Type = "Psychic" },
            new Pokemon { Id = 98, Name = "Krabby", Type = "Water" },
            new Pokemon { Id = 99, Name = "Kingler", Type = "Water" },
            new Pokemon { Id = 100, Name = "Voltorb", Type = "Electric" },
            new Pokemon { Id = 101, Name = "Electrode", Type = "Electric" },
            new Pokemon { Id = 102, Name = "Exeggcute", Type = "Grass/Psychic" },
            new Pokemon { Id = 103, Name = "Exeggutor", Type = "Grass/Psychic" },
            new Pokemon { Id = 104, Name = "Cubone", Type = "Ground" },
            new Pokemon { Id = 105, Name = "Marowak", Type = "Ground" },
            new Pokemon { Id = 106, Name = "Hitmonlee", Type = "Fighting" },
            new Pokemon { Id = 107, Name = "Hitmonchan", Type = "Fighting" },
            new Pokemon { Id = 108, Name = "Lickitung", Type = "Normal" },
            new Pokemon { Id = 109, Name = "Koffing", Type = "Poison" },
            new Pokemon { Id = 110, Name = "Weezing", Type = "Poison" },
            new Pokemon { Id = 111, Name = "Rhyhorn", Type = "Ground/Rock" },
            new Pokemon { Id = 112, Name = "Rhydon", Type = "Ground/Rock" },
            new Pokemon { Id = 113, Name = "Chansey", Type = "Normal" },
            new Pokemon { Id = 114, Name = "Tangela", Type = "Grass" },
            new Pokemon { Id = 115, Name = "Kangaskhan", Type = "Normal" },
            new Pokemon { Id = 116, Name = "Horsea", Type = "Water" },
            new Pokemon { Id = 117, Name = "Seadra", Type = "Water" },
            new Pokemon { Id = 118, Name = "Goldeen", Type = "Water" },
            new Pokemon { Id = 119, Name = "Seaking", Type = "Water" },
            new Pokemon { Id = 120, Name = "Staryu", Type = "Water" },
            new Pokemon { Id = 121, Name = "Starmie", Type = "Water/Psychic" },
            new Pokemon { Id = 122, Name = "Mr. Mime", Type = "Psychic/Fairy" },
            new Pokemon { Id = 123, Name = "Scyther", Type = "Bug/Flying" },
            new Pokemon { Id = 124, Name = "Jynx", Type = "Ice/Psychic" },
            new Pokemon { Id = 125, Name = "Electabuzz", Type = "Electric" },
            new Pokemon { Id = 126, Name = "Magmar", Type = "Fire" },
            new Pokemon { Id = 127, Name = "Pinsir", Type = "Bug" },
            new Pokemon { Id = 128, Name = "Tauros", Type = "Normal" },
            new Pokemon { Id = 129, Name = "Magikarp", Type = "Water" },
            new Pokemon { Id = 130, Name = "Gyarados", Type = "Water/Flying" },
            new Pokemon { Id = 131, Name = "Lapras", Type = "Water/Ice" },
            new Pokemon { Id = 132, Name = "Ditto", Type = "Normal" },
            new Pokemon { Id = 133, Name = "Eevee", Type = "Normal" },
            new Pokemon { Id = 134, Name = "Vaporeon", Type = "Water" },
            new Pokemon { Id = 135, Name = "Jolteon", Type = "Electric" },
            new Pokemon { Id = 136, Name = "Flareon", Type = "Fire" },
            new Pokemon { Id = 137, Name = "Porygon", Type = "Normal" },
            new Pokemon { Id = 138, Name = "Omanyte", Type = "Rock/Water" },
            new Pokemon { Id = 139, Name = "Omastar", Type = "Rock/Water" },
            new Pokemon { Id = 140, Name = "Kabuto", Type = "Rock/Water" },
            new Pokemon { Id = 141, Name = "Kabutops", Type = "Rock/Water" },
            new Pokemon { Id = 142, Name = "Aerodactyl", Type = "Rock/Flying" },
            new Pokemon { Id = 143, Name = "Snorlax", Type = "Normal" },
            new Pokemon { Id = 144, Name = "Articuno", Type = "Ice/Flying" },
            new Pokemon { Id = 145, Name = "Zapdos", Type = "Electric/Flying" },
            new Pokemon { Id = 146, Name = "Moltres", Type = "Fire/Flying" },
            new Pokemon { Id = 147, Name = "Dratini", Type = "Dragon" },
            new Pokemon { Id = 148, Name = "Dragonair", Type = "Dragon" },
            new Pokemon { Id = 149, Name = "Dragonite", Type = "Dragon/Flying" },
            new Pokemon { Id = 150, Name = "Mewtwo", Type = "Psychic" },
            new Pokemon { Id = 151, Name = "Mew", Type = "Psychic" }
        };
    }
}

