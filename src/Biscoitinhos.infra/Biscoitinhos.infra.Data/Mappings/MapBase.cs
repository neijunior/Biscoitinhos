using Biscoitinhos.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biscoitinhos.infra.Data.Mappings
{
  public class MapBase<T> : IEntityTypeConfiguration<T> where T : EntityBase
  {
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
      builder.HasKey(c => c.Id);
      builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
    }
  }

}
