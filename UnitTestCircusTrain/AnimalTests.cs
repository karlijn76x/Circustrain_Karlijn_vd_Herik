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
    public class AnimalTests
    {
        [TestMethod]
        public void IsLargeMeatEaterFriendly_ShouldReturnFalse()
        {
            //arrange
            var largeMeatEater = new Animal(AnimalSize.Large, true);
            var mediumMeatEater = new Animal(AnimalSize.Medium, true);
            var smallMeatEater = new Animal(AnimalSize.Small, true);

            var largePlantEater = new Animal(AnimalSize.Large, false);
            var mediumPlantEater = new Animal(AnimalSize.Medium, false);
            var smallPlantEater = new Animal(AnimalSize.Small, false);

            //act
            //asses
            Assert.IsFalse(largeMeatEater.IsFriendlyAnimal(largeMeatEater));
            Assert.IsFalse(largeMeatEater.IsFriendlyAnimal(mediumMeatEater));
            Assert.IsFalse(largeMeatEater.IsFriendlyAnimal(smallMeatEater));
            Assert.IsFalse(largeMeatEater.IsFriendlyAnimal(largePlantEater));
            Assert.IsFalse(largeMeatEater.IsFriendlyAnimal(mediumPlantEater));
            Assert.IsFalse(largeMeatEater.IsFriendlyAnimal(smallPlantEater));
        }
        [TestMethod]
        public void IsMediumMeatEaterFriendly_ShouldReturnFalse()
        {
            //arrange
            var largeMeatEater = new Animal(AnimalSize.Large, true);
            var mediumMeatEater = new Animal(AnimalSize.Medium, true);
            var smallMeatEater = new Animal(AnimalSize.Small, true);

            var largePlantEater = new Animal(AnimalSize.Large, false);
            var mediumPlantEater = new Animal(AnimalSize.Medium, false);
            var smallPlantEater = new Animal(AnimalSize.Small, false);

            //act
            //asses
            Assert.IsFalse(mediumMeatEater.IsFriendlyAnimal(mediumMeatEater));
            Assert.IsFalse(mediumMeatEater.IsFriendlyAnimal(smallMeatEater));
            Assert.IsFalse(mediumMeatEater.IsFriendlyAnimal(mediumPlantEater));
            Assert.IsFalse(mediumMeatEater.IsFriendlyAnimal(smallPlantEater));
        }
        [TestMethod]
        public void IsSmallMeatEaterFriendly_ShouldReturnFalse()
        {
            //arrange
            var largeMeatEater = new Animal(AnimalSize.Large, true);
            var mediumMeatEater = new Animal(AnimalSize.Medium, true);
            var smallMeatEater = new Animal(AnimalSize.Small, true);

            var largePlantEater = new Animal(AnimalSize.Large, false);
            var mediumPlantEater = new Animal(AnimalSize.Medium, false);
            var smallPlantEater = new Animal(AnimalSize.Small, false);

            //act
            //asses  
            Assert.IsFalse(smallMeatEater.IsFriendlyAnimal(smallMeatEater));
            Assert.IsFalse(smallMeatEater.IsFriendlyAnimal(smallPlantEater));
        }
        [TestMethod]
        public void IsMediumMeatEaterFriendly_ShouldReturnTrue()
        {
            //arrange
            var largeMeatEater = new Animal(AnimalSize.Large, true);
            var mediumMeatEater = new Animal(AnimalSize.Medium, true);
            var smallMeatEater = new Animal(AnimalSize.Small, true);

            var largePlantEater = new Animal(AnimalSize.Large, false);
            var mediumPlantEater = new Animal(AnimalSize.Medium, false);
            var smallPlantEater = new Animal(AnimalSize.Small, false);

            //act
            //asses
            Assert.IsTrue(mediumMeatEater.IsFriendlyAnimal(largePlantEater));
        }
        [TestMethod]
        public void IsSmallMeatEaterFriendly_ShouldReturnTrue()
        {
            //arrange
            var largeMeatEater = new Animal(AnimalSize.Large, true);
            var mediumMeatEater = new Animal(AnimalSize.Medium, true);
            var smallMeatEater = new Animal(AnimalSize.Small, true);

            var largePlantEater = new Animal(AnimalSize.Large, false);
            var mediumPlantEater = new Animal(AnimalSize.Medium, false);
            var smallPlantEater = new Animal(AnimalSize.Small, false);

            //act
            //asses
            Assert.IsTrue(smallMeatEater.IsFriendlyAnimal(mediumPlantEater));
        }
    }
}
