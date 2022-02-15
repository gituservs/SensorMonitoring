using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sensor_monitoring.Models
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly AppDbContext _appDbContext;
        public BuildingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Building> GetAllBuildings 
        {
            get
            {
                return _appDbContext.Buildings.ToList();
            }
        }

        public IEnumerable<Sensor> GetSensorsByBuildingID(int BuildingId)
        {
            return _appDbContext.Sensors.Where(p => p.BuildingID == BuildingId).ToList();
        }

        public IEnumerable<Readings> GetReadingsBySensorID(int SensorID)
        {
            return _appDbContext.Readings.Where(p => p.SensorID == SensorID).ToList();
        }
    }
}
