using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IBodyStyleRepository
    {
        ICollection<BodyStyle> GetBodyStyles();
        BodyStyle GetBodyStyle(int bodyStyleId);
        bool BodyStyleExists(int id);

        void CreateBodyStyle(BodyStyle bodyStyle);
        void UpdateBodyStyle(BodyStyle bodyStyle);
        void DeleteBodyStyle(BodyStyle bodyStyle);
        void Save();
    }
}
