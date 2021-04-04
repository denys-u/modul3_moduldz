namespace Modul3_moduldz.Configs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LoggerConfig
    {
        public string DirectoryPath { get; set; }
        public string ExtensionFile { get; set; }
        public string NameFormat { get; set; }
        public int BackUpCount { get; set; }
    }
}
