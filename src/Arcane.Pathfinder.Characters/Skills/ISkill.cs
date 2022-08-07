using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Skills
{
    public interface ISkill
    {
        string SkillName { get; set; }
        AttributeTypes AttributeModifier { get; set; }
        int Modifier { get; set; }
    }
}