using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Archer : Character
    {
        public Archer(string name)
            : base(name, health: 80, baseDamage: 15)
        {
            Attack = BowAttack;
        }

        private void BowAttack(Character target)
        { 
            Console.WriteLine($"{Name} стреляет в {target.Name}а. Урон: {this.BaseDamage}");
            target.Health -= this.BaseDamage;
        }
    }
}
