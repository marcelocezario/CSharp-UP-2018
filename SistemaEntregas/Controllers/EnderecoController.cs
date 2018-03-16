using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class EnderecoController
    {
        static List<Endereco> EnderecosCadastrados = new List<Endereco>();
        static int ultimoID = 0;

        // método para salvar endereço e retornar número do Id
        public int SalvarEndereco (Endereco endereco)
        {
            int id = ultimoID +1;
            ultimoID = id;

            endereco.EnderecoID = id;
            EnderecosCadastrados.Add(endereco);

            return id;
        }

        // método para pesquisar endereço por id, retorna objeto endereço ou nulo caso não encontre
        public Endereco PesquisarPorId(int idEndereco)
        {
            var c = from x in EnderecosCadastrados
                    where x.EnderecoID.Equals(idEndereco)
                    select x;
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        // método que retorna toda a lista de endereços cadastrados
        public List<Endereco> ListarEnderecos() => EnderecosCadastrados;

    }
}
