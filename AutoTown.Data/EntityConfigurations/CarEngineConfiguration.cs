using AutoTown.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTown.Data.EntityConfigurations
{
    public class CarEngineConfiguration : IEntityTypeConfiguration<CarEngine>
    {
        public void Configure(EntityTypeBuilder<CarEngine> builder)
        {
        }
    }
}
