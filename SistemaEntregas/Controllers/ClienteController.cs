using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {
        static List<Cliente> MeusClientes = new List<Cliente>();

        public void SalvarCliente(Cliente cliente)
        {
            // TODO: Persistir os dados do cliente
            MeusClientes.Add(cliente);
        }
        
        public Cliente PesquisarPorNome(string nome)
        {
            //buscar um objeto "x" na lista "MeusClientes" comparando o atributo nome com a string nome
            //"var" define a variável automaticamente, pode ser um objeto único ou uma lista de objetos
            //"FirstOrDefault" retorna o primeiro objeto ou resultado padrão da lista
            var c = from x in MeusClientes
                    where x.Nome.Equals(nome)
                    select x;
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }
    }
}
