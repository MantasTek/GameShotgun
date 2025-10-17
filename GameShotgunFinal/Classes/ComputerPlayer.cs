namespace GameShotgunFinal.Classes
{
    public class ComputerPlayer : Player
    {
        private Random random;

        public ComputerPlayer(string name) : base(name)
        {
            random = new Random();
        }


        public override string MakeMove()
        {
            if(Ammo >= 3)
            {
                return "Shotgun";
            }

            int choice = random.Next(3);
            switch (choice)
            {
                case 0:
                    if(Ammo > 0)
                        return "Shoot";
                    else
                        return MakeMove();

                case 1:
                    return "Load";

                case 2:
                    return "Block";

                default:
                    return "Block";

            }

        }
    }
}
