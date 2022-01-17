using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.Server
{
    public class HttpServer
    {
        private readonly IPAddress ipAddress;
        private readonly int port;
        private readonly TcpListener serverListener;

        public HttpServer(string _ipAddress, int _port)
        {
            ipAddress = IPAddress.Parse(_ipAddress);
            port = _port;
            serverListener = new TcpListener(ipAddress, port);
        }

        public void Start()
        {
            serverListener.Start();
            Console.WriteLine($"Listening on port {port}");



            while (true)
            {
                var connection = serverListener.AcceptTcpClient();
                var networStream = connection.GetStream();

                string request = ReadRequest(networStream);
                Console.WriteLine(request);
                WriteResponse(networStream, "HeLLo WorlD");

                //connection.Close();
            }



        }

        private static void WriteResponse(NetworkStream networStream, string message)
        {
            var contentLength = Encoding.UTF8.GetByteCount(message);

            var response = $@"HTTP/1.1 200 OK
Content-Type: text/plain; charset=UTF-8
Content-Length: {contentLength}

{message}";

            var responseButes = Encoding.UTF8.GetBytes(response);

            networStream.Write(responseButes);
        }

        private string ReadRequest(NetworkStream networkStream)
        {
            var buferLength = 1024;
            var buffer = new byte[buferLength];

            var totalButes = 0;

            var requestBuilder = new StringBuilder();

            do
            {
                var bytesRead = networkStream.Read(buffer, 0, buferLength);

                totalButes += bytesRead;

                if (totalButes > 10*1024)
                {
                    throw new InvalidOperationException("Request is too large.");
                }

                requestBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
            }
            //May not run correctly over the Internet
            while (networkStream.DataAvailable);

            return requestBuilder.ToString();

        }
    }
}
