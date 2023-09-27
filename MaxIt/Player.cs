namespace MaxIt
{
    public class Player
    {
        // Personal data
        public int Id { get; set; } = -1;
        public string Name { get; set; } = string.Empty;

        // Current game settings
        public int AiLevel { get; set; } = 0;
        public int TimerState { get; set; } = 0;
        public int Language { get; set; } = 0;
        
        // Statistics for Easy level
        public int EasyGamesPlayed { get; set; } = 0;
        public int EasyGamesWon { get; set; } = 0;
        public int EasyGamesLost { get; set; } = 0;
        public int EasyGamesDrawed { get; set; } = 0;
        public int EasyMaxScoreWon { get; set; } = 0;
        public int EasyMaxScoreLost { get; set; } = 0;
        public int EasyTotalTime { get; set; } = 0;
        public int EasyBestTime { get; set; } = 0;

        // Statistics for Medium level
        public int MediumGamesPlayed { get; set; } = 0;
        public int MediumGamesWon { get; set; } = 0;
        public int MediumGamesLost { get; set; } = 0;
        public int MediumGamesDrawed { get; set; } = 0;
        public int MediumMaxScoreWon { get; set; } = 0;
        public int MediumMaxScoreLost { get; set; } = 0;
        public int MediumTotalTime { get; set; } = 0;
        public int MediumBestTime { get; set; } = 0;

        // Statistics for Hard level
        public int HardGamesPlayed { get; set; } = 0;
        public int HardGamesWon { get; set; } = 0;
        public int HardGamesLost { get; set; } = 0;
        public int HardGamesDrawed { get; set; } = 0;
        public int HardMaxScoreWon { get; set; } = 0;
        public int HardMaxScoreLost { get; set; } = 0;
        public int HardTotalTime { get; set; } = 0;
        public int HardBestTime { get; set; } = 0;

        public override string ToString()
        {
            return Name;
        }
    }
}
