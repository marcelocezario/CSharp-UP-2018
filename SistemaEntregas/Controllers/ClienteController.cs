using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {
        static List<Cliente> MeusClientes = new List<Cliente>();
        static int ultimoId = 0;

        // método salvar cliente, recebe um objeto de cliente e gera um id e salva na memória
        public void SalvarCliente(Cliente cliente)
        {
            ultimoId++;
            cliente.PessoaID = ultimoId;
            MeusClientes.Add(cliente);
        }
        
        // método para pesquisar cliente por nome, retorna objeto cliente
        public Cliente PesquisarPorNome(string nome)
        {
            //buscar um objeto "x" na lista "MeusClientes" comparando o atributo nome com a string nome
            //"var" define a variável automaticamente, pode ser um objeto único ou uma lista de objetos
            //"FirstOrDefault" retorna o primeiro objeto ou resultado padrão da lista
            //"ToLower" - converte string e letras minúsculas (ToUpper - maiúsculo)
            //"Trim" elimina o excesso de espaços na string
            //Equals igual / Contains  contém
            var c = from x in MeusClientes
                    where x.Nome.ToLower().Equals(nome.Trim().ToLower())
                    select x;
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        // método para pesquisar cliente por id, retorna objeto cliente
        public Cliente PesquisarPorId(int idCliente)
        {
            var c = from x in MeusClientes
                    where x.PessoaID.Equals(idCliente)
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        // método para excluir cliente pela id
        public void ExcluirCliente (int idCliente)
        {
            Cliente cliente = PesquisarPorId(idCliente);
            if (cliente != null)
                MeusClientes.Remove(cliente);
        }

        // método que retorna toda a lista de clientes cadastrados
        public List<Cliente> ListarClientes()
        {
            return MeusClientes;
        }
    }
}
