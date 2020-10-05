using AutoTown.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTown.Data.EntityConfigurations
{
    public class ChatMessageConfiguration : IEntityTypeConfiguration<ChatMessage>
    {
        public void Configure(EntityTypeBuilder<ChatMessage> builder)
        {
            builder
                .Property(x => x.Content)
                .IsUnicode(true);

            builder
                .HasOne(x => x.Sender)
                .WithMany(y => y.ChatMessages)
                .HasForeignKey(x=>x.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Receiver)
                .WithMany(y => y.ChatMessages)
                .HasForeignKey(x => x.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
