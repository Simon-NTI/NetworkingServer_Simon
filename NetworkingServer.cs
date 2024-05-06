using System.Net.Sockets;

namespace NetworkingServer_Simon;

class NetworkingServer
{
    static void Main(string[] args)
    {
        TcpListener? server = null;
        TcpClient client;

        //8080 or 80 are common ports for local host services
        short portNumber = 8080;

        if(args.Length >= 1)
        {
            portNumber = short.Parse(args[0]);
        }

        //Create server side socket
        try
        {
            server = new TcpListener(portNumber);
        }
        catch(IOException ie)
        {
            Console.WriteLine("Cannot open socket." + ie.Message);
            Environment.Exit(1);
        }

        //Wait for data from the client and reply
        while (true)
        {
            try
            {
                /* Listens for a connection to be made to this socket and accepts it
                The method blocks until a connection is made */
                Console.WriteLine("Waiting for connect request...");
                server.AcceptSocket();

                Console.WriteLine("Connect request is accepted...");

                //string clientHost = 
            }
        }
    }
}