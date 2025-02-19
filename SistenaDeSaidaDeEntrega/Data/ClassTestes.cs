using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistenaDeSaidaDeEntrega.Data
{
    class ClassTestes
    {

        public bool Testacampos(string text, string msg)
        {
            if (text == "" || text == null)
            {
                MessageBox.Show("Porfavor digite um " + msg + "valido!!");

                return false;

            }
            return true;
        }
        public bool TestaComboBox(ComboBox comboBox, string msg)
        {
            if (comboBox.Text == "" || comboBox.Text == null)
            {
                MessageBox.Show("Porfavor selecione um " + msg + "valido!!");
                return false;

            }
            return true;
        }

        public static void ApNumeroComVirgula(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
            }
        }


        public static void ApenasNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

    }
}
