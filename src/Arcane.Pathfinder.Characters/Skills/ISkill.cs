using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Skills
{
    public interface ISkill
    {
        string SkillName { get; set; }
        AttributeTypes AttributeModifier { get; set; }
    }

    public abstract class SkillBase : ISkill
    {
        public string SkillName { get; set; } = string.Empty;
        public AttributeTypes AttributeModifier { get; set; }
        public int Modifier { get; set; }
    }
}