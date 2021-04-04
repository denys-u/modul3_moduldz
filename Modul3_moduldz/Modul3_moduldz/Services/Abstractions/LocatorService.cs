namespace Modul3_moduldz.Services.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class LocatorService
    {
        private static readonly LoggerService _loggerService = new LoggerService();

        public static ILoggerService LoggerService => _loggerService;

    }
}
