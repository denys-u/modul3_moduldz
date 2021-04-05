namespace Modul3_moduldz.Services.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Modul3_moduldz.Configs;

    public interface IConfigService
    {
        LoggerConfig LoggerConfig { get; }
    }
}
