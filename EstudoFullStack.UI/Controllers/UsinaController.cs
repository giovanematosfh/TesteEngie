using EstudoFullStack.Domain.Entity;
using EstudoFullStack.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoFullStack.UI.Controllers
{
    public class UsinaController : Controller
    {
        private readonly IRepositoryUsina _repositoryUsina;
        public UsinaController(IRepositoryUsina repositorio)
        {
            _repositoryUsina = repositorio;
        }

        [HttpGet]
        [Route("Listar")]
        public List<Usina> Get()
        {
            var maria = _repositoryUsina.GetById(Guid.Parse("27295374-98B9-41C2-9D70-5051469925BB"));
            return null;
        }

        [HttpGet]
        [Route("usina/{id}")]
        public string GetById(Guid id)
        {
            return null;
        }

        [HttpGet]
        [Route("usinas/{id}/orders")]
        public List<Usina> GetOrders(Guid id)
        {
            return null;
        }

        [HttpPost]
        [Route("usinas")]
        public Usina Post([FromBody] Usina usina)
        {
            return null;

        }

        [HttpPut]
        [Route("usinasput/{id}")]
        public Usina Put([FromBody] Usina usina)
        {
            return null;

        }

        [HttpDelete]
        [Route("usinas/{id}")]
        public string Delete()
        {
            return null;

        }
    }
}
