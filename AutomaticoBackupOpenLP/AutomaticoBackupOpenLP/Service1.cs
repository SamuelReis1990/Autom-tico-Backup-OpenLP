using System;
using System.Configuration;
using System.ServiceProcess;
using System.Threading;

namespace AutomaticoBackupOpenLP
{
    public partial class Service1 : ServiceBase
    {

        private Timer tempo;
        private readonly int intervalo = Convert.ToInt32(ConfigurationManager.AppSettings["timer"].ToString());

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("O serviço Backup Automático OpenLP acaba de inicializar.");
            tempo = new Timer((RealizaBackup), null, 0, intervalo);
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("O serviço Backup Automático OpenLP acaba de finalizar.");
        }

        private static void RealizaBackup(object state)
        {
            //try
            //{
            //    OpenLP openLp = new OpenLP();

            //    List<rsMusicas> musicas = openLp.getDados();

            //    foreach (var musica in musicas)
            //    {
            //        openLp.gravaMusica(musica);
            //    }

            //    var diretorios = Directory.GetDirectories(ConfigurationManager.AppSettings["CaminhoTemas"]);

            //    foreach (var pasta in diretorios)
            //    {
            //        openLp.gravaTema(pasta);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Util.GeraArquivoLog(e, "S");
            //}
        }
    }
}
