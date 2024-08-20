﻿using DealerCarsApp.Data;
using DealerCarsApp.Interfaces;
using DealerCarsApp.Model;

namespace DealerCarsApp.Repository
{
    public class DriveTrainRepository : IDriveTrainRepository
    {
        private readonly DataContext _context;
        public DriveTrainRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<DriveTrain> GetDriveTrains()
        {
            return _context.DriveTrains.ToList();
        }

        public DriveTrain GetDriveTrain(int driveTrainId)
        {
            return _context.DriveTrains.Where(d => d.Id == driveTrainId).FirstOrDefault();
        }

        public bool DriveTrainExists(int driveTrainId)
        {
            return _context.DriveTrains.Any(d => d.Id == driveTrainId);
        }
    }
}
