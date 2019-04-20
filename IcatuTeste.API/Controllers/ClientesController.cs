using AutoMapper;
using IcatuTeste.API.ViewModels;
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
        private readonly IMapper _mapper;

        public ClientesController(IClienteService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<CustomerViewModel> Get()
        {
            var clientes = _service.Listar();
            return _mapper.Map<IEnumerable<CustomerViewModel>>(clientes);
        }

        // GET: api/Clientes/5
        [HttpGet("{id}", Name = "Get")]
        public CustomerViewModel Get(int id)
        {
            var cliente = _service.RecuperarPorId(id);
            return _mapper.Map<CustomerViewModel>(cliente);
        }

        // POST: api/Clientes
        [HttpPost]
        public void Post([FromBody] CustomerViewModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            _service.Incluir(cliente);
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerViewModel model)
        {
            model.Id = id;

            var cliente = _mapper.Map<Cliente>(model);
            _service.Alterar(cliente);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Excluir(id);
        }
    }
}