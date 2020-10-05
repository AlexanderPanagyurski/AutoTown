using AutoTown.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutoTown.Models
{
    public class CarComment
    {
        [Key]
        public string Id { get; set; } = new Guid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.CarCommentUserFullNameMaxLength)]
        public string UserFullName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.ContentMaxLength)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [ForeignKey(nameof(Car))]
        public string CarId { get; set; }
        public virtual Car Car { get; set; }

        [ForeignKey(nameof(CarComment))]
        public string ParentCommentId { get; set; }
        public virtual CarComment ParentComment { get; set; }

        public virtual ICollection<CarComment> CommentReplies { get; set; } = new HashSet<CarComment>();
    }
}
