using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Festpay.Onboarding.Domain.Entities;
public class Transacao :EntityBase
{
    public Guid IdContaOrigem { get; set; }
    public Guid IdContaDestino { get; set; }
    public decimal Valor { get; set; }

    public virtual Account? ContaOrigem { get; set; }
    public virtual Account? ContaDestino { get; set; }

    //não criei a property "Cancelada", pois já existe uma property (DeactivatedUtc) que utilizei
}

