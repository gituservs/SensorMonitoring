using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sensor_monitoring.Models
{
    public class Building
    {
        [ScaffoldColumn(false)]
        public int BuildingID { get; set; }

        [Required, StringLength(100), Display(Name = "Building Name")]
        public string BuildingName { get; set; }

        [Display(Name = "Building Address")]
        public string BuildingAddress { get; set; }

        public virtual ICollection<Sensor> Sensors { get; set; }
    }
}
