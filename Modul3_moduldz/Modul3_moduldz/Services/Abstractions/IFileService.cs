using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3_moduldz.Services.Abstractions
{
    public interface IFileService
    {
        IDisposable CreateStreamForWrite(string path);
        void WriteToStream(IDisposable stream, string text);
        void Delete(string path);
        string ReadAllText(string path);
        DateTime GetCreationTime(string path);
    }
}
