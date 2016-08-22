using System;
using Renci.SshNet.NetConf;
using System.Xml;

namespace Renci.SshNet
{
    internal partial class ServiceFactory
    {
    /// <summary>
    /// Creates a new <see cref="INetConfSession"/> in a given <see cref="ISession"/>
    /// and with the specified operation timeout.
    /// </summary>
    /// <param name="session">The <see cref="ISession"/> to create the <see cref="INetConfSession"/> in.</param>
    /// <param name="operationTimeout">The operation timeout.</param>
    /// <param name="clientCapabilities">The XmlDocument object describing NetConf client capabilities</param>
    /// <returns>
    /// An <see cref="INetConfSession"/>.
    /// </returns>
    public INetConfSession CreateNetConfSession(ISession session, TimeSpan operationTimeout, XmlDocument clientCapabilities)
    {
      return new NetConfSession(session, operationTimeout, clientCapabilities);
    }
    }
}
