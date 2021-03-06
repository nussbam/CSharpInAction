﻿using RobotCtrl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CommandServer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var listener = new TcpListener(IPAddress.Parse("192.168.1.15"), 8080);
            HttpServer server = new HttpServer(IPAddress.Parse("192.168.1.15"), 80);
            
            listener.Start();
            
            Thread workerThread = new Thread(server.Serve);
            workerThread.Start();
            
                
            while (true)
            {
                //File.Delete("result.txt");

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

                }
                driveExecute(server);

            }
            
        }
        public static void driveExecute(HttpServer server)
        {
            Robot robot = new Robot();
            
            robot.Drive.Power = true;
            string header = @"<html>
                <head>
                    <title> HTTP-Seite Mumi, Marc, Robin </title>
                </head>
                <body>
                <h1>Testat 2 - Mumi, Marc, Robin</h1>
                        ";
            string content = "";
            string footer = @"</body>
                </html>";
            var instructions = File.OpenRead("result.txt");
            String lineOfText;
            
            var file = new System.IO.StreamReader(instructions, System.Text.Encoding.UTF8, true, 128);
            while ((lineOfText = file.ReadLine()) != null)
            {
                while (!robot.Drive.Done)
                {
                    Thread.Sleep(100);
                }
                parseStatement(lineOfText, robot);
                content = content + @"<br />" + lineOfText;
                server.content = header + content + footer;
                Console.WriteLine(lineOfText);
            }
        }

        public static void parseStatement(String statement, Robot robot)
        {
            float speed = 0.5f;
            float acceleration = 0.3f;


            char delimenter = ' ';
            String[] part = statement.Split(delimenter);
             switch (part[0])
            {
                case "TrackLine":
                    robot.Drive.RunLine(float.Parse((part[1])), speed, acceleration);
                    
                    break;
                case "TrackTurnLeft":
                    robot.Drive.RunTurn(float.Parse((part[1])), speed, acceleration);
                    break;
                case "TrackTurnRight":
                    robot.Drive.RunTurn(float.Parse((part[1]))*-1, speed, acceleration);
                    break;
                case "TrackArcLeft":
                    robot.Drive.RunArcLeft(float.Parse((part[1])), float.Parse((part[2])), speed, acceleration);
                break;
                case "TrackArcRight":
                    robot.Drive.RunArcRight(float.Parse((part[1])), float.Parse((part[2])), speed, acceleration);
                    break;
                case "Stop":
                    Console.WriteLine("Fahrt beendet");
                    break;

                default:
                    break;
            }

        }

    }
}
