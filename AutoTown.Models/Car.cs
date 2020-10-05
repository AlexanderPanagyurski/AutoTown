using AutoTown.Common;
using AutoTown.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoTown.Models
{
    public class Car
    {
        [Key]
        public string Id { get; set; } = new Guid().ToString();

        [Required,MaxLength(AttributesConstraints.MakeMaxLength)]
        public string Make { get; set; }

        [Required,MaxLength(AttributesConstraints.ModelMaxLength)]
        public string Model { get; set; }

        [MaxLength(AttributesConstraints.CarDescriptionMaxLength)]
        public string Description { get; set; }

        [MaxLength(AttributesConstraints.YearMaxLength)]
        public int? Year { get; set; }

        [Range(typeof(decimal),AttributesConstraints.PriceMinValue,AttributesConstraints.PriceMaxValue)]
        public decimal? Price { get; set; }

        [MaxLength(AttributesConstraints.MileageMaxValue)]
        public double? Mileage { get; set; }

        [Required]
        public GearboxType GearboxType { get; set; }

        [Required]
        public ConditionType ConditionType { get; set; }

        [Required]
        public BodyType BodyType { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [Required, ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }


        [Required, ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }

        [Required, ForeignKey(nameof(City))]
        public string CityId { get; set; }
        public virtual City City { get; set; }

        [Required, ForeignKey(nameof(CarEngine))]
        public string CarEngineId { get; set; }
        public virtual CarEngine CarEngine { get; set; }

        [Required, ForeignKey(nameof(Region))]
        public string RegionId { get; set; }
        public virtual Region Region { get; set; }

        public virtual ICollection<CarComment> CarComments { get; set; } = new HashSet<CarComment>();
    }
}
