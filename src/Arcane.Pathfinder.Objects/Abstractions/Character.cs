using Arcane.Pathfinder.Objects.Utils;

namespace Arcane.Pathfinder.Objects.Abstractions
{
    public abstract class Character
    {
        private int Strength = 10;
        private int Dexterity = 10;
        private int Constitution = 10;
        private int Intelligence = 10;
        private int Wisdom = 10;
        private int Charisma = 10;

        public string CharacterName { get; set; } = "Nameless";
        public string PlayerName { get; set; } = "Player";
        public CharacterSize Size { get; set; }
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int HitDice { get; private set; }
        public int HeroPoints { get; set; }
        public Alignments Alignment { get; private set; }
    }
}