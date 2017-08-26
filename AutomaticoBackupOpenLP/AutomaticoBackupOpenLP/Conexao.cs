using System;
using System.Data.SQLite;
using System.Diagnostics;

namespace AutomaticoBackupOpenLP
{
    public class Conexao
    {
        EventLog log = null;

        public Conexao(EventLog eventLog)
        {
            log = eventLog;
        }

        public object Sqlite(string connectionString, string sqlCommand)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + connectionString);

                conn.Open();

                using (var conexao = new SQLiteCommand(conn))
                {
                    conexao.CommandText = sqlCommand;
                    conexao.ExecuteNonQuery();
                    return conexao.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                log.WriteEntry(e.Message + e.StackTrace, EventLogEntryType.Error);
                throw;
            }
        }
    }
}
