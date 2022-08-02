using Arcane.Pathfinder.Objects.Utils;

namespace Arcane.Pathfinder.Objects.Abstractions
{
    public abstract class Character
    {
        private readonly int Strength;
        private readonly int Dexterity;

        public string CharacterName { get; set; } = "Nameless";
        public string PlayerName { get; set; } = "Player";
        public CharacterSize Size { get; set; }
    }
}