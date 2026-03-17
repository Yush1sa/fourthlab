using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace fourthlab
{
    public class Character { }

    public class Warrior : Character
    {
        public int health = 200;
        public int damage = 20;
        public int armor = 20;
    }

    public enum MageType {Fire, Water, Earth, Air}
    public class Mage : Character
    {
        public int health = 75;
        public int damage = 15;
        public int mana = 50;
        public MageType type = MageType.Air;
    }

    public class Archer : Character
    {
        public int health = 75;
        public int damage = 15;
        public int arrows = 15;
    }
}