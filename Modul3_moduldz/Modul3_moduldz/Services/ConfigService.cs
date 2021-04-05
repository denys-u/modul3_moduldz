namespace Modul3_moduldz.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Modul3_moduldz.Configs;
    using Modul3_moduldz.Services.Abstractions;

    public class ConfigService : IConfigService
    {
        private readonly string _filePath = "config.json";
        private readonly LoggerConfig _loggerConfig;
        private readonly IFileService _fileService;

        public ConfigService()
        {
            _fileService = LocatorService.FileService;

            var config = GetConfig();
            _loggerConfig = config.Logger;
        }

        public LoggerConfig LoggerConfig => _loggerConfig;

        private Config GetConfig()
        {
            var json = _fileService.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<Config>(json);
        }
    }
}
