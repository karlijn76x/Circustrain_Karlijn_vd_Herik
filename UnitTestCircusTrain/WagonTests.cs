using System;
using Circustrain_Karlijn_vd_Herik;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCircusTrain
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]

        public void TryAddAnimal_EnoughRoomAndFriendly_returnsTrue()
        {
            //arrange
            var wagon = new Wagon(new List<Animal> { new Animal(AnimalSize.Small, false) });
            var newAnimal = new Animal(AnimalSize.Medium, false);

            //act
            var result = wagon.TryAddAnimal(newAnimal);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TryAddAnimal_NotFriendly_ReturnsFalse()
        {
            //arrange 
            var wagon = new Wagon(new List<Animal> { new Animal(AnimalSize.Large, true) });
            var newAnimal = new Animal(AnimalSize.Medium, false);

            //act
            var result = wagon.TryAddAnimal(newAnimal);

            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TryAddAnimal_TwoNotFriendly_ReturnsFalse()
        {
            //arrange 
            var wagon = new Wagon(new List<Animal> { new Animal(AnimalSize.Large, true) });
            var newAnimal = new Animal(AnimalSize.Large, true);

            //act
            var result = wagon.TryAddAnimal(newAnimal);

            //assert
            Assert.IsFalse(result);
        }
    }
}
