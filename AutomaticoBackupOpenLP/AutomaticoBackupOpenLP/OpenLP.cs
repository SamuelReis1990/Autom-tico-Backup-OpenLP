using System;
using System.Collections.Generic;
using AutomaticoBackupOpenLP.Model;
using System.Configuration;
using System.ServiceProcess;
using System.Diagnostics;
//using System.Data.SQLite;

namespace AutomaticoBackupOpenLP
{
    public class OpenLP
    {
        private string teste;
        //#region Backup Músicas

        //public List<RsMusicas> getDados()
        //{
        //    try
        //    {

        //        string connectionString = ConfigurationManager.AppSettings["ConnectionString"];

        //        string sqlCommand = @" SELECT s.last_modified data_musica" +
        //                                         ", s.title nome_musica" +
        //                                         ", s.alternate_title nome_musica_alternativa" +
        //                                         ", a.display_name nome_autor" +
        //                                         ", s.lyrics letra_musica" +
        //                                     " FROM songs s" +
        //                                         ", authors_songs ass" +
        //                                         ", authors a" +
        //                                    " WHERE s.id = ass.song_id" +
        //                                      " AND a.id = ass.author_id";

        //        var rsDataReader = Util.ConexaoBase("sqlite", connectionString, sqlCommand);

        //        SQLiteDataReader rsQuery = (SQLiteDataReader)rsDataReader;

        //        List<RsMusicas> musicas = new List<RsMusicas>();

        //        while (rsQuery.Read())
        //        {
        //            RsMusicas musica = new RsMusicas();

        //            musica.data_musica = rsQuery["data_musica"].ToString();
        //            musica.nome_musica = rsQuery["nome_musica"].ToString();
        //            musica.nome_musica_alternativa = rsQuery["nome_musica_alternativa"].ToString();
        //            musica.nome_autor = rsQuery["nome_autor"].ToString();
        //            musica.letra_musica = rsQuery["letra_musica"].ToString();

        //            musicas.Add(musica);
        //        }

        //        return musicas;
        //    }
        //    catch (Exception e)
        //    {
        //        Util.GeraArquivoLog(e);
        //        throw new Exception();
        //    }
        //}

        //private RetornoXml montaXml(RsMusicas musica)
        //{
        //    try
        //    {
        //        string xml = @"<?xml version='1.0' encoding='UTF-8'?>" +
        //                        "<song xmlns='http://openlyrics.info/namespace/2009/song' version='0.8' createdIn='OpenLP 2.4.4' modifiedIn='OpenLP 2.4.4' modifiedDate='{0}'>" +
        //                        "<properties>" +
        //                        "<titles>" +
        //                        "<title>{1}</title>" +
        //                        "<title>{2}</title>" +
        //                        "</titles>" +
        //                        "<authors>" +
        //                        "<author>{3}</author>" +
        //                        "</authors>" +
        //                        "</properties>";

        //        xml = string.Format(xml, musica.data_musica
        //                               , musica.nome_musica
        //                               , musica.nome_musica_alternativa
        //                               , musica.nome_autor);

        //        XmlDocument xmlDocument = new XmlDocument();
        //        xmlDocument.LoadXml(musica.letra_musica);

        //        foreach (XmlNode xn in xmlDocument.SelectNodes("/song/lyrics/verse"))
        //        {
        //            XmlAttribute name = xmlDocument.CreateAttribute("name");

        //            XmlElement lines = xmlDocument.CreateElement("lines");

        //            name.Value = xn.Attributes["type"].Value + xn.Attributes["label"].Value;

        //            lines.InnerText = xn.InnerText;

        //            xn.RemoveAll();

        //            xn.Attributes.Append(name);
        //            xn.AppendChild(lines);
        //        }

        //        xml = xml + xmlDocument.DocumentElement.InnerXml + "</song>";

        //        RetornoXml retorno = new RetornoXml();

        //        retorno.nome_musica = musica.nome_musica;
        //        retorno.nome_autor = musica.nome_autor;
        //        retorno.xml = xml;

        //        return retorno;
        //    }
        //    catch (Exception e)
        //    {
        //        Util.GeraArquivoLog(e);
        //        throw new Exception();
        //    }
        //}

        //public void gravaMusica(RsMusicas musica)
        //{
        //    try
        //    {
        //        RetornoXml resultado = montaXml(musica);

        //        string nomeArquivo = resultado.nome_musica + " (" + resultado.nome_autor + ").xml";

        //        string caminho = ConfigurationManager.AppSettings["CaminhoFisico"] + @"Músicas\";

        //        File.WriteAllText(Path.Combine(caminho, nomeArquivo), resultado.xml);
        //    }
        //    catch (Exception e)
        //    {
        //        if (e.HResult.Equals(-2147024893))
        //        {
        //            Directory.CreateDirectory(ConfigurationManager.AppSettings["CaminhoFisico"] + @"Músicas");
        //            gravaMusica(musica);
        //        }
        //        else
        //        {
        //            Util.GeraArquivoLog(e);
        //            throw new Exception();
        //        }
        //    }
        //}

        //#endregion
    }
}
