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

        Elevador elevador;

        public TelaPrincipal()
        {
            InitializeComponent();

            elevador = new Elevador();

            AndarAtual.Text = elevador.GetAndar().ToString();
            SituacaoAtual.Text = elevador.GetSituacao().ToString();

        }



        private void bot4_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(4, AndarAtual, SituacaoAtual);
            elevador.setAndar(4);
        }

        private void bot3_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(3, AndarAtual, SituacaoAtual);
            elevador.setAndar(3);
        }

        private void bot2_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(2, AndarAtual, SituacaoAtual);
            elevador.setAndar(2);
        }

        private void bot1_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(1, AndarAtual, SituacaoAtual);
            elevador.setAndar(1);
        }

        private void bot0_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(0, AndarAtual, SituacaoAtual);
            elevador.setAndar(0);
        }

        private void botDesce4_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(4, AndarAtual, SituacaoAtual);
            elevador.setAndar(4);
        }

        private void botSobe0_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(0, AndarAtual, SituacaoAtual);
            elevador.setAndar(0);
        }

        private void botSobe3_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(3, AndarAtual, SituacaoAtual);
            elevador.setAndar(3);
        }

        private void botDesce3_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(3, AndarAtual, SituacaoAtual);
            elevador.setAndar(3);
        }

        private void botSobe2_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(2, AndarAtual, SituacaoAtual);
            elevador.setAndar(2);
        }

        private void botDesce2_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(2, AndarAtual, SituacaoAtual);
            elevador.setAndar(2);
        }

        private void botSobe1_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(1, AndarAtual, SituacaoAtual);
            elevador.setAndar(1);
        }

        private void botDesce1_Click(object sender, EventArgs e)
        {
            elevador.mudaAndar(1, AndarAtual, SituacaoAtual);
            elevador.setAndar(1);
        }
    }
}

