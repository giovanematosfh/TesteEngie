using System;

namespace EstudoFullStack.Domain.Entity.Base
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public bool Ativo { get; set; }
    }

}



