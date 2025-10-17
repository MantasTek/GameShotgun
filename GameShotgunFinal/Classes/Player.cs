namespace GameShotgunFinal.Classes
{
    public abstract class Player
    {   
        public string Name { get; set; }
        public int Ammo { get; set; }

        public Player(string name)
        {
        Name = name;
        Ammo = 0; // Starting with 0 ammo
        }

        public abstract string MakeMove();
    }
}
