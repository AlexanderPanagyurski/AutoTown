using AutoTown.Common;
using AutoTown.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoTown.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; } = new Guid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? BannedOn { get; set; }

        public GenderType? Gender { get; set; }

        public string ImageUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public string AboutMe { get; set; }

        public bool IsBlocked { get; set; }

        public string TwitterUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string InstagramUrl { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }

        [Required]
        [ForeignKey(nameof(City))]
        public string CityId { get; set; }
        public virtual City City { get; set; }

        [Required]
        [ForeignKey(nameof(Region))]
        public string RegionId { get; set; }
        public virtual Region Region { get; set; }

        public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new HashSet<ChatMessage>();

        public virtual ICollection<CarComment> CarComments { get; set; } = new HashSet<CarComment>();

        public virtual ICollection<Car> CarsForSale { get; set; } = new HashSet<Car>();

        public virtual ICollection<WishList> WishLists { get; set; } = new HashSet<WishList>();
    }
}
