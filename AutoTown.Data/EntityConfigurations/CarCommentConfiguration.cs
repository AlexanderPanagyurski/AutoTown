using AutoTown.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTown.Data.EntityConfigurations
{
    public class CarCommentConfiguration : IEntityTypeConfiguration<CarComment>
    {
        public void Configure(EntityTypeBuilder<CarComment> builder)
        {
            builder
                .Property(x => x.Content)
                .IsUnicode(true);

            builder
                .Property(x => x.UserFullName)
                .IsUnicode(true);

            builder
                .Property(x => x.PhoneNumber)
                .IsUnicode(false);

            builder
                .Property(x => x.Email)
                .IsUnicode(false);

            builder
                .HasOne(x => x.Car)
                .WithMany(y => y.CarComments)
                .HasForeignKey(x => x.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.User)
                .WithMany(y => y.CarComments)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.ParentComment)
                .WithMany(y => y.CommentReplies)
                .HasForeignKey(x => x.ParentCommentId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
