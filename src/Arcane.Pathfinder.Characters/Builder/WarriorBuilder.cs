using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Races;
using Arcane.Pathfinder.Characters.Skills;

namespace Arcane.Pathfinder.Characters.Builder
{
    public class WarriorBuilder : ICharacterBuilder
    {
        private Character _character = new();

        public WarriorBuilder(string characterName, string playerName, int hitDice)
        {
            Reset();
            _character.PlayerName = playerName.Trim();
            _character.CharacterName = characterName.Trim();
            _character.LevelUp();
            _character.IncrementHitDice(hitDice);
        }

        private void Reset()
        {
            _character = new Character();
        }

        public void AddBasicAttributes(BasicAttributes attributes)
        {
            _character.CharacterAttributes = attributes;
        }

        public void AddRace(Race race)
        {
            _character.AddRace(race);
        }

        public void AddSkills(IEnumerable<Skill> skills)
        {
            _character.CharacterSkills = skills;
        }

        public Character GetCharacter()
        {
            var character = _character;
            Reset();
            return character;
        }
    }
}