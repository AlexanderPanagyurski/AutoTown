using AutoTown.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoTown.Models
{
    public class Country
    {
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.CountryNameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; } = new HashSet<City>();

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
        public virtual ICollection<Region> Regions { get; set; } = new HashSet<Region>();
    }
}
