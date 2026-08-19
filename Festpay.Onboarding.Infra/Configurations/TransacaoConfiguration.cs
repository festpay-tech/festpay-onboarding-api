using Festpay.Onboarding.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festpay.Onboarding.Infra.Configurations;
internal class TransacaoConfiguration :ConfigurationBase<Transacao>, IEntityTypeConfiguration<Transacao>
{
    public void Configure(EntityTypeBuilder<Transacao> builder)
    {   ConfigureEntityBase(builder);
        builder.Property(x => x.Valor).HasColumnType("Decimal(18,2)");
        builder.HasOne(x => x.ContaOrigem).WithMany(x => x.TransacoesOrigem).HasForeignKey(x => x.IdContaOrigem);
        builder.HasOne(x => x.ContaDestino).WithMany(x => x.TransacoesDestino).HasForeignKey(x => x.IdContaDestino);
        
    }
}
