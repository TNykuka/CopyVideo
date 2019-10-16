using System;

namespace _6_InterfacesAndExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migrationg Startes at {0}", DateTime.Now);

            // Details of migrating the datadase

            _logger.LogInfo("Migrationg finished at {0}", DateTime.Now);
        }
    }
}
