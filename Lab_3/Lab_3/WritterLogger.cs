using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
namespace Lab_3
{
    public abstract class WritterLogger : ILogger
    {
        protected TextWriter writer;
        string path = @" /Users/tomasz/Projects/file.txt";
        public virtual void Log(params string[] messages)
        {
            using (FileStream stream = new FileStream(path, FileMode.Append)) // opens files in append mode (each time text is added)
            {
                using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
                { writer.Write($"{DateTime.Now}:");
                    for(int i=0; i < messages.Length; i++)
                    {
                        writer.Write(messages[i]);

                    }
                    writer.Write("\n");
                    writer.Flush();

                }
            }

        }
        public void Dispose()
        {
            writer.Dispose();
        }
    }
}
