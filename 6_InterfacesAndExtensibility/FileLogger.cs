using System;
using Microsoft.Build.Evaluation;

namespace _6_InterfacesAndExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        private object c;
        private Project project;
        private object txt;

        public FileLogger(string path)
        {
            _path = path;
        }

        public FileLogger(object C, Project project, object txt)
        {
            c = C;
            this.project = project;
            this.txt = txt;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message, DateTime now)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using(var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.Witeline(messageType +": " + message);
            }
        }
    }
}
