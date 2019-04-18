using IcatuTeste.Domain.Interfaces.Repositories;
using IcatuTeste.Domain.Models;
using IcatuTeste.Infra.Data.Context;

namespace IcatuTeste.Infra.Data.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(IcatuTesteContext context) : base(context)
        {
        }
    }
}
