using RobotCtrl;
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
            var listener = new TcpListener(IPAddress.Parse("192.168.1.15"), 8080);
            listener.Start();
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
                driveExecute();

            }
            
        }
        public static void driveExecute()
        {

            var instructions = File.OpenRead("result.txt");
            String lineOfText;
            var file = new System.IO.StreamReader(instructions, System.Text.Encoding.UTF8, true, 128);
            while ((lineOfText = file.ReadLine()) != null)
            {
                parseStatement(lineOfText);
                Console.WriteLine(lineOfText);
            }
        }

        public static void parseStatement(String statement)
        {
            
        Robot robot = new Robot();
            float speed = 0.5f;
            float acceleration = 0.3f;
            robot.Drive.Power = true;

        char delimenter = ' ';
            String[] part = statement.Split(delimenter);
             switch (part[0])
            {
                case "TrackLine":
                    roboter.Drive.RunLine(float.Parse((part[1])), 2, 2);
                    break;
                case "TrackTurnLeft":
                    robot.Drive.RunTurn(float.Parse((part[1])), speed, acceleration);
                    break;
                case "TrackTurnRight":
                    robot.Drive.RunTurn(float.Parse((part[1]))*-1, speed, acceleration);
                    break;
                case "TrackArcLeft":
                    robot.Drive.RunArcLeft(float.Parse((part[1])), float.Parse((part[1])), speed, acceleration);
                break;
                case "TrackArcRight":
                    robot.Drive.RunArcRight(float.Parse((part[1])), float.Parse((part[1])), speed, acceleration);
                    break;
                case "Start":
                    Console.WriteLine("Case 1");
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }

    }
}
