using Arcane.Pathfinder.Objects.Utils;

namespace Arcane.Pathfinder.Objects.Abstractions
{
    public abstract class Character
    {
        // Hola
        private readonly int Strength;
        private readonly int Dexterity;

        public string CharacterName { get; set; } = "Nameless";
        public string PlayerName { get; set; } = "Player";
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int HitDice { get; private set; }
        public int HeroPoints { get; set; }
        public Alignments Alignment { get; private set; }
        public CharacterSize Size { get; set; }
    }
}
