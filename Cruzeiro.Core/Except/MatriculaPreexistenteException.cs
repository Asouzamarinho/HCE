using System;

namespace Cruzeiro.Core.Except
{
    public class MatriculaPreexistenteException : Exception
    {
        public MatriculaPreexistenteException(string text)
            : base(text)
        {
        }
    }
}