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

            lbVariavelAcertos.Text = "0";
            lbVariavelErros.Text = "0";

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

            lbVariavelAcertos.Text = "0";
            lbVariavelErros.Text = "0";

            lbVariavelPalavra.Text = "1";
            lbVariavelTotal.Text = verboController.getListaVerbos().Count.ToString();
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

        }

        private void btInfinitivo_Click(object sender, EventArgs e)
        {
            lbVariavelInfinitivo.Text = verbo.getInfinitivo();
        }

        private void btPassadoSimples_Click(object sender, EventArgs e)
        {
            lbVariavelPassadoSimples.Text = verbo.gepassadoSimples();
        }

        private void btParticipioPassado_Click(object sender, EventArgs e)
        {
            lbVariavelParticipioPassado.Text = verbo.getparticipioPassado();
        }

        private void btTraducao_Click(object sender, EventArgs e)
        {
            lbVariavelTraducao.Text = verbo.gettraducao();
        }
    }
}
