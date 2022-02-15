using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sensor_monitoring.Models
{
    public class Sensor
    {
        [ScaffoldColumn(false)]
        public int SensorID { get; set; }

        [Required, StringLength(100), Display(Name = "Sensor Name")]
        public string SensorName { get; set; }

        [Display(Name = "Sensor Description")]
        public string SensorDescription { get; set; }

        [Display(Name = "Sensor Type")]
        public string SensorType { get; set; }

        public int? BuildingID { get; set; }
        public virtual Building Building { get; set; }

        public virtual ICollection<Readings> Readings { get; set; }
    }
}
