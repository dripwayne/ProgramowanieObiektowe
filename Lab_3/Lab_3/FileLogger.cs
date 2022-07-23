using System;
using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
namespace Lab_3
{
    public class FileLogger:WritterLogger
    {

        private bool disposed;
        string path;
        protected FileStream fileStream;
        public FileLogger(string path)
        {
            this.path = path;
        }
        ~FileLogger()
        {
            this.Dispose();
        }
        public  void Dispose(bool disposing)
        {
            fileStream.Dispose();
            path = null;
            disposed = true;

        }
    }
}
