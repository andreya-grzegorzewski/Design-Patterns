using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Role : Player // This is the Decorator class
    {
        Player player;

        public Role(Player player)
        {
            this.player = player;
        }

        public override int getHealth()
        {
            return player.getHealth();
        }

        public override void addPlayer(int healthDiff)
        {
            player.addPlayer(healthDiff);
        }
    }
}
