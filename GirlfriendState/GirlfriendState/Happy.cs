namespace GirlfriendState
{
    public class Happy : Mood // This is a concrete state
    {
        public override int[] reactToBeingAntagonized()
        {
            return new int[3] { 1, -1, 1 };
        }

        public override int[] reactToBeingFed()
        {
            return new int[3] { -2, 2, -2 };
        }

        public override int[] reactToBeingIgnored()
        {
            return new int[3] { 1, -1, 1 };
        }

        public override int[] reactToCompliment()
        {
            return new int[3] { 1, 4, -4 };
        }

        public override string ToString()
        {
            return "is happy";
        }
    }
}
