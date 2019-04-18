using IcatuTeste.Domain.Interfaces.Repositories;
using IcatuTeste.Domain.Models;
using IcatuTeste.Infra.Data.Context;

namespace IcatuTeste.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(IcatuTesteContext context) : base(context)
        {
        }
    }
}
