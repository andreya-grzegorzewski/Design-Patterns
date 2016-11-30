using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Party : Player // This is the ConcreteComponent class
    {
        int health = 0;
        int damageToDeal = 0;

        public override int dealDamage(int diff)
        {
            return damageToDeal + diff;
        }

        public override int takeDamage(int damage, int diff)
        {
            health += diff - damage;
            return health;
        }

        public override string ToString()
        {
            return "";
        }

        public override int getHealth()
        {
            return health;
        }

        public override void addPlayer(int healthDiff)
        {
            health += 300 + healthDiff; 
            damageToDeal += 100;
        }
    }
}
