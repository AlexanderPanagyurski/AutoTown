using AutoTown.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoTown.Models
{
    public class Region
    {
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.RegionNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<City> Cities { get; set; } = new HashSet<City>();

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
