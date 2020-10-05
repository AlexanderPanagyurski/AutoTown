using AutoTown.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoTown.Models
{
   public class City
    {
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.CityNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }

        [Required]
        [ForeignKey(nameof(Region))]
        public string RegionId { get; set; }
        public virtual Region Region { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
