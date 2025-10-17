namespace GameShotgunFinal.Classes
{
    public class Game
    {
        private Player player1;
        private Player player2;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public void ResetGame()
        {
            player1.Ammo = 0;
            player2.Ammo = 0;
        }

        public string PlayRound(string move1, string move2)
        {
            string result = "";

            // Display moves
            result += $"{player1.Name} chose: {move1}\n";
            result += $"{player2.Name} chose: {move2}\n";

            // Apply rules based on moves
            if (move1 == "Load" && move2 == "Load")
            {
                player1.Ammo++;
                player2.Ammo++;
                result += "Both players loaded a bullet.\n";
            }
            else if (move1 == "Load" && move2 == "Block")
            {
                player1.Ammo++;
                result += $"{player1.Name} loaded a bullet, {player2.Name} blocked.\n";
            }
            else if(move1 == "Block" && move2 == "Load")
            {
                player2.Ammo++;
                result += $"{player2.Name} loaded a bullet, {player1.Name} blocked.\n";
            }

            else if (move1 == "Block" && move2 == "Block")
            {
                result += "Both players blocked. Nothing happens.\n";
            }
            else if (move1 == "Shoot" && move2 == "Block")
            {
                if (player1.Ammo > 0)
                {
                    player1.Ammo--;
                    result += $"{player1.Name} shot but {player2.Name} blocked.\n";
                }
                else
                {
                    result += $"{player1.Name} tried to shoot but had no bullets!\n";
                }
            }
            else if (move1 == "Block" && move2 == "Shoot")
            {
                if (player2.Ammo > 0)
                {
                    player2.Ammo--;
                    result += $"{player2.Name} shot but {player1.Name} blocked.\n";
                }
                else
                {
                    result += $"{player2.Name} tried to shoot but had no bullets!\n";
                }
            }
            else if (move1 == "Shoot" && move2 == "Shoot")
            {
                if (player1.Ammo > 0 && player2.Ammo > 0)
                {
                    player1.Ammo--;
                    player2.Ammo--;
                    result += "Both players shot and lost one bullet.\n";
                }
                
            }
            else if (move1 == "Shoot" && move2 == "Load")
            {
                if (player1.Ammo > 0)
                {
                    result += $"{player1.Name} shot and won the game!\n";
                    ResetGame();
                    return result;
                }
                else
                {
                    result += $"{player1.Name} tried to shoot but had no bullets!\n";
                }
            }
            else if (move1 == "Load" && move2 == "Shoot")
                if (player2.Ammo > 0)
                {
                    result += $"{player2.Name} shot and won the game!\n";
                    ResetGame();
                    return result;
                }
                else
                {
                    result += $"{player2.Name} tried to shoot but had no bullets!\n";
                }

            //  Shotgun condition
            if (player1.Ammo >= 3 && move1 == "Shotgun")
            {
                result += $"{player1.Name} used Shotgun and won!\n";
                ResetGame();
                return result;

            }

            if (player2.Ammo >= 3 && move2 == "Shotgun")
            {
                result += $"{player2.Name} used Shotgun and won!\n";
                ResetGame();
                return result;
                
            }

            result += $"{player1.Name} Ammo: {player1.Ammo}, {player2.Name} Ammo: {player2.Ammo}\n";
            return result;
        }
    }
}
