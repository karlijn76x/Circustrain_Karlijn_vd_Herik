using System;
using Circustrain_Karlijn_vd_Herik;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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

        [TestMethod]
        public void TryAddAnimal_CheckIfWagonHasOneMeatEatersAndOnePlantEater_ShouldReturnTrue()
        {
            // Arrange
            var initialAnimals = new List<Animal> { new Animal(AnimalSize.Large, false) };
            var wagon = new Wagon(initialAnimals);
            var newAnimal = new Animal(AnimalSize.Small, true);

            // Act
            var result = wagon.TryAddAnimal(newAnimal);

            // Assert
            Assert.IsTrue(result, "Expected TryAddAnimal to return true.");

            var meatEatersCount = wagon.Animals.Count(animal => animal.EatsMeat);
            var plantEatersCount = wagon.Animals.Count(animal => !animal.EatsMeat);

            Assert.AreEqual(1, meatEatersCount, "Expected one meat eater in the wagon.");
            Assert.AreEqual(1, plantEatersCount, "Expected one plant eater in the wagon.");
        }

    }
}
