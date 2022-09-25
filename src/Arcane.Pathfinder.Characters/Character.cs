using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Skills;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters
{
    public class Character
    {
        public string CharacterName { get; set; } = "Nameless";
        public string PlayerName { get; set; } = "Player";
        public int Level { get; private set; } = 1;
        public int Experience { get; private set; } = 0;
        public int HitDice { get; private set; }
        public int HeroPoints { get; set; }
        public int BasicAttack { get; set; }
        public BasicAttributes CharacterAttributes { get; set; } = new();
        public List<Skill>? CharacterSkills { get; set; }
        public Alignments Alignment { get; private set; }

        public int GetInitiativeMod(int otherMods = 0)
        {
            return CharacterAttributes.Dexterity + otherMods;
        }
    }
}