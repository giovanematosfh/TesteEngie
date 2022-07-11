using EstudoFullStack.Domain.Entity;
using EstudoFullStack.Domain.Interface;
using System;

namespace EstudoFullStack.Infrastructure.Repositories
{
    public class RepositoryUsina : RepositoryBase<Usina, Guid>, IRepositoryUsina
    {
        private readonly MyContext _myContext;
        public RepositoryUsina(MyContext myContext) : base(myContext)
        {
            _myContext = myContext;
        }
    }
}
