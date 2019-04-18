using IcatuTeste.Domain.Interfaces.Repositories;
using IcatuTeste.Domain.Interfaces.Services;
using IcatuTeste.Domain.Models;

namespace IcatuTeste.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IClienteRepository repository) : base(repository)
        {
        }
    }
}
