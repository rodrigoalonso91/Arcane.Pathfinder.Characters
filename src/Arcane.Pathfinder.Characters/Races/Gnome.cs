using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Skills;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
{
    public class Gnome : Race
    {
        public List<ISkill> RaceSkillBonus = new()
        {
            new RaceSkill()
            {
                SkillName = nameof(SkillCatalog.Stealth),
                AttributeModifier = AttributeTypes.Dexterity,
                Modifier = 4
            },
            new RaceSkill()
            {
                SkillName = nameof(SkillCatalog.Perception),
                AttributeModifier = AttributeTypes.Wisdom,
                Modifier = 2
            }
        };

        public Gnome(int movement)
        {
            Languages = new List<string>() { "Common", "Gnome", "Silvan" };
            Movement = movement;
            Size = CharacterSize.Small;
            Vision = VisionType.LowLight;

            RaceAtributtes = new BasicAttributes
            {
                Constitution = 2,
                Charisma = 2,
                Strength = -2
            };
        }
    }
}