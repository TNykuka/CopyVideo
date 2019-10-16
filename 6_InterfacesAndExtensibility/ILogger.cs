using System;

namespace _6_InterfacesAndExtensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message, DateTime now);
    }
}
