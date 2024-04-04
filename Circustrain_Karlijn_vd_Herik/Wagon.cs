using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain_Karlijn_vd_Herik
{
    public class Wagon
    {
        private int TotalCapacity = 10;

        public List<Animal> Animals { get; set; }

        public Wagon(List<Animal> animals = null)
        {
            Animals = animals ?? new List<Animal>();
        }

        public bool TryAddAnimal(Animal newAnimal)
        {
            if (EnoughRoomForAnimal(newAnimal))
            {
                if (Animals.Any(animal => !animal.IsFriendlyAnimal(newAnimal)))
                {
                    return false;
                }
                Animals.Add(newAnimal);
                return true;
            }
            return false;
        }


        public bool EnoughRoomForAnimal(Animal newAnimal)
        {
            return Animals.Sum(a => (int)a.Size) + (int)newAnimal.Size <= TotalCapacity;
        }
    }
}

        

