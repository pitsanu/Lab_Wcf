using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress ep = new EndpointAddress("http://localhost:8000/HelloIndigo/HelloIndigoService");
            IHelloIndigoService proxy = ChannelFactory<IHelloIndigoService>.CreateChannel(new BasicHttpBinding(), ep);
            string s = proxy.HelloIndigo();

            System.Console.WriteLine(s);
            System.Console.WriteLine("Press <ENTER> to terminate Client.");
            System.Console.ReadLine();
        }
    }
}
