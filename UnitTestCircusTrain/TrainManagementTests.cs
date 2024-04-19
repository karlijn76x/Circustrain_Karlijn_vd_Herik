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
        //Helpermethode die input list of wagons -> list animal 
        public List<Animal> GetAllAnimalsInWagons(IReadOnlyList<Wagon> wagons)
        {
            var allAnimals = new List<Animal>();
            foreach (var wagon in wagons)
            {
                allAnimals.AddRange(wagon.Animals);
            }
            return allAnimals;
        }

        [TestMethod]
        public void TryAddListOfAnimals_ScenarioOne_ShouldBeTwoWagons()
        {
            //Arrange
            var trainManagement = new TrainManagement();
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
            trainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(2, trainManagement.Wagons.Count);

            //CollectionAssert
            var animalsInWagons = GetAllAnimalsInWagons(trainManagement.Wagons);
            CollectionAssert.AllItemsAreInstancesOfType(animalsInWagons, typeof(Animal));
        }

        [TestMethod]
        public void TryAddListOfAnimals_ScenarioTwo_ShouldBeTwoWagons()
        {
            //Arrange
            var trainManagement = new TrainManagement();
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
            trainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(2, trainManagement.Wagons.Count);

            //CollectionAssert
            var animalsInWagons = GetAllAnimalsInWagons(trainManagement.Wagons);
            CollectionAssert.AllItemsAreInstancesOfType(animalsInWagons, typeof(Animal));

        }

        [TestMethod]
        public void TryAddListOfAnimals_ScenarioThree_ShouldFourTwoWagons()
        {
            //Arrange
            var trainManagement = new TrainManagement();
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
            trainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(4, trainManagement.Wagons.Count);

            //CollectionAssert
            var animalsInWagons = GetAllAnimalsInWagons(trainManagement.Wagons);
            CollectionAssert.AllItemsAreInstancesOfType(animalsInWagons, typeof(Animal));

        }

        [TestMethod]
        public void TryAddListOfAnimals_ScenarioFour_ShouldBeFiveWagons()
        {
            //Arrange
            var trainManagement = new TrainManagement();
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
            trainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(5, trainManagement.Wagons.Count);

            //CollectionAssert
            var animalsInWagons = GetAllAnimalsInWagons(trainManagement.Wagons);
            CollectionAssert.AllItemsAreInstancesOfType(animalsInWagons, typeof(Animal));
        }

        [TestMethod]
        public void TryAddListOfAnimals_ScenarioFive_ShouldBeZeroWagons() //lege lijst of Animals
        {
            //Arrange
            var trainManagement = new TrainManagement();
            var AnimalsToAdd = new List<Animal>
            {
          
            };
            //Act
            trainManagement.AddAnimalsToTrain(AnimalsToAdd);

            //Assert
            Assert.AreEqual(0, trainManagement.Wagons.Count);

            //CollectionAssert
            var animalsInWagons = GetAllAnimalsInWagons(trainManagement.Wagons);
            CollectionAssert.AllItemsAreInstancesOfType(animalsInWagons, typeof(Animal));
        }
    }
}
