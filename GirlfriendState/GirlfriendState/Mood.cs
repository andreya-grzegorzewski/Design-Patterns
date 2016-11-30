namespace GirlfriendState
{
    public abstract class Mood // This is the State interface
    {
        /* Each of the following methods returns an array of 3 ints.
         * The first one represents the change in hunger,
         * the second is the change in happiness, 
         * and the third is the change in anger.
         * Hunger, happiness, and anger are all represented
         * in the Girlfriend class as ints in the range [0, 10].
         */

        public abstract int[] reactToBeingFed();
        public abstract int[] reactToCompliment();
        public abstract int[] reactToBeingAntagonized();
        public abstract int[] reactToBeingIgnored();
    }
}
