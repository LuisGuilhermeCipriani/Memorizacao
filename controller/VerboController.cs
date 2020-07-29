using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorizacao.controller
{
    class VerboController
    {
        private Verbo verbo;
        private List<Verbo> listaVerbos;
        private List<Verbo> listaCorretos;
        private List<Verbo> listaIncorretos;

        public VerboController()
        {
            verbo = new Verbo();
            listaVerbos = new List<Verbo>();
            listaCorretos = new List<Verbo>();
            listaIncorretos = new List<Verbo>();
        }

        public Verbo getVerbo()
        {
            return verbo;
        }

        public List<Verbo> getListaVerbos()
        {
            return listaVerbos;
        }

        public List<Verbo> getlistaCorretos()
        {
            return listaCorretos;
        }

        public List<Verbo> getlistaIncorretos()
        {
            return listaIncorretos;
        }

        public void preencheListaVerbos()
        {
            Verbo verbo1 = new Verbo(1, "Arise", "To arise", "Arose", "Arisen", "Erguer, levantar");
            listaVerbos.Add(verbo1);

            Verbo verbo2 = new Verbo(1, "Awake", "To awake", "Awoke", "Awoken", "Acordar, despertar");
            listaVerbos.Add(verbo2);
        }

    }
}
