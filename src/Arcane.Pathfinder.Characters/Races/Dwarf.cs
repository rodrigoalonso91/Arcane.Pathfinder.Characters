using Arcane.Pathfinder.Characters.Attributes;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
{
    public class Dwarf : Race
    {
        public Dwarf(int movement)
        {
            Languages = new List<string>() { "Common", "Dwarf" };
            Movement = movement;
            Vision = VisionType.Dark;
            Size = CharacterSize.Medium;

            RaceAtributtes = new BasicAttributes
            {
                Constitution = 2,
                Wisdom = 2,
                Charisma = -2
            };
        }
    }
}