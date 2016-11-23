namespace GirlfriendState
{
    public class Mad : Mood // This is a concrete state
    {
        public override int[] reactToBeingAntagonized()
        {
            return new int[3] { 1, -1, 4 };
        }

        public override int[] reactToBeingFed()
        {
            return new int[3] { -2, 1, -1 };
        }

        public override int[] reactToBeingIgnored()
        {
            return new int[3] { 1, -1, 3 };
        }

        public override int[] reactToCompliment()
        {
            return new int[3] { 1, 2, -2 };
        }

        public override string ToString()
        {
            return "is mad";
        }
    }
}
