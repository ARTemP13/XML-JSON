using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest06
{
    internal class Fleet
    {
        public string Name {  get; private set; }
        public TypeShip TypeShip { get; private set; }
        public int YearBuilt { get; private set; }
        public double Speed { get; private set; }
        public int CrewCount { get; private set; }
        public Fleet(string name, TypeShip typeShip, int yearBuilt, double speed, int crewCount)
        {
            Name = name;
            TypeShip = typeShip;
            YearBuilt = yearBuilt;
            Speed = speed;
            CrewCount = crewCount;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    enum TypeShip
    {
        Военный, 
        Пассажирский, 
        Грузовой,
    }
}
