using ProjetoDeTeste.Models;
using ProjetoDeTeste.Servico;
using System;

namespace ProjetoDeTeste
{
    public class Principal
    {
        public void CadastreCliente()
        {
            var cliente = new Cliente
            {
                Codigo = 1,
                NomeCompleto = "João",
                Endereco = "Rua A, número 123"
            };

            var servico = new ServicoDeCliente();
            servico.Cadastre(cliente);
        }
    }
}
