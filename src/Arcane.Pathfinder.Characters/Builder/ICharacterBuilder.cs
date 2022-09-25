using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Races;
using Arcane.Pathfinder.Characters.Skills;

namespace Arcane.Pathfinder.Characters.Builder
{
    public interface ICharacterBuilder
    {
        void AddBasicAttributes(BasicAttributes attributes);
        void AddRace(Race race);
        void AddSkills(IEnumerable<Skill> skills);
        Character GetCharacter();
    }
}