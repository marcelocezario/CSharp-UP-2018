using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {
        static List<Cliente> MeusClientes = new List<Cliente>();
        static int ultimoID = 0;

        public void SalvarCliente(Cliente cliente)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            cliente.PessoaID = id;
            MeusClientes.Add(cliente);
        }
        
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

        public void ExcluirCliente (int idCliente)
        {
            Cliente cliente = PesquisarPorId(idCliente);
            if (cliente != null)
                MeusClientes.Remove(cliente);
        }
    }
}
