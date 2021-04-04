namespace Modul3_moduldz.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Modul3_moduldz.Services.Abstractions;

    public class ActionController
    {
        private readonly ILoggerService _loggerService;

        public ActionController()
        {
            _loggerService = LocatorService.LoggerService;
        }
    }
}
