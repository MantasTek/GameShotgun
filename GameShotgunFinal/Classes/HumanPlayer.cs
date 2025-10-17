namespace GameShotgunFinal.Classes
{
    public class HumanPlayer : Player
    {
        private string currentMove = string.Empty;

        public HumanPlayer(string name) : base(name) { }

        public void SetMove(string move)
        {
            currentMove = move;
        }

        public override string MakeMove()
        {
            return currentMove;
        }
    }
}
