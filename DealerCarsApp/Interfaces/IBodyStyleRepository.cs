using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IBodyStyleRepository
    {
        ICollection<BodyStyle> GetBodyStyles();
        BodyStyle GetBodyStyle(int bodyStyleId);
        ICollection<Vehicle> GetVehiclesByBodyStyle(int bodyStyleId);
        bool BodyStyleExists(int id);
    }
}
