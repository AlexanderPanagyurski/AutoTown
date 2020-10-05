using AutoTown.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTown.Data.EntityConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .Property(x => x.Make)
                .IsUnicode(false);

            builder
                .Property(x => x.Model)
                .IsUnicode(false);

            builder
                .Property(x => x.Description)
                .IsUnicode(true);

            builder
                .HasOne(x => x.CarEngine)
                .WithMany(y => y.Cars)
                .HasForeignKey(x => x.CarEngineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.City)
                .WithMany(y => y.Cars)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Country)
                .WithMany(y => y.Cars)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Region)
                .WithMany(y => y.Cars)
                .HasForeignKey(x => x.RegionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.User)
                .WithMany(y => y.CarsForSale)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
