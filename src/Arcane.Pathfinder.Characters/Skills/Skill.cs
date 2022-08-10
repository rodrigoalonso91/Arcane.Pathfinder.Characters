using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Skills
{
    public class Skill : ISkill
    {
        public string SkillName { get; set; } = string.Empty;
        public AttributeTypes AttributeModifier { get; set; }
        public bool IsClassSkill { get; set; }
        public int Ranks { get; set; }
        public int ArmorPenalty { get; set; }
        public bool RequieredTraining { get; set; }
        public int Modifier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Skill(string skillname, AttributeTypes skillAttribute)
        {
            SkillName = skillname;
            AttributeModifier = skillAttribute;
        }
    }
}