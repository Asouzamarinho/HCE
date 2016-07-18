﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Model\Beans\SyncNamedBean.cs
//
// summary:	Implements the synchronise named bean class
////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Cruzeiro.Core.Model.Beans
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A synchronise named bean. </summary>
    ///
    /// <remarks>   Danim, 31/05/2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class SyncNamedBean : SyncBean
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Name { get; set; }
    }
}