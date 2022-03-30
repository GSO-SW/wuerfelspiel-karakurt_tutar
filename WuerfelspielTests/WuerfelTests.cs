using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;
using System;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        public void Wuerfel_KonstruktorWerteTest()
        {
            // arrange
            Wuerfel wuerfel = new Wuerfel(6);
            int anzahlSeitenErgebnis = 6;

            // act

            // assert
            Assert.AreEqual(wuerfel.AnzahlSeiten, anzahlSeitenErgebnis);
        }
    }
}