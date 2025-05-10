using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Рыцарь");
            Archer archer = new Archer("Лучник");
            Mage mage = new Mage("Волшебник");
            Warrior enemy = new Warrior("Орк");

            warrior.PerformAttack(enemy);
            archer.PerformAttack(enemy);

            Console.WriteLine($"Здоровье {enemy.Name}а. Урон: {enemy.Health}");
            Console.WriteLine(new string('-', 40));

            mage.PerformAttack(enemy);

            mage.SetIceAttcak();
            Console.WriteLine("Сменили стиль магии у волшебника.");
            mage.PerformAttack(enemy);

        }
    }
}
