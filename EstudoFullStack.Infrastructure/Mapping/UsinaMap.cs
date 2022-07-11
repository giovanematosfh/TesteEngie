using EstudoFullStack.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoFullStack.Infrastructure.Mapping
{
    class UsinaMap : IEntityTypeConfiguration<Usina>
    {
        public void Configure(EntityTypeBuilder<Usina> builder)
        {
            builder.ToTable("Usinas");
            builder.HasKey(x => x.Id);
            builder.HasQueryFilter(w => !w.Ativo);
        }
    }
}
