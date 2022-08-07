using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Models
{
    public class Skill
    {
        public string SkillName { get; set; } = string.Empty;
        public AttributeTypes AttributeModifier { get; set; }
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