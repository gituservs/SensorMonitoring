using Microsoft.AspNetCore.Mvc;
using Sensor_monitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sensor_monitoring.Controllers
{
    public class BuildingController : Controller
    {
        private readonly IBuildingRepository _buildingRepository;
        public BuildingController(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }

        public ViewResult List()
        {
            return View(_buildingRepository.GetAllBuildings);
        }

        public IActionResult SensorList(int id)
        {
            var sensors = _buildingRepository.GetSensorsByBuildingID(id);
            if (sensors == null)
                return NotFound();
            return View(sensors);
        }

        public IActionResult Readings(int id)
        {
            var readings = _buildingRepository.GetReadingsBySensorID(id);
            if (readings == null)
                return NotFound();
            return View(readings);
        }
    }
}
