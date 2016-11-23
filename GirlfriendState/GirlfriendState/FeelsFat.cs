namespace GirlfriendState
{
    public class FeelsFat : Mood // This is a concrete state
    {
        public override int[] reactToBeingAntagonized()
        {
            return new int[3] { 1, -2, 3 };
        }

        public override int[] reactToBeingFed()
        {
            return new int[3] { -2, -2, 4 };
        }

        public override int[] reactToBeingIgnored()
        {
            return new int[3] { 1, -3, 1 };
        }

        public override int[] reactToCompliment()
        {
            return new int[3] { 1, 1, -1 };
        }

        public override string ToString()
        {
            return "feels fat";
        }
    }
}
