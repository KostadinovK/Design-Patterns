namespace FactoryPattern.Entities.Contracts
{
    public interface IPilot
    {
        string Name { get; }

        void AddMachine(IMachine machine);

        string Report();
    }
}