using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
{
    public class HalfElf : Race
    {
        public HalfElf(int movement)
        {
            Languages = new List<string>() { "Common", "Elf" };
            Movement = movement;
            Vision = VisionType.Normal;
            Size = CharacterSize.Medium;
        }
    }
}