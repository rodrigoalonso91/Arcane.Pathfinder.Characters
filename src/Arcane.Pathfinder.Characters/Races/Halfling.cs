using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Skills;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
{
    public class Halfling : Race
    {
        public List<ISkill> RaceSkillBonus = new()
        {
            new RaceSkill()
            {
                SkillName = nameof(SkillCatalog.Perception),
                AttributeModifier = AttributeTypes.Wisdom,
                Modifier = 2
            },
            new RaceSkill()
            {
                SkillName = nameof(SkillCatalog.Climb),
                AttributeModifier = AttributeTypes.Strength,
                Modifier = 2
            },
            new RaceSkill()
            {
                SkillName = nameof(SkillCatalog.Acrobatics),
                AttributeModifier = AttributeTypes.Dexterity,
                Modifier = 2
            }
        };

        public Halfling(int movement)
        {
            Languages = new List<string>() { "Common", "Halfling" };
            Movement = movement;
            Vision = VisionType.LowLight;
            Size = CharacterSize.Small;

            RaceAtributtes = new BasicAttributes
            {
                Dexterity = 2,
                Charisma = 2,
                Strength = -2
            };
        }
    }
}