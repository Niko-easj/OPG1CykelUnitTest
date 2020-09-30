using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CykelUnitTest
{
    public class Cykel
    {
        private int _id; 
        private string _farve;
        private double _pris;
        private int _gear;

        public Cykel()
        {
                
        }

        public Cykel(int id, string farve, double pris, int gear)
        {
            _id = id;
            _farve = farve;
            _pris = pris;
            _gear = gear;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        // Farve skal mindst være et tegn lang
        public string Farve
        {
            get => _farve;
            set
            {
                // Hvis farven ikke har et tegn, smid exception.
                if (value.Length < 1) throw new ArgumentOutOfRangeException();
                _farve = value;
            }
        }

        // Prisen skal være > 0
        public double Pris
        {
            get => _pris;
            set
            {
                // Hvis prisen ikke er over 0 kroner, smid en exception. Ingen gratis cykler.
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _pris = value;
            }
        }

        // Gear på cyklen skal gå fra "3 <= gear <= 32"
        public int Gear
        {
            get => _gear;
            set
            {
                // Hvis cyklen har mellem 3 & 32 gear, bliver det accepteret. Alt under eller over, smid exception.
                if (value < 3 || value > 32) throw new ArgumentOutOfRangeException();
                _gear = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Farve)}: {Farve}, {nameof(Pris)}: {Pris}, {nameof(Gear)}: {Gear}";
        }
    }
}
