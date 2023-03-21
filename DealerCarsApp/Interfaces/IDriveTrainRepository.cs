using DealerCarsApp.Model;

namespace DealerCarsApp.Interfaces
{
    public interface IDriveTrainRepository
    {
        ICollection<DriveTrain> GetDriveTrains();
        DriveTrain GetDriveTrain(int driveTrainId);
        ICollection<Vehicle> GetVehiclesByDriveTrain(int driveTrainId);
        bool DriveTrainExists(int driveTrainId);
    }
}
