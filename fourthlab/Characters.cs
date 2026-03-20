using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace fourthlab
{
    
    public class Character {
        protected static Random rnd = new Random();
        public int health = 100;
        public int damage = 10;
        public virtual String GetInfo()
        {
            var str = $"\nЗдоровье: {this.health} \nУрон: {this.damage}";
            return str;
        }
    
    }

    public class Warrior : Character
    {
        public int armor = 20;

        public override string GetInfo()
        {
            var str = "Я воин";
            str += base.GetInfo();
            str += $"\nБроня: {this.armor}";
            return str;
        }

        public static Warrior Generate()
        {
            return new Warrior
            {
                health = 100 + rnd.Next() % 200,
                damage = 10 + rnd.Next() % 30,
                armor = 5 + rnd.Next() % 50
            };
        }
    }

    public enum MageType {Fire, Water, Earth, Air }

    public class Mage : Character
    {
        public int mana = 50;
        public MageType type = MageType.Fire;

        public override string GetInfo()
        {
            var names = new Dictionary<MageType, string>
            {
                [MageType.Fire] = "огня",
                [MageType.Water] = "воды",
                [MageType.Earth] = "земли",
                [MageType.Air] = "воздуха"
            };

            var str = $"Я маг {names[this.type]}";
            str += base.GetInfo();
            str += $"\nКол-во маны: {this.mana}";
            return str;
        }
        public static Mage Generate()
        {
            return new Mage
            {
                health = 100 + rnd.Next() % 100,
                damage = 10 + rnd.Next() % 30,
                mana = 5 + rnd.Next() % 50,
                type = (MageType)rnd.Next(4)
            };
        }
    }

    public class Archer : Character
    {
        public int arrows = 15;
        public float accuracy = 50;
        public override string GetInfo()
        {
            var str = $"Я лучник c точностью {this.accuracy}%";
            str += base.GetInfo();
            str += $"\nКол-во стрел: {this.arrows}";
            return str;
        }

        public static Archer Generate() {
            return new Archer
            {
                health = 50 + rnd.Next() % 100,
                damage = 10 + rnd.Next() % 30,
                accuracy = rnd.Next(10, 100),
                arrows = 5 + rnd.Next() % 30
            };
        }
    }
}