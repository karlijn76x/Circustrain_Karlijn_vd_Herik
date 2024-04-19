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
        private List<Animal> animals;
        public IReadOnlyList<Animal> Animals => animals; //private/readonly gemaakt

        public Wagon(List<Animal> animals = null) //zorgt ervoor dat de animals-variabele altijd een geldige lijst is om mee te werken,ook als deze leeg zou zijn                                        
        {
            this.animals = animals ?? new List<Animal>();
        }

        public bool TryAddAnimal(Animal newAnimal)
        {
            if (EnoughRoomForAnimal(newAnimal))
            {
                if (Animals.Any(animal => !animal.IsFriendlyAnimal(newAnimal)))
                {
                    return false;
                }
                animals.Add(newAnimal);
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
