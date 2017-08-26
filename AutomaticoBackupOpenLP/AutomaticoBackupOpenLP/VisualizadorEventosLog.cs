using System;
using System.Diagnostics;

namespace AutomaticoBackupOpenLP
{
    public class VisualizadorEventosLog
    {        
        public EventLog Log(string nomeLog)
        {
            try
            {
                if (!EventLog.SourceExists(nomeLog))
                {
                    EventLog.CreateEventSource(nomeLog, nomeLog);
                }

                EventLog log = new EventLog();
                log.Source = nomeLog;

                return log;
            }
            catch (Exception e)
            {
                EventLog log = new EventLog();
                log.Source = nomeLog;

                log.WriteEntry(e.Message + e.StackTrace, EventLogEntryType.Error);
                throw;
            }
        }
    }
}
