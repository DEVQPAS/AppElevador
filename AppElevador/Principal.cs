using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppElevador
{
   
    public partial class TelaPrincipal : Form
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

            public void MudaAndar()
            {
                if (Andar == 0)
                {
                    for (int i = 0; i <= 4; i++)
                    {

                    }
                } else if (Andar == 1)
                {

                } else if (Andar == 2)
                {

                } else if (Andar == 3)
                {

                } else if (Andar == 4)
                {

                }
            }

            public int GetAndar()
            {
                return Andar;
            }

            public string GetSituacao()
            {
                return Situacao;
            }

            public void SetAndar(int andar)
            {
                Andar = andar;
            }

            public void SetSituacao(string situacao)
            {
                Situacao = "situacao";
            }
        }


        public TelaPrincipal()
        {
            InitializeComponent();

            Elevador elevador = new Elevador();

            //elevador.SetAndar(4);


            AndarAtual.Text = elevador.GetAndar().ToString();
            SituacaoAtual.Text = elevador.GetSituacao().ToString();
            
            if (AndarAtual.Text == "0")
            {
                for (int i = 0; i <= 4; i++)
                {
                    AndarAtual.Text = i.ToString();
                    SituacaoAtual.Text = "subindo";
                    Thread.Sleep(2000);
                }
            }
        }

        private void bot4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
