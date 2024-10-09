﻿
using System.Net;
using System.Net.Sockets;

var port = 5000;

var server = new TcpListener(IPAddress.Loopback, port); // IPv4 127.0.0.1 IPv6 ::1
server.Start();

Console.WriteLine($"Server started on port {port}");

while(true)
{
    var client = server.AcceptTcpClient();
    Console.WriteLine("Client connected!!!");
}
