using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sensor_monitoring.Models
{
    public interface IBuildingRepository
    {
        IEnumerable<Building> GetAllBuildings { get; }
        IEnumerable<Sensor> GetSensorsByBuildingID(int BuildingID);
        IEnumerable<Readings> GetReadingsBySensorID(int SensorID);

    }
}
