using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface ITrimRepository
    {
        ICollection<Trim> GetTrims();
        Trim GetTrim(int typeId);
        bool GetTrimExists(int typeId);
    }
}
