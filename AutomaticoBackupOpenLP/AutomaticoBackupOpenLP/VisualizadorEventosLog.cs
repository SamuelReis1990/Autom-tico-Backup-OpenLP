using System.Diagnostics;

namespace AutomaticoBackupOpenLP
{
    public class VisualizadorEventosLog
    {
        public EventLog Log(string nomeLog)
        {
            if (!EventLog.SourceExists(nomeLog))
            {
                EventLog.CreateEventSource(nomeLog, nomeLog);
            }

            EventLog log = new EventLog();
            log.Source = nomeLog;

            return log;
        }
    }
}
