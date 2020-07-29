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


    }
}
