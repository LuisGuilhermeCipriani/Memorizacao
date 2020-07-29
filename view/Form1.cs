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

        public FormVerbosIrregulares()
        {
            InitializeComponent();
            
            verboController = new VerboController();
            verboController.preencheListaVerbos();
            Verbo verbo = verboController.getListaVerbos()[num];

            lbVariavelVerboIrregular.Text = verbo.getNome();
            lbVariavelInfinitivo.Text = verbo.getInfinitivo();
            lbVariavelPassadoSimples.Text = verbo.gepassadoSimples();
            lbVariavelParticipioPassado.Text = verbo.getparticipioPassado();
            lbVariavelTraducao.Text = verbo.gettraducao();
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
    }
}
