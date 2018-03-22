using System;

namespace Modelos
{
    public abstract class Pessoa
    {
        public int PessoaID { get; set; }

        public string Nome { get; set; }

        public string Cpf_Cnpj { get; set; }

        public DateTime DataNascimento { get; set; }

        public int EnderecoID { get; set; }

    }
}
