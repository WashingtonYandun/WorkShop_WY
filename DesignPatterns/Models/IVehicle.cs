namespace DesignPatterns.Models
{
    public interface IVehicle
    {
        void StartEngine();

        void StopEngine();

        void AddGas();

        bool NeedsGas();

        bool IsEngineOn();
    }
}
