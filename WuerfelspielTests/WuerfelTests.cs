using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_KonstruktorTest()
        {
            //Arrange
            int anzahlSeiten = 6;
            Wuerfel w = new Wuerfel(anzahlSeiten);
            //Act
          
            //Assert
            Assert.AreEqual(6, w.anzahlSeiten)
                //push test
        }
        [TestMethod]
        public void LetztesErgebnisTest()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void SicherungUmschaltenTest()
        {

        }
    }
}
