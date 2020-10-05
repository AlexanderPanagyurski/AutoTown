using AutoTown.Common;
using AutoTown.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoTown.Models
{
    public class CarEngine
    {
        public CarEngine()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Range(AttributesConstraints.HorsePowerMinValue, AttributesConstraints.HorsePowerMaxValue)]
        public int? HorsePower { get; set; }

        [Range(AttributesConstraints.EngineDisplacementMinValue, AttributesConstraints.EngineDisplacementMaxValue)]
        public double EngineDisplacement { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        public EuroEmissionType? EuroEmissionType { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
