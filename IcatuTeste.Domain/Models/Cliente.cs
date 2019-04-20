using System.Collections.Generic;

namespace IcatuTeste.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }

        public List<Endereco> Enderecos { get; set; }
    }
}
