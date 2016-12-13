using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace CommandServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var listener = new TcpListener(IPAddress.Loopback, 11000);
            listener.Start();
            while (true)
            {
                using (var client = listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                using (var output = File.Create("result.txt"))
                {
                    Console.WriteLine("Client connected. Starting to receive the file");

                    // read the file in chunks of 1KB
                    var buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                    driveExecute(output);
                }
               
            }
            
        }
        public static void driveExecute(FileStream instructions)
        {
            String lineOfText;
            var file = new System.IO.StreamReader(instructions, System.Text.Encoding.UTF8, true, 128);
            while ((lineOfText = file.ReadLine()) != null)
            {
                Console.WriteLine(lineOfText);
            }
        }
    }
}
