using EstudoFullStack.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoFullStack.UI.Controllers
{
    public class FornecedorController : Controller
    {
        [HttpGet]
        [Route("fornecedores")]
        public List<Usina> Get()
        {
            return null;
        }

        [HttpGet]
        [Route("fornecedores/{id}")]
        public string GetById(Guid id)
        {
            return null;
        }

        [HttpGet]
        [Route("fornecedores/{id}/orders")]
        public List<Fornecedor> GetOrders(Guid id)
        {
            return null;
        }

        [HttpPost]
        [Route("fornecedores")]
        public Usina Post([FromBody] Fornecedor fornecedore)
        {
            return null;

        }

        [HttpPut]
        [Route("fornecedores/{id}")]
        public Usina Put([FromBody] Fornecedor usina)
        {
            return null;

        }

        [HttpDelete]
        [Route("fornecedores/{id}")]
        public string Delete()
        {
            return null;

        }
    }
}
