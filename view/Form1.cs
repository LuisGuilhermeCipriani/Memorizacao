using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memorizacao.controller;

namespace Memorizacao
{
    public partial class FormVerbosIrregulares : Form
    {
        VerboController verboController;
        int num = 0;
        Verbo verbo;

        public FormVerbosIrregulares()
        {
            InitializeComponent();
            
            verboController = new VerboController();
            verboController.preencheListaVerbos();
            verbo = verboController.getListaVerbos()[num];

            lbVariavelAcertos.Text = verboController.getlistaCorretos().Count().ToString();
            lbVariavelErros.Text = verboController.getlistaIncorretos().Count().ToString();

            inicializarExemplo();
            desativarTudo();
            
        }

        private void desativarTudo()
        {
            btInfinitivo.Enabled = false;
            btPassadoSimples.Enabled = false;
            btParticipioPassado.Enabled = false;
            btTraducao.Enabled = false;

            btEnviar.Enabled = false;
            btLimpar.Enabled = false;

            tbInfinitivo.Enabled = false;
            tbPassadoSimples.Enabled = false;
            tbParticipioPassado.Enabled = false;
            tbTraducao.Enabled = false;

            desativarCorretoIncorreto();            
        }

        private void desativarCorretoIncorreto()
        {
            lbCorretoInfinitivo.Visible = false;
            lbIncorretoInfinitivo.Visible = false;
            lbCorretoPassadoSimples.Visible = false;
            lbIncorretoPassadoSimples.Visible = false;
            lbCorretoParticipioPassado.Visible = false;
            lbIncorretoParticipioPassado.Visible = false;
            lbCorretoTraducao.Visible = false;
            lbIncorretoTraducao.Visible = false;
        }

        private void inicializarExemplo()
        {
            lbVariavelVerboIrregular.Text = verbo.getNome();
            lbVariavelInfinitivo.Text = verbo.getInfinitivo();
            lbVariavelPassadoSimples.Text = verbo.gepassadoSimples();
            lbVariavelParticipioPassado.Text = verbo.getparticipioPassado();
            lbVariavelTraducao.Text = verbo.gettraducao();

            lbVariavelPalavra.Text = verbo.getId().ToString();
            lbVariavelTotal.Text = verboController.getListaVerbos().Count.ToString();
        }

        private void liberarTudo()
        {
            lbVariavelInfinitivo.Text = "?";
            lbVariavelPassadoSimples.Text = "?";
            lbVariavelParticipioPassado.Text = "?";
            lbVariavelTraducao.Text = "?";

            btInfinitivo.Enabled = true;
            btPassadoSimples.Enabled = true;
            btParticipioPassado.Enabled = true;
            btTraducao.Enabled = true;

            tbInfinitivo.Enabled = true;
            tbPassadoSimples.Enabled = true;
            tbParticipioPassado.Enabled = true;
            tbTraducao.Enabled = true;

            btEnviar.Enabled = true;
            btLimpar.Enabled = true;
        }

        private void analisarespostaInfinitivo()
        {
            if (!tbInfinitivo.Text.Equals(""))
            {
                String texto = verboController.removeAcentos(tbInfinitivo.Text.ToLower());
                if (verboController.verificaInfinitivo(texto, verbo))
                {
                    verboController.getlistaCorretos().Add(verbo);
                    lbCorretoInfinitivo.Visible = true;
                    lbIncorretoInfinitivo.Visible = false;
                }
                else
                {
                    verboController.getlistaIncorretos().Add(verbo);
                    lbIncorretoInfinitivo.Visible = true;
                    lbCorretoInfinitivo.Visible = false;
                }
            }

            tbInfinitivo.Enabled = false;
        }

