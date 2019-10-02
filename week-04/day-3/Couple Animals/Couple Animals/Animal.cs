using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couple_Animals
{
    abstract class Animal
    {
        public AnimalType Name { get; protected set; }
        public int Age { get; protected set; }
        public GenderType Gender { get; protected set; }
        public abstract void Greet();
        public abstract void WantChild();
        public abstract void Move();
        public abstract void Sound();
        public enum GenderType
        {
            Male,
            Female
        }
        public enum AnimalType
        {
            Crocodile,
            Frog,
            Penguin,
            Parrot,
            Ostrich,
            Koala,
            Duck,
            Eagle,
            Bear,
            Lion,
            Tiger,
        }
    }
}
