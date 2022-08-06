using Arcane.Pathfinder.Objects.Utils;
namespace Arcane.Pathfinder.Objects.Abstractions
{
    public interface ISkill
    {
        string SkillName { get; set; }
        AttributeTypes AttributeModifier { get; set; }
        bool IsClassSkill { get; set; }
        int Ranks { get; set; }
        int ArmorPenalty { get; set; }
        public bool RequieredTraining { get; set; }
    }
}