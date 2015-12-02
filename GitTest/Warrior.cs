using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Warrior
    {
        public int HP { get; set; }
        public int attack { get; set; }
        private int attackPrecision { get; set; }

        public Warrior(int HP, int attack)
        {
            this.HP = HP;
            this.attack = attack;
            this.attackPrecision = 0;
        }

        public Warrior(int HP, int attack, int attackPrecision)
        {
            this.HP = HP;
            this.attack = attack;
            this.attackPrecision = attackPrecision;
        }

        public int attackPower()
        {
            if (attack - RandomGenerator.NextInt(attackPrecision) < 0)
            {
                return 1;
            } else {
                return attack - RandomGenerator.NextInt(attackPrecision);
            }
        }
    }
}
