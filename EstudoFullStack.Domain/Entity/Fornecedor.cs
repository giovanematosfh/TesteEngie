using EstudoFullStack.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFullStack.Domain.Entity
{
    public class Fornecedor : EntityBase
    {
        public string Name { get; set; }
        public IEnumerable<Usina> ListaUsinas { get; set; }
    }
}
