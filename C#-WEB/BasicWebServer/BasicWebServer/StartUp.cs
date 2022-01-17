using BasicWebServer.Server;
using System.Net;
using System.Net.Sockets;
using System.Text;


var server = new HttpServer("127.0.0.1", 8080);
server.Start();


/*
var ipAddress = IPAddress.Parse("127.0.0.1");
var port = 8080;

var serverListener = new TcpListener(ipAddress, port);

serverListener.Start();

Console.WriteLine($"Listening on port {port}");


while (true)
{
    var connection = serverListener.AcceptTcpClient();

    var networStream = connection.GetStream();

    var content = "Hello World";

    var contentLength = Encoding.UTF8.GetByteCount(content);

    var response = $@"HTTP/1.1 200 OK
Content-Type: text/plain; charset=UTF-8
Content-Length: {contentLength}

{content}";

    var responseButes = Encoding.UTF8.GetBytes(response);

    networStream.Write(responseButes);

    //connection.Close();
}
*/