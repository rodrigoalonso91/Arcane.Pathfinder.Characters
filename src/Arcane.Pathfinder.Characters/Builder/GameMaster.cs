using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Races;
using Arcane.Pathfinder.Characters.Skills;

namespace Arcane.Pathfinder.Characters.Builder
{
    public class GameMaster
    {
        private ICharacterBuilder _builder;

        public ICharacterBuilder Builder 
        {
            set { _builder = value; }
        }

        public void BuildBasicAttributes(BasicAttributes attributes)
        {
            _builder.AddBasicAttributes(attributes);
        }

        public void BuildRace(Race race)
        {
            _builder.AddRace(race);
        }

        public void BuildSkills(IEnumerable<Skill> skills)
        {
            _builder.AddSkills(skills);
        }

        public Character BuildCharacter(BasicAttributes attributes, Race race, IEnumerable<Skill> skills)
        {
            _builder.AddBasicAttributes(attributes);
            _builder.AddRace(race);
            _builder.AddSkills(skills);
            return _builder.GetCharacter();
        }
    }
}