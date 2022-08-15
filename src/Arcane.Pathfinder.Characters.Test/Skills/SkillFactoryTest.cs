using Arcane.Pathfinder.Characters.Skills;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Test.Skills
{
    public class SkillFactoryTest
    {
        [Fact]
        public void Create_ShouldReturn_RaceSkill()
        {
            var skillParams = new SkillParam
            {
                SkillName = nameof(SkillCatalog.Acrobatics),
                AttributeModifier = AttributeTypes.Dexterity,
                SkillType = SkillType.Race
            };

            var result = SkillFactory.Create(skillParams);

            Assert.True(result.GetType() == typeof(RaceSkill));
        }

        [Fact]
        public void Create_ShouldReturn_NormalSkill()
        {
            var skillParams = new SkillParam
            {
                SkillName = nameof(SkillCatalog.Acrobatics),
                AttributeModifier = AttributeTypes.Dexterity,
                SkillType = SkillType.Normal
            };

            var result = SkillFactory.Create(skillParams);

            Assert.True(result.GetType() == typeof(Skill));
        }

        [Fact]
        public void SkillNames_ShouldBe_Equals()
        {
            var skillName = nameof(SkillCatalog.Acrobatics);
            var skillParams = new SkillParam
            {
                SkillName = skillName,
                AttributeModifier = AttributeTypes.Dexterity,
                SkillType = SkillType.Normal
            };

            var result = SkillFactory.Create(skillParams);

            Assert.True(result.SkillName == skillName);
        }
    }
}