using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Healer : Role // This is a Concrete Decorator
    {
        const int HEALTH_DIFF = -200;
        const int AMOUNT_TO_HEAL = 100;
        const int DAMAGE_DIFF = -100;
        Player player;

        public Healer(Player player) : base(player)
        {
            this.player = player;
        }

        public override int dealDamage(int diff)
        {
            return player.dealDamage(diff + DAMAGE_DIFF);
        }

        public override int takeDamage(int damage, int diff)
        {
            return player.takeDamage(damage, diff + AMOUNT_TO_HEAL);
        }

        public override string ToString()
        {
            if (player.ToString().Contains("tank") || player.ToString().Contains("healer") || player.ToString().Contains("damage dealer"))
                return player.ToString() + " and a healer";
            else
                return player.ToString() + "a healer"; 
        }

        public override int getHealth()
        {
            return base.getHealth();
        }

        public int getHealthDiff()
        {
            return HEALTH_DIFF;
        }
    }
}
