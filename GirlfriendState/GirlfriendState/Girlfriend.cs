namespace GirlfriendState
{
    class Girlfriend // This is the Context class
    {
        // Start off not too hungry; very happy; not mad. Let's see how long it lasts.
        private int hunger = 5;     // 0 is very full; 10 is very hungry
        private int happiness = 10; // 0 is very sad; 10 is very happy
        private int anger = 0;      // 0 is not angry; 10 is very angry

        private Mood mood = new Happy();

        public void feed()
        {
            int[] changes = mood.reactToBeingFed();
            handleChanges(changes);
            switchMood();
        }

        public void compliment()
        {
            int[] changes = mood.reactToCompliment();
            handleChanges(changes);
            switchMood();
        }

        public void antagonize()
        {
            int[] changes = mood.reactToBeingAntagonized();
            handleChanges(changes);
            switchMood();
        }

        public void ignore()
        {
            int[] changes = mood.reactToBeingIgnored();
            handleChanges(changes);
            switchMood();
        }

        public override string ToString()
        {
            return "Your girlfriend " + mood.ToString() 
                + ".\nHer hunger is " + hunger + "/10.\nHer happiness is " 
                + happiness + "/10.\nHer anger is " + anger + "/10.";
        }

        private void switchMood()
        {
            if (hunger <= 3)
                mood = new FeelsFat();
            else if (happiness <= 3)
                mood = new Sad();
            else if (anger >= 7)
                mood = new Mad();
            else if (happiness >= 7)
                mood = new Happy();
        }
        
        // Handles changes to hunger, happiness, and anger.
        // The array of ints contains changes to each of those variables, in that order.
        private void handleChanges(int[] changes)
        {
            hunger += changes[0];
            happiness += changes[1];
            anger += changes[2];

            if (hunger > 10)
                hunger = 10;
            if (hunger < 0)
                hunger = 0;
            if (happiness > 10)
                happiness = 10;
            if (happiness < 0)
                happiness = 0;
            if (anger > 10)
                anger = 10;
            if (anger < 0)
                anger = 0;
        }
    }
}
