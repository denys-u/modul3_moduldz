using System;
using System.Collections.Generic;
using System.Text;

namespace Modul3_moduldz.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Modul3_moduldz.Services.Abstractions;

    public class FileService : IFileService
    {
        public IDisposable CreateStreamForWrite(string path)
        {
            return new StreamWriter(path, true, Encoding.Default);
        }

        public void WriteToStream(IDisposable stream, Stream text)
        {
            var streamWrite = (StreamWriter)stream;

            streamWrite.WriteLine(text);
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }

        public string ReadAllText(string path) => File.ReadAllText(path);

        public DateTime GetCreationTime(string path) => File.GetCreationTime(path);
    }
}
