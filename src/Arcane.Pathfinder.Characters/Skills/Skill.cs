using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Skills
{
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
}