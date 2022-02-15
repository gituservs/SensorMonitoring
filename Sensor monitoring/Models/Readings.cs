using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sensor_monitoring.Models
{
    public class Readings
    {
        [ScaffoldColumn(false)]
        public int ReadingsID { get; set; }

        [Display(Name = "Value")]
        public double? ReadingValue { get; set; }

        public DateTime Date { get; set; }

        public int? SensorID { get; set; }
        public virtual Sensor Sensor { get; set; }
    }
}
