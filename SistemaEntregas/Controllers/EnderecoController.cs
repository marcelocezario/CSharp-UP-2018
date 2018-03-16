using Modelos;
using System.Collections.Generic;

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

        // método que retorna toda a lista de endereços cadastrados
        public List<Endereco> ListarEnderecos() => EnderecosCadastrados;

    }
}
