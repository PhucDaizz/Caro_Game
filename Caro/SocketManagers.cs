using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace GameCaro
{
    public class SocketManager
    {
        #region Client
        private Socket client;

        public bool ConnectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(iep);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to server: " + ex.Message);
                return false;
            }
        }
        #endregion

        #region Server
        private Socket server;

        public void CreateServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Bind(iep);
                server.Listen(10);

                Thread acceptClient = new Thread(() =>
                {
                    client = server.Accept();
                    Console.WriteLine("Client connected");
                })
                {
                    IsBackground = true
                };
                acceptClient.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating server: " + ex.Message);
            }
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
        public int PORT = 9999;
        public const int BUFFER = 1024;
        public bool isServer = true;

        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);

            return SendData(client, sendData);
        }

        public object Receive()
        {
            byte[] receiveData = new byte[BUFFER];
            bool isOk = ReceiveData(client, receiveData);

            return isOk ? DeserializeData(receiveData) : null;
        }

        private bool SendData(Socket target, byte[] data)
        {
            try
            {
                int bytesSent = target.Send(data);
                return bytesSent > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending data: " + ex.Message);
                return false;
            }
        }

        private bool ReceiveData(Socket target, byte[] data)
        {
            try
            {
                int bytesReceived = target.Receive(data);
                return bytesReceived > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error receiving data: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Nén đối tượng thành mảng byte[] bằng JSON
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public byte[] SerializeData(object o)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(o);
                return Encoding.UTF8.GetBytes(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error serializing data: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Giải nén mảng byte[] thành đối tượng object bằng JSON
        /// </summary>
        /// <param name="theByteArray"></param>
        /// <returns></returns>
        public object DeserializeData(byte[] theByteArray)
        {
            try
            {
                string jsonString = Encoding.UTF8.GetString(theByteArray);
                return JsonSerializer.Deserialize<object>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deserializing data: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Lấy ra IP V4 của card mạng đang dùng
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                            break;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(output))
                    break;
            }
            return output;
        }

        #endregion
    }
}
