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
using Memorizacao.view;

namespace Memorizacao.view
{
    public partial class FormListaVerbos : Form
    {
        VerboController VerboController;
        public FormListaVerbos()
        {
            InitializeComponent();
            VerboController = new VerboController();
            VerboController.preencheListaVerbos();
            configurarDataGridView();
        }

        private void configurarDataGridView()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Número");
            dt.Columns.Add("Verbo");
            dt.Columns.Add("Infinitivo");
            dt.Columns.Add("Passado Simples");
            dt.Columns.Add("Particípio Passado");
            dt.Columns.Add("Tradução");

            foreach (Verbo v in VerboController.getListaVerbos())
            {
                dt.Rows.Add(new object[] { v.getId(), v.getNome(), v.getInfinitivo(), v.gepassadoSimples(), v.getparticipioPassado(), v.gettraducao() });
            }

            dataGridView1.DataSource = dt;
        }
    }
}
