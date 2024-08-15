using Biscoitinhos.domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biscoitinhos.infra.Data.Mapeamentos
{
  public class SKUMap : MapBase<SKU>
  {
    public override void Configure(EntityTypeBuilder<SKU> builder)
    {
      base.Configure(builder);
      builder.ToTable("sku");
      builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
      builder.Property(c => c.UnidadeMedida).IsRequired().HasColumnName("UnidadeMedida");
    }
  }
}
