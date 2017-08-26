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

        public object Sqlite(string connectionString, string sqlCommand, string dml = "select")
        {
            try
            {                
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + connectionString);

                conn.Open();

                using (var conexao = new SQLiteCommand(conn))
                {
                    if (dml.Equals("select"))
                    {
                        conexao.CommandText = sqlCommand;
                        conexao.ExecuteNonQuery();
                        return conexao.ExecuteReader();
                    }
                    else
                    {
                        using (var transaction = conn.BeginTransaction())
                        {
                            conexao.CommandText = sqlCommand;
                            conexao.ExecuteNonQuery();

                            transaction.Commit();
                        }
                        return "Operação realizada com sucesso.";
                    }
                }                
            }
            catch (Exception e)
            {
                log.WriteEntry(e.Message, EventLogEntryType.Error);
                throw;
            }
        }
    }
}
