﻿using Microsoft.ServiceFabric.Services.Runtime;
using System.Fabric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Communication.Runtime;

namespace Customer.service
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class service : StatelessService
    {
        public service(StatelessServiceContext context)
            : base(context)
        { }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new[] {
            new ServiceInstanceListener(initParams => new OwinCommunicationListener("api", new Startup(), initParams))
        };
        }
    }
}
