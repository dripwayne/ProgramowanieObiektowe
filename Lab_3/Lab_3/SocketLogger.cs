using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
namespace Lab_3
{
    public class SocketLogger: ILogger
    {
        private ClientSocket clientSocket;
        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);
        }

        public void Log(params string[] messages)
        {
            for(int i =0; i< messages.Length; i++)
            {
                byte[] messageByte = Encoding.UTF8.GetBytes(messages[i]);
                clientSocket.Send(messageByte);
                byte[] responseBuffer = new byte[1024];
                int responseSize = clientSocket.Receive(responseBuffer);
                string responseText = Encoding.UTF8.GetString(responseBuffer, 0, responseSize);
            }
            clientSocket.Close();
        }
        ~SocketLogger()
        {
            this.Dispose();
        }

        public void Dispose(bool disposing)
        {
            clientSocket = null;
        }
        public void Dispose()
        {
            clientSocket.Dispose();
        }

      
    }
}
