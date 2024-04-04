using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrain_Karlijn_vd_Herik;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCircusTrain
{
    [TestClass]
    public class TrainManagementTests
    {
        [TestMethod]
        public void TryAddListOfAnimals_ShouldBeTwoWagons_ScenarioOne()
        {
            //Arrange
            var TrainManagement = new TrainManagement();
            var AnimalsToAdd = new List<Animal> 
            {
                new Animal(AnimalSize.Small, true),
                new Animal(AnimalSize.Large, false),
                new Animal(AnimalSize.Large, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Medium, false),
            };
            //Act
            TrainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(2, TrainManagement.Wagons.Count);
            
        }

        [TestMethod]
        public void TryAddListOfAnimals_ShouldBeTwoWagons_ScenarioTwo()
        {
            //Arrange
            var TrainManagement = new TrainManagement();
            var AnimalsToAdd = new List<Animal>
            {
                new Animal(AnimalSize.Small, true),
                new Animal(AnimalSize.Large, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Small, false),
                new Animal(AnimalSize.Small, false),
                new Animal(AnimalSize.Small, false),
                new Animal(AnimalSize.Small, false),
                new Animal(AnimalSize.Small, false),
            };
            //Act
            TrainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(2, TrainManagement.Wagons.Count);

        }
        [TestMethod]
        public void TryAddListOfAnimals_ShouldFourTwoWagons_ScenarioThree()
        {
            //Arrange
            var TrainManagement = new TrainManagement();
            var AnimalsToAdd = new List<Animal>
            {
                new Animal(AnimalSize.Small, true),
                new Animal(AnimalSize.Medium, true),
                new Animal(AnimalSize.Large, true),
                new Animal(AnimalSize.Small, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Large, false),
            };
            //Act
            TrainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(4, TrainManagement.Wagons.Count);

        }
        [TestMethod]
        public void TryAddListOfAnimals_ShouldBeFiveWagons_ScenarioFour()
        {
            //Arrange
            var TrainManagement = new TrainManagement();
            var AnimalsToAdd = new List<Animal>
            {
                new Animal(AnimalSize.Small, true),
                new Animal(AnimalSize.Medium, true),
                new Animal(AnimalSize.Large, true),
                new Animal(AnimalSize.Large, true),
                new Animal(AnimalSize.Small, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Medium, false),
                new Animal(AnimalSize.Large, false),
            };
            //Act
            TrainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(5, TrainManagement.Wagons.Count);

        }

    }
}
