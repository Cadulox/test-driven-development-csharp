using ProjetoDeTeste.Models;
using ProjetoDeTeste.Repositorio;
using ProjetoDeTeste.Validacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeTeste.Servico
{
    public class ServicoDeCliente
    {
        public int Cadastre(Cliente cliente)
        {
            var repositorio = new RepositorioCliente();
            var validacao = new ValidacaoCliente();

            validacao.Cadastre(cliente);
            return repositorio.Cadastre(cliente);
        }
    }
}
