using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Races;
using Arcane.Pathfinder.Characters.Skills;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters
{
    public class Character
    {
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int HitDice { get; private set; }
        public int HitPoints { get; private set; }
        public int ActualHitPoints { get; set; }
        public int HeroPoints { get; set; }
        public int BasicAttack { get; set; }
        public BasicAttributes CharacterAttributes { get; set; }
        public IEnumerable<Skill> CharacterSkills { get; set; }
        public Alignments Alignment { get; private set; }
        public Race Race { get; private set; }

        public int GetInitiativeMod(int otherMods = 0)
        {
            return CharacterAttributes.Dexterity + otherMods;
        }

        public void AddRace(Race race)
        {
            Race ??= race;
        }

        public int IncrementHitDice(int value)
        {
            return HitDice += value;
        }

        public int LevelUp()
        {
            return ++Level;
        }
    }
}