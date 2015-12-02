using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior r2 = new Warrior(100, 10);
            Warrior Space = new Warrior(150, 20, 30);
            Console.WriteLine("Battle!");
            Console.WriteLine();
            int tmpAttackPower = 0;
            while (r2.HP > 0 && Space.HP > 0)
            {
                Console.WriteLine("-----------------");
                tmpAttackPower = r2.attackPower();
                Console.WriteLine("R2 attacked Space");
                Console.WriteLine("POWER: " + tmpAttackPower);
                Space.HP -= tmpAttackPower;
                tmpAttackPower = Space.attackPower();
                Console.WriteLine("Space attacked R2");
                Console.WriteLine("POWER: " + tmpAttackPower);
                r2.HP -= tmpAttackPower;

                Console.WriteLine("R2 HP: " + r2.HP);
                Console.WriteLine("Space HP: " + Space.HP);
            }
            Console.WriteLine("-----------------");
            if (r2.HP > Space.HP)
                Console.WriteLine("R2 Wins Today!");
            else if (r2.HP < Space.HP)
                Console.WriteLine("Space is victorious!");
            else
                Console.WriteLine("It's a tie!");
            Console.ReadKey();
        }
    }
}
