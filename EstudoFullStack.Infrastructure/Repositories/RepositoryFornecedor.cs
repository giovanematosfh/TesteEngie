using EstudoFullStack.Domain.Entity;
using EstudoFullStack.Domain.Interface;
using System;

namespace EstudoFullStack.Infrastructure.Repositories
{
    public class RepositoryFornecedor : RepositoryBase<Fornecedor, Guid>, IRepositoryFornecedor
    {
        private readonly MyContext _myContext;
        public RepositoryFornecedor(MyContext myContext) : base(myContext)
        {
            _myContext = myContext;
        }
    }
}
