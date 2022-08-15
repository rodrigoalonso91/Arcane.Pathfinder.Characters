using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Skills
{
    public class SkillFactory
    {
        public static ISkill Create(SkillParam skillParam)
        {
            return skillParam.SkillType == SkillType.Normal 
                ? new Skill(skillParam.SkillName, skillParam.AttributeModifier) 
                : new RaceSkill();
        }
    }
}