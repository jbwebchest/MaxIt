using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxIt
{
    public static class Enumerations
    {
        public enum GameMode
        {
            None,
            Intro,
            Menu,
            Play,
            Rules,
            Settings,
            Records
        }

        public enum LabelRole
        {
            Label,
            Button,
            Option
        }

        public enum AiLevel 
        {
            Easy,
            Normal,
            Hard
        }

        public enum Direction
        {
            Across,
            Down
        }
    }
}
