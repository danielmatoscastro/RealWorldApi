using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data.Mappings;

public class TagMap : IEntityTypeConfiguration<TagModel>
{
    public void Configure(EntityTypeBuilder<TagModel> builder)
    {
        builder.ToTable("TAGS");

        builder.HasKey(tag => tag.Name);

        builder.Property(tag => tag.Name)
            .HasColumnType("VARCHAR(250)")
            .IsRequired();
    }
}
