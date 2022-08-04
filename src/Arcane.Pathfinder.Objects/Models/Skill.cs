using Arcane.Pathfinder.Objects.Abstractions;
using Arcane.Pathfinder.Objects.Utils;

namespace Arcane.Pathfinder.Objects.Models
{
    public class Skill : ISkill
    {
        public string SkillName { get; set; } = string.Empty;
        public bool IsClassSkill { get; set; }
        public int Ranks { get; set; }
        public bool HasArmorPenalty { get; set; }

        public Skill(SkillCommon skill)
        {
            SkillName = nameof(skill);
        }
    }
}