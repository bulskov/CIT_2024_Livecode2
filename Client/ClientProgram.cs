
using System.Net;
using System.Net.Sockets;

var port = 5000;

var client = new TcpClient();

client.Connect(IPAddress.Loopback, port);

Console.WriteLine("Client connected!!!");