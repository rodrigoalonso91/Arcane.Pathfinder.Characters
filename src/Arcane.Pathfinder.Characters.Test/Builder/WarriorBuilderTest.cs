using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Builder;
using Arcane.Pathfinder.Characters.Races;

namespace Arcane.Pathfinder.Characters.Test.Builder
{
    public class WarriorBuilderTest
    {
        [Fact]
        public void CharacterNamesAndHitDice_ShouldBe_Same()
        {
            var characterName = "Aragor";
            var playerName = "Rodrigo Alonso";
            var hitDice = 8;
            var builder = new WarriorBuilder(characterName, playerName, hitDice);

            var warrior = builder.GetCharacter();

            Assert.NotNull(warrior);
            Assert.True(characterName == warrior.CharacterName);
            Assert.True(playerName == warrior.PlayerName);
            Assert.True(hitDice == warrior.HitDice);
        }

        [Fact]
        public void AddBasicAttributes_ShouldSet_BasicAttributes()
        {
            var builder = new WarriorBuilder("Aragor", "Rodrigo", 8);

            var attribute = new BasicAttributes()
            {
                Strength = 10,
                Dexterity = 11,
                Constitution = 12,
                Intelligence = 13,
                Wisdom = 14,
                Charisma = 15
            };

            builder.AddBasicAttributes(attribute);

            var warrior = builder.GetCharacter();

            Assert.NotNull(warrior);
            Assert.True(attribute.Strength == warrior.CharacterAttributes.Strength);
            Assert.True(attribute.Dexterity == warrior.CharacterAttributes.Dexterity);
            Assert.True(attribute.Constitution == warrior.CharacterAttributes.Constitution);
            Assert.True(attribute.Intelligence == warrior.CharacterAttributes.Intelligence);
            Assert.True(attribute.Wisdom == warrior.CharacterAttributes.Wisdom);
            Assert.True(attribute.Charisma == warrior.CharacterAttributes.Charisma);
        }

        [Fact]
        public void AddRacee_ShouldSet_RaceProperty()
        {
            var movement = 30;
            var elf = new Elf(movement);
            var builder = new WarriorBuilder("Aragor", "Rodrigo", 8);

            builder.AddRace(elf);
            var warrior = builder.GetCharacter();

            Assert.NotNull(warrior);
            Assert.NotNull(warrior.Race);
            Assert.Equal(elf, warrior.Race);
        }

        [Fact]
        public void CharacterAttribute_MustExist_WhenAddRace()
        {
            var movement = 30;
            var elf = new Elf(movement);
            var builder = new WarriorBuilder("Aragor", "Rodrigo", 8);
            var attribute = new BasicAttributes()
            {
                Strength = 10,
                Dexterity = 10,
                Constitution = 10,
                Intelligence = 10,
                Wisdom = 10,
                Charisma = 10
            };

            builder.AddBasicAttributes(attribute);
            builder.AddRace(elf);
            var warrior = builder.GetCharacter();

            Assert.NotNull(warrior);
            Assert.NotNull(warrior.CharacterAttributes);
            Assert.NotNull(warrior.Race);
        }
    }
}