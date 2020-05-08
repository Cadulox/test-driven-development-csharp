using ProjetoDeTeste.Models;
using System;

namespace ProjetoDeTeste.Validacao
{
    public class ValidacaoCliente
    {
        public void Cadastre(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.NomeCompleto))
            {
                throw new Exception("O nome deve ser informado");
            }

            if(cliente.NomeCompleto.Split(' ').Length <= 1)
            {
                throw new Exception("Deve-se informar o nome completo");
            }
        }
    }
}
