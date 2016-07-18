using System;

namespace Cruzeiro.Core.Except
{
    public class EpcPreexistenteException : Exception
    {
        public EpcPreexistenteException(string text)
            : base(text)
        {
        }
    }
}