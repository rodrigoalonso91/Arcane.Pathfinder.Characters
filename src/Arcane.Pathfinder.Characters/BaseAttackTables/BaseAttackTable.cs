namespace Arcane.Pathfinder.Characters.BaseAttackTables
{
    public interface IBaseAttackTable
    {
        BaseAttackType BaseAttackType { get; set; }
        int CharacterLevel { get; set; }
    }

    public abstract class BaseAttackTable : IBaseAttackTable
    {
        public int CharacterLevel { get; set; }
        public BaseAttackType BaseAttackType { get; set; }
    }
}