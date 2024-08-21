using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IDriveTrainRepository
    {
        ICollection<DriveTrain> GetDriveTrains();
        DriveTrain GetDriveTrain(int driveTrainId);
        bool DriveTrainExists(int driveTrainId);

        void CreateDriveTrain(DriveTrain driveTrain);
        void UpdateDriveTrain(DriveTrain driveTrain);
        void DeleteDriveTrain(DriveTrain driveTrain);
        void Save();
    }
}
