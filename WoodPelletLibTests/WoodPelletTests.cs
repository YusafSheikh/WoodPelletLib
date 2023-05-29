using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoodPelletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPelletLib.Tests
{
    [TestClass()]
    public class WoodPelletTests
    {
        [TestMethod()]
        public void BrandMinimumLengthOf2()
        {
            var woodPellet = new WoodPellet() { Brand = "A" }; //arrange

            //Act and assert
            Assert.ThrowsException<ArgumentException>(() => woodPellet.Validate());
            // Forventer at en argument exception bliver kastet, hvis brand har mindre end 2 karakterer
        }

        [TestMethod()]
        public void QualityBetween1_and_5()
        {
            var woodPellet = new WoodPellet { Quality = 6 }; // Arrange

            Assert.ThrowsException<ArgumentException>(() => woodPellet.Validate());
            // Forventer at ArgumentException bliver kastet hvis quality er mindre end 1 og større end 5
            
        }
    }
}