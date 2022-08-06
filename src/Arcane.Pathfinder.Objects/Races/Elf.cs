using Arcane.Pathfinder.Objects.Models;
using Arcane.Pathfinder.Objects.Utils;

namespace Arcane.Pathfinder.Objects.Races
{
    public class Elf : Race
    {
        public Elf(int movement)
        {
            Languages = new List<string>() { "Common", "Elf" };
            Movement = movement;
            Vision = VisionType.LowLight;
            Size = CharacterSize.Medium;

            RaceAtributtes = new BasicAttributes
            {
                Dexterity = 2,
                Intelligence = 2,
                Constitution = -2
            };
        }
    }
}