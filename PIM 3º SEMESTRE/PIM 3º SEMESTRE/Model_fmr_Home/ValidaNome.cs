using System;
using System.Text.RegularExpressions; // Importe esta linha para usar expressões regulares
using System.Windows.Forms;

namespace PIM_3º_SEMESTRE.Model_fmr_Home
{
    internal class ValidaNome
    {
        public string validaNome(string txtNome)
        {
            Regex regex = new Regex(@"^[A-Za-z\s]+$");
            if (regex.IsMatch(txtNome))
            {

                return "";
            }
            else
            {
                return "O texto não é um nome válido. Por favor, insira apenas letras e espaços.";
            }
        }
    }
}
