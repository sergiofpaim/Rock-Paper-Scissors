namespace RockPaperScissors
{
    public class Choice
    {   
        public static Choice Rock = new Choice();
        public static Choice Scissors = new Choice();
        public static Choice Paper = new Choice();

        public static void Initialize()
        {
            Rock.BeatsYou(Paper);
            Paper.BeatsYou(Scissors);
            Scissors.BeatsYou(Rock);
        }

        private Choice BeatMe;

        private void BeatsYou(Choice choice) 
        {
            BeatMe = choice;
        }

        public int Match(Choice choice)
        {
            if (choice == this)
                return 0;
            else if (choice == BeatMe)
                return 1;
            else
                return -1;
        }
    }
}
