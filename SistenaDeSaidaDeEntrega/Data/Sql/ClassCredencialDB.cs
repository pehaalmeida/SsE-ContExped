using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContExped.Properties;

namespace SistenaDeSaidaDeEntrega.Data.Sql
{
    class ClassCredencialDB
    {
        // Informação do projeto 
        public const string NomeProjeto = "SsE";

        // Informação do Banco De Dado

        

        // Informação do Banco De Dado (Sql Server) 
        public static string DadosConexao()
        {

            try
            {
                string IpServer = Settings.Default["ipServidorDB"].ToString();
                string LoginDB = Settings.Default["LoginDB"].ToString();
                string SenhaDB = Settings.Default["SenhaDB"].ToString();

                string Server = IpServer;
                string NomeDB = "SsE";
                string Login = LoginDB;
                string Senha = SenhaDB;

                return "server=" + Server + ";User Id=" + Login + ";database=" + NomeDB + "; password=" + Senha;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro (" + e.Message + ")", "Erro");
                throw;
            }
        }


    }
}
