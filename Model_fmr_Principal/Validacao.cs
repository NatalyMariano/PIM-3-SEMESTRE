using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_3º_SEMESTRE.Model_fmr_Principal
{
    public class Validacao
    {
        public string ValidarTextBoxes(TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(textBoxes[i].Text))
                {
                    return $"Por favor, preencha todos os campos!";
                }
                else
                {
                    if (!int.TryParse(textBoxes[i].Text, out int resposta))
                    {
                        return $"Por favor, insira apenas números inteiros!";
                    }
                    else
                    {
                        if (resposta < 0 || resposta > 5)
                        {
                            return $"Por favor, insira valores entre 0 e 5!";
                        }
                    }
                }
            }
            return "";
        }
    }

}

