﻿using System;
using Cruzeiro.Core.Bll;
using Cruzeiro.Core.Model.Enum;

namespace Cruzeiro.Core.Model.Beans
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An evento bean. </summary>
    ///
    /// <remarks>   Danim, 31/05/2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class EventoBean : SyncBean
    {
        public int PessoaId { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the sentido evento. </summary>
        ///
        /// <value> The sentido evento. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public SentidoEventoEnum SentidoEvento { get; set; }
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the date time. </summary>
        ///
        /// <value> The date time. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime DateTime { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the portal. </summary>
        ///
        /// <value> The portal. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string PortalName { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the status evento. </summary>
        ///
        /// <value> The status evento. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public StatusEventoEnum StatusEvento { get; set; }
    }
}