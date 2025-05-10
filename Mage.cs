using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test
{
    internal class Mage : Character
    {
        public int Mana { get; private set; }
        public Mage(string name) : base(name, health: 120, baseDamage: 45)
        {
            Mana = 10;
            Attack = FireAttack; // Дефолтная атака
        }

        private void FireAttack(Character target)
        {
            if (Mana < 20)
            {
                Console.WriteLine("Недостаточно маны для атаки огнём");
                return;
            }

            Mana -= 20;
            Console.WriteLine($"{this.Name} выпускает огненный шар в {target.Name}а. Урон: {this.BaseDamage}");
            target.Health -= this.BaseDamage;
        }

        private void IceAttack(Character target)
        {
            if (Mana < 10)
            {
                Console.WriteLine("Недостаточно маны для атаки льдом.");
                return;
            }

            int iceDamage = this.BaseDamage + 5;
            Mana -= 10;
            Console.WriteLine($"{Name} запускает ледяную стрелу в {target.Name}а. Урон: {iceDamage}");
            target.Health -= iceDamage;
        }

        public void SetFireAttcak() => ChangeAttack(FireAttack);
        public void SetIceAttcak() => ChangeAttack(IceAttack);
    }
}
