using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DamageDealer : Role // This is a Concrete Decorator
    {
        const int DAMAGE_DIFF = 250;
        const int HEALTH_DIFF = 0;
        Player player;

        public DamageDealer(Player player) : base(player)
        {
            this.player = player;
        }
        
        public override int dealDamage(int diff)
        {
            return player.dealDamage(diff + DAMAGE_DIFF);
        }

        public override int takeDamage(int damage, int diff)
        {
            return player.takeDamage(damage, diff);
        }

        public override string ToString()
        {
            if (player.ToString().Contains("tank") || player.ToString().Contains("healer") || player.ToString().Contains("damage dealer"))
                return player.ToString() + " and a damage dealer";
            else
                return player.ToString() + "a damage dealer";
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
