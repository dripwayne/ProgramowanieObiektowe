using System;
namespace Lab_3
{
    public interface ILogger:IDisposable 
    {
        void Log(params String[] messages);
    }
}
