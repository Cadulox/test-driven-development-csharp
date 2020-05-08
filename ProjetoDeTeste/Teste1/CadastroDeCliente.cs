using ProjetoDeTeste.Models;
using ProjetoDeTeste.Servico;
using System;
using Xunit;

namespace Teste1
{
    public class CadastroDeCliente
    {
        [Fact]
        public void CadastroComSucesso()
        {
            var cliente = new Cliente
            {
                Codigo = 1,
                NomeCompleto = "João Silva",
                Endereco = "Rua A, número 123"
            };

            var servico = new ServicoDeCliente();
            var codigoCadastrado = servico.Cadastre(cliente);

            Assert.Equal(1, codigoCadastrado);
        }

        [Fact]
        public void CadastroComErro()
        {
            var cliente = new Cliente
            {
                Codigo = 1,
                NomeCompleto = "João",
                Endereco = "Rua A, número 123"
            };

            var servico = new ServicoDeCliente();

            var ex = Assert.Throws<Exception>(() => servico.Cadastre(cliente));
            Assert.Equal("Deve-se informar o nome completo", ex.Message);
        }

        [Fact]
        public void CadastroComErroClienteSemNome()
        {
            var cliente = new Cliente
            {
                Codigo = 1,
                NomeCompleto = "",
                Endereco = "Rua A, número 123"
            };

            var servico = new ServicoDeCliente();

            var ex = Assert.Throws<Exception>(() => servico.Cadastre(cliente));
            Assert.Equal("O nome deve ser informado", ex.Message);
        }
    }
}
