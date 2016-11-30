using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Tank : Role // This is a Concrete Decorator
    {
        const int DAMAGE_DIFF = -50;
        const int HEALTH_DIFF = 500;
        const int AMOUNT_TO_PROTECT = 50;
        Player player;

        public Tank(Player player) : base(player)
        {
            this.player = player;
        }

        public override int dealDamage(int diff)
        {
            return player.dealDamage(diff + DAMAGE_DIFF);
        }

        public override int takeDamage(int damage, int diff)
        {
            return player.takeDamage(damage, diff + AMOUNT_TO_PROTECT);
        }

        public override string ToString()
        {
            if (player.ToString().Contains("tank") || player.ToString().Contains("healer") || player.ToString().Contains("damage dealer"))
                return player.ToString() + " and a tank"; 
            else
                return player.ToString() + "a tank";
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
