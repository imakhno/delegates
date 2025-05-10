using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Character
    {
        public string Name { get; }
        public int Health { get; set; }
        public int BaseDamage { get; protected set; }

        public AttackDelegate Attack { get; protected set; }

        protected Character(string name, int health, int baseDamage)
        {
            Name = name;
            Health = health;
            BaseDamage = baseDamage;
        }

        public void PerformAttack(Character target)
        {
            Attack?.Invoke(target);
        }

        public void ChangeAttack(AttackDelegate newAttack)
        {
            Attack = newAttack;
        }
    }
}
