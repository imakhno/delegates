using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Warrior : Character
    {
        public Warrior(string name)
            : base(name, health: 100, baseDamage: 25)
        {
            Attack = SwordAttack;
        }

        private void SwordAttack(Character target)
        {
            int totalDamage = this.BaseDamage + new Random().Next(5);
            Console.WriteLine($"{this.Name} бьёт мечом {target.Name}а. Урон: {totalDamage}");
            target.Health -= totalDamage;
        }
    }
}
