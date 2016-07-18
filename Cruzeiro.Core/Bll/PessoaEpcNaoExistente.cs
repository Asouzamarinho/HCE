using System;

namespace Cruzeiro.Core.Bll
{
    public class PessoaEpcNaoExistente : Exception
    {
        public PessoaEpcNaoExistente(string epc)
            : base("Epc: " + epc)
        {
        }
    }
}