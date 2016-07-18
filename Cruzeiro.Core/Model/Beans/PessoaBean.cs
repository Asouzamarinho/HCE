﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Model\Beans\PessoaBean.cs
//
// summary:	Implements the pessoa bean class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Model.Beans
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A pessoa bean. </summary>
    ///
    /// <remarks>   Danim, 31/05/2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class PessoaBean : SyncNamedBean
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the matricula. </summary>
        ///
        /// <value> The matricula. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int? Matricula { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the epc. </summary>
        ///
        /// <value> The epc. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Epc { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the ano entrada. </summary>
        ///
        /// <value> The ano entrada. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int? AnoEntrada { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the documento. </summary>
        ///
        /// <value> The documento. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Documento { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the estabelecimento. </summary>
        ///
        /// <value> The identifier of the estabelecimento. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int? EstabelecimentoId { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the turma. </summary>
        ///
        /// <value> The identifier of the turma. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int? TurmaId { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the tipo pessoa. </summary>
        ///
        /// <value> The identifier of the tipo pessoa. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public TipoPessoaEnum TipoPessoaId { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Returns a string that represents the current object. </summary>
        ///
        /// <remarks>   Danim, 31/05/2016. </remarks>
        ///
        /// <returns>   A string that represents the current object. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override string ToString()
        {
            return string.Format("Matricula: {0}, Epc: {1}, Nome: {2}", Matricula, Epc, Name);
        }
    }
}