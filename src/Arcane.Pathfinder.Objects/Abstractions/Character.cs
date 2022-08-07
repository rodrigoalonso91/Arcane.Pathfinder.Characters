using Arcane.Pathfinder.Characters.Models;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Abstractions
{
    public class Character
    {
        public string CharacterName { get; set; } = "Nameless";
        public string PlayerName { get; set; } = "Player";
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int HitDice { get; private set; }
        public int HeroPoints { get; set; }
        public BasicAttributes? CharacterAttributes { get; set; }
        public List<Skill>? CharacterSkills { get; set; }
        public Alignments Alignment { get; private set; }
    }
}