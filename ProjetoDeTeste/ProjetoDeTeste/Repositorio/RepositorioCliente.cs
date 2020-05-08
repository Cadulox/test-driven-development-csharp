using ProjetoDeTeste.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeTeste.Repositorio
{
    public class RepositorioCliente
    {
        public int Cadastre(Cliente cliente)
        {
            // Cadastre
            return cliente.Codigo;
        }
    }
}
