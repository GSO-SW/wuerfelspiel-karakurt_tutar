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
            int anzahlSeitenTest = 6;
            int anzahlSeitenErgebnis = 6;

            // act
            Wuerfel wuerfel = new Wuerfel(anzahlSeitenTest);

            // assert
            Assert.AreEqual(wuerfel.AnzahlSeiten, anzahlSeitenErgebnis);
            // test commit (samet)
        }
    }
}