using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten;

        public Wuerfel(int anzahlSeiten)
        {
            this.anzahlSeiten = anzahlSeiten;
        }

        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }
    }
}