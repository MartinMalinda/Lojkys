using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public enum PokemonType
    {
        Leaf,
        Electric,
        Fire,
        Water
    }

    class Pokemon
    {
        public string Name { get; private set; }
        public PokemonType Type { get; private set; }
        public PokemonType EffectiveAgainst { get; private set; }

        public Pokemon(string name, PokemonType type, PokemonType effectiveAgainst)
        {
            Name = name;
            Type = type;
            EffectiveAgainst = effectiveAgainst;
        }

        public bool IsEffectiveAgainst(Pokemon anotherPokemon)
        {
                return EffectiveAgainst == anotherPokemon.Type;           
        }
    }
}