using System;
using Renci.SshNet.NetConf;
using System.Xml;

namespace Renci.SshNet
{
    internal partial interface IServiceFactory
    {
        /// <summary>
        /// Creates a new <see cref="INetConfSession"/> in a given <see cref="ISession"/>
        /// and with the specified operation timeout.
        /// </summary>
        /// <param name="session">The <see cref="ISession"/> to create the <see cref="INetConfSession"/> in.</param>
        /// <param name="operationTimeout">The operation timeout.</param>
        /// <param name="ClienCapabilities">The XmlDoxument object describing NetConf client capabilities</param>
        /// <returns>
        /// An <see cref="INetConfSession"/>.
        /// </returns>
        INetConfSession CreateNetConfSession(ISession session, TimeSpan operationTimeout, XmlDocument ClienCapabilities);
    }
}
