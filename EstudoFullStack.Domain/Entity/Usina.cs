using EstudoFullStack.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFullStack.Domain.Entity
{
    public class Usina : EntityBase
    {
        public Fornecedor Fornecedor { get; set; }
        public int UcUsina { get; set; }
    }
}
