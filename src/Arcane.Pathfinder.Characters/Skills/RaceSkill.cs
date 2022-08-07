using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Skills
{
    public class RaceSkill : ISkill
    {
        public string SkillName { get; set; } = string.Empty;
        public AttributeTypes AttributeModifier { get; set ; }
        public int Modifier { get ; set; }
    }
}