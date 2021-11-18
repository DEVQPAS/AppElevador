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
        // Declara objeto elevador
        Elevador elevador;

        // Inicia tela principal do forms

        public TelaPrincipal()
        {
            InitializeComponent();

            elevador = new Elevador();

            AndarAtual.Text = elevador.GetAndar().ToString();
            SituacaoAtual.Text = elevador.GetSituacao().ToString();

        }

        // Aciona comandos ao clique dos botões do forms

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

