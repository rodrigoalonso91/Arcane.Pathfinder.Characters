using Arcane.Pathfinder.Characters.Models;
using Arcane.Pathfinder.Characters.Utils;

namespace Arcane.Pathfinder.Characters.Races
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