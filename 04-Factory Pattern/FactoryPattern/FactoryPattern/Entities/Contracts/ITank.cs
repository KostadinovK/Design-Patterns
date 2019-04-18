namespace FactoryPattern.Entities.Contracts
{
    public interface ITank : IMachine
    {
        bool DefenseMode { get; }

        void ToggleDefenseMode();
    }
}