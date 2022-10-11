using HelloRemotingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloRemotingService.HelloRemotingService remotingService =
                new HelloRemotingService.HelloRemotingService();
            TcpChannel channel = new TcpChannel(8081);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService), "GetMessage",
               WellKnownObjectMode.Singleton);
            Console.WriteLine("Host started @ " + DateTime.Now.ToString());
            Console.ReadLine();
        }
    }
}
