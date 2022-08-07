using Arcane.Pathfinder.Characters.Models;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
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