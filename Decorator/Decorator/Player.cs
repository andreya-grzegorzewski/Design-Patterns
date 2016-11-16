using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Player // This is the Component class
    {
        /*
         * dealDamage returns the amount of damage dealt to the monster;
         * diff refers to the difference between the default damage dealt
         * and the actual damage dealt for the specific party member.
         */
        public abstract int dealDamage(int diff);

        /*
         * takeDamage returns the remaining health of the entire party;
         * damage is the amount of damage tha the monster deals
         * and diff is the amount of damage that is healed or protected from.
         */ 
        public abstract int takeDamage(int damage, int diff);

        // Returns the total health of the party.
        public abstract int getHealth();

        /*
         * Adds a new player to the party.
         * healthDiff is the difference between the default health value
         * and the actual health for the specific party member.
         */ 
        public abstract void addPlayer(int healthDiff);
    }
}