        private void analisarespostaPassadoSimples()
        {
            if (!tbPassadoSimples.Text.Equals(""))
            {
                String texto = verboController.removeAcentos(tbPassadoSimples.Text.ToLower());
                if (verboController.verificaPassadoSimples(texto, verbo))
                {
                    verboController.getlistaCorretos().Add(verbo);
                    lbCorretoPassadoSimples.Visible = true;
                    lbIncorretoPassadoSimples.Visible = false;
                }
                else
                {
                    verboController.getlistaIncorretos().Add(verbo);
                    lbIncorretoPassadoSimples.Visible = true;
                    lbCorretoPassadoSimples.Visible = false;
                }
            }

            tbPassadoSimples.Enabled = false;
        }

        private void analisarespostaParticipioPassado()
        {
            if (!tbParticipioPassado.Text.Equals(""))
            {
                String texto = verboController.removeAcentos(tbParticipioPassado.Text.ToLower());
                if (verboController.verificaParticipioPassado(texto, verbo))
                {
                    verboController.getlistaCorretos().Add(verbo);
                    lbCorretoParticipioPassado.Visible = true;
                    lbIncorretoParticipioPassado.Visible = false;
                }
                else
                {
                    verboController.getlistaIncorretos().Add(verbo);
                    lbIncorretoParticipioPassado.Visible = true;
                    lbCorretoParticipioPassado.Visible = false;
                }
            }

            tbParticipioPassado.Enabled = false;
        }

        private void analisarespostaTraducao()
        {
            if (!tbTraducao.Text.Equals(""))
            {
                String texto = verboController.removeAcentos(tbTraducao.Text.ToLower());
                if (verboController.verificaTraducao(texto, verbo))
                {
                    verboController.getlistaCorretos().Add(verbo);
                    lbCorretoTraducao.Visible = true;
                    lbIncorretoTraducao.Visible = false;
                }
                else
                {
                    verboController.getlistaIncorretos().Add(verbo);
                    lbIncorretoTraducao.Visible = true;
                    lbCorretoTraducao.Visible = false;
                }
            }

            tbTraducao.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            analisarespostaInfinitivo();
            analisarespostaPassadoSimples();
            analisarespostaParticipioPassado();
            analisarespostaTraducao();

            lbVariavelAcertos.Text = verboController.getlistaCorretos().Count.ToString();
            lbVariavelErros.Text = verboController.getlistaIncorretos().Count.ToString();

            btEnviar.Enabled = false;
            btLimpar.Enabled = false;
        }

        private void btInfinitivo_Click(object sender, EventArgs e)
        {
            lbVariavelInfinitivo.Text = verbo.getInfinitivo();
            btInfinitivo.Enabled = false;
        }

        private void btPassadoSimples_Click(object sender, EventArgs e)
        {
            lbVariavelPassadoSimples.Text = verbo.gepassadoSimples();
            btPassadoSimples.Enabled = false;
        }

        private void btParticipioPassado_Click(object sender, EventArgs e)
        {
            lbVariavelParticipioPassado.Text = verbo.getparticipioPassado();
            btParticipioPassado.Enabled = false;
        }

        private void btTraducao_Click(object sender, EventArgs e)
        {
            lbVariavelTraducao.Text = verbo.gettraducao();
            btTraducao.Enabled = false;
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            try
            {
                num++;
                lbExemplo.Visible = false;
                verbo = verboController.getListaVerbos()[num];
                lbVariavelVerboIrregular.Text = verbo.getNome();
                liberarTudo();
                lbVariavelPalavra.Text = verbo.getId().ToString();

                

                tbInfinitivo.Text= "";
                tbPassadoSimples.Text = "";
                tbParticipioPassado.Text = "";
                tbTraducao.Text = "";
                desativarCorretoIncorreto();
                tbInfinitivo.Focus();

                if (verbo.getId() == verboController.getListaVerbos().Count())
                {
                    btProximo.Enabled = false;
                }
            }catch(System.ArgumentOutOfRangeException){
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbInfinitivo.Text = "";
            tbPassadoSimples.Text = "";
            tbParticipioPassado.Text = "";
            tbTraducao.Text = "";
            tbInfinitivo.Focus();
        }
    }
}
