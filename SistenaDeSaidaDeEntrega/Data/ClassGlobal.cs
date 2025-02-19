using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistenaDeSaidaDeEntrega.Data
{
    class ClassGlobal
    {

        // Val Global Saida

        private static bool restartetabela; 

        public static bool RestarteTabela
        {
            get { return restartetabela; } 
            set { restartetabela = value; }
        }

        private static bool editar;

        public static bool Editar
        {
            get { return editar; }
            set { editar = value; }
        }

        private static string linhaAtual;

        public static string LinhaAtual
        {
            get { return linhaAtual; }
            set { linhaAtual = value; }
        }


        // Val Global Motorista Tela

        private static bool editarMotorista;

        public static bool EditarMotorista
        {
            get { return editarMotorista; }
            set { editarMotorista = value; }
        }

        private static bool restarteTabelaMotorista;

        public static bool RestarteTabelaMotorista
        {
            get { return restarteTabelaMotorista; }
            set { restarteTabelaMotorista = value; }
        }




    }
}
