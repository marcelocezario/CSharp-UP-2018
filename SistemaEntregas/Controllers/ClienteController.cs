﻿using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ClienteController
    {
        static List<Cliente> ClientesCadastrados = new List<Cliente>();
        static int ultimaID = 0;

        // método salvar cliente, recebe um objeto de cliente, gera um id e salva na memória
        public void SalvarCliente(Cliente cliente)
        {
            cliente.PessoaID = ultimaID + 1;
            ClientesCadastrados.Add(cliente);
            ultimaID++;
        }

        // método para pesquisar cliente por nome, retorna objeto cliente ou nulo caso não encontre
        public Cliente PesquisarPorNome(string nome)
        {
            var c = from x in ClientesCadastrados
                    where x.Nome.ToLower().Equals(nome.Trim().ToLower())
                    select x;
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        // método para pesquisar cliente por id, retorna objeto cliente ou nulo caso não encontre
        public Cliente PesquisarPorId(int idCliente)
        {
            var c = from x in ClientesCadastrados
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
                ClientesCadastrados.Remove(cliente);
        }

        // método que retorna toda a lista de clientes cadastrados
        public List<Cliente> ListarClientes() => ClientesCadastrados;

        public void EditarCliente(int idClienteEditar, Cliente clienteEditado)
        {
            Cliente clienteEditar = PesquisarPorId(idClienteEditar);

            clienteEditar.Nome = clienteEditado.Nome;
            clienteEditar.Cpf = clienteEditado.Cpf;
        }
    }
}
