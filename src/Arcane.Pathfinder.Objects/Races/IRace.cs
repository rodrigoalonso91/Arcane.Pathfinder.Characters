using Arcane.Pathfinder.Objects.Utils;

namespace Arcane.Pathfinder.Objects.Races
{
    public interface IRace
    {
        public CharacterSize Size { get; set; }
        public VisionType Vision { get; set; }
        public int Movement { get; set; }
    }
}