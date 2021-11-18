using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppElevador
{
    class Elevador
    {
        private int Andar;
        private string Situacao;

        public Elevador()
        {
            this.Andar = 0;
            this.Situacao = "Parado";
        }

        public void setAndar(int andar)
        {
            this.Andar = andar;

        }

        public async void mudaAndar(int andar, TextBox txtAndar, TextBox txtStatus)
        {
            if (Andar < andar)
            {
                for (int i = Andar; i <= andar; i++)
                {
                    txtStatus.Text = "Subindo";
                    txtAndar.Text = i.ToString();
                    await Task.Delay(1000);
                }
            }
            else
            {
                for (int i = Andar; i >= andar; i--)
                {
                    txtStatus.Text = "Descendo";
                    txtAndar.Text = i.ToString();
                    await Task.Delay(1000);
                }
            }

            txtStatus.Text = "Parado";
        }

        public int GetAndar()
        {
            return Andar;
        }

        public string GetSituacao()
        {
            return Situacao;
        }


    }
}
