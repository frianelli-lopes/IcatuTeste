using IcatuTeste.Domain.Interfaces.Services;
using IcatuTeste.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IcatuTeste.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClientesController(IClienteService service)
        {
            _service = service;
        }

        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _service.Listar();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}", Name = "Get")]
        public Cliente Get(int id)
        {
            return _service.RecuperarPorId(id);
        }

        // POST: api/Clientes
        [HttpPost]
        public void Post([FromBody] Cliente model)
        {
            _service.Incluir(model);
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente model)
        {
            model.Id = id;
            _service.Alterar(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Excluir(id);
        }
    }
}