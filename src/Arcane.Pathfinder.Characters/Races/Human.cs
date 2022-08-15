using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
{
    public class Human : Race
    {
        public Human(int movement)
        {
            Languages = new List<string>() { "Common" };
            Movement = movement;
            Vision = VisionType.Normal;
            Size = CharacterSize.Medium;
        }
    }
}