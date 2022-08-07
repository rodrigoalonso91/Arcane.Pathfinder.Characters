using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Skills;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
{
    public class Elf : Race
    {
        public List<ISkill> RaceSkillBonus = new()
        {
            new RaceSkill()
            {
                SkillName = nameof(SkillCatalog.Perception),
                AttributeModifier = AttributeTypes.Wisdom,
                Modifier = 2
            }
        };

        public Elf(int movement)
        {
            Languages = new List<string>() { "Common", "Elf" };
            Movement = movement;
            Vision = VisionType.LowLight;
            Size = CharacterSize.Medium;

            RaceAtributtes = new BasicAttributes
            {
                Dexterity = 2,
                Intelligence = 2,
                Constitution = -2
            };
        }
    }
}