using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Skills
{
    public class SkillParam : ISkill
    {
        public string SkillName { get; set; } = string.Empty;
        public AttributeTypes AttributeModifier { get; set; }   
        public SkillType SkillType { get; set; }
    }
}