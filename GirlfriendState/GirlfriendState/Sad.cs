namespace GirlfriendState
{
    public class Sad : Mood  // This is a concrete state
    {
        public override int[] reactToBeingAntagonized()
        {
            return new int[3] { 1, -4, 1 };
        }

        public override int[] reactToBeingFed()
        {
            return new int[3] { -2, 1, -1 };
        }

        public override int[] reactToBeingIgnored()
        {
            return new int[3] { 1, -3, 1 };
        }

        public override int[] reactToCompliment()
        {
            return new int[3] { 1, 3, -3 };
        }

        public override string ToString()
        {
            return "is sad";
        }
    }
}
