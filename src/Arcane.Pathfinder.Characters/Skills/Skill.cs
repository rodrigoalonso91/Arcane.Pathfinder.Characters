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

    public class Skill : SkillBase
    {
        public bool IsClassSkill { get; set; }
        public int Ranks { get; set; }
        public int ArmorPenalty { get; set; }
        public bool RequieredTraining { get; set; }

        public Skill(string skillname, AttributeTypes skillAttribute)
        {
            SkillName = skillname;
            AttributeModifier = skillAttribute;
        }
    }

    public class RaceSkill : SkillBase
    {
    }
}