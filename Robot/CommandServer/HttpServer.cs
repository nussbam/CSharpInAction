using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CommandServer {

    /// <summary>
    /// Hacked together Http-Server with TCP-Sockets.
    /// 
    /// Usage:
    ///            HttpServer server = new HttpServer(IPAddress.Loopback, 80);
    ///            server.Serve();
    ///            server.content = @"<html></html>";
    /// </summary>
    class HttpServer
    {

        private String filename;
        public String content { get; set; } = @"
<html>
<head>
    <title>HTTP</title >
</head>
<body>
    <p>HTTP/1.1-Demo</p>
</body>
</html>";

        private TcpListener tcpListener;

        public HttpServer(IPAddress listenIpAddress, int port)
        {
            tcpListener = new TcpListener(listenIpAddress, port);
        }

        private void Listen()
        {
            Console.WriteLine("Started serving");
            tcpListener.Start();
            while (true)
            {
                using (var client = tcpListener.AcceptTcpClient())
                using (var stream = client.GetStream())
                {
                    Console.WriteLine("Client connected. Checking if HTTP");

                    // read the file in chunks of 1KB
                    var buffer = new byte[1024];

                    int bytesRead;
                    try
                    {
                        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            var request = Encoding.Default.GetString(buffer, 0, bytesRead);
                            if (request.Contains("HTTP")) {
                                var bytes = Encoding.Default.GetBytes(@"HTTP/1.1 200 OK
                                Server: ExperimentalWebServer 1.0
                                Content-type: text/html
                                Content-length: " + content.Length + @"

                                " + content);
                                Console.WriteLine("Sendinding HTTP-Response to client");
                                stream.Write(bytes, 0, bytes.Length);
                                stream.Flush();
                                break;
                            }
                        }
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Stream closed unexpectedly");
                    }

                }
            }
        }

        public void Serve()
        {
            Thread t = new Thread(Listen);
            t.Start();
        }
    }
}
