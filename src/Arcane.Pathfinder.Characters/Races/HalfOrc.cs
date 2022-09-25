using Arcane.Pathfinder.Characters.Skills;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
{
    public class HalfOrc : Race
    {
        public List<ISkill> RaceSkillBonus = new()
        {
            new RaceSkill()
            {
                SkillName = nameof(SkillCatalog.Intimidate),
                AttributeModifier = AttributeTypes.Charisma,
                Modifier = 2
            }
        };

        public HalfOrc(int movement)
        {
            Languages = new List<string>() { "Common", "Orc" };
            Movement = movement;
            Vision = VisionType.Dark;
            Size = CharacterSize.Medium;
        }
    }
}