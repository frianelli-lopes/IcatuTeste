using IcatuTeste.Domain.Interfaces.Repositories;
using IcatuTeste.Domain.Interfaces.Services;
using IcatuTeste.Domain.Models;

namespace IcatuTeste.Service
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        public EnderecoService(IEnderecoRepository repository) : base(repository)
        {
        }
    }
}
