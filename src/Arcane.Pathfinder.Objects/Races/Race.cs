using Arcane.Pathfinder.Objects.Models;
using Arcane.Pathfinder.Objects.Utils;

namespace Arcane.Pathfinder.Objects.Races
{
    public abstract class Race
    {
        public List<string>? Languages;
        public BasicAttributes? RaceAtributtes { get; set; }
        public CharacterSize Size { get; set; }
        public VisionType Vision { get; set; }
        public int Movement { get; set; }
    }
}