using System;
using System.Collections.Generic;
using System.Globalization;
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

            Verbo verbo2 = new Verbo(2, "Awake", "To awake", "Awoke", "Awoken", "Acordar, despertar");
            listaVerbos.Add(verbo2);
        }

        public Boolean verificaInfinitivo(String infinitivo, Verbo palavra)
        {
            if (infinitivo.Equals(removeAcentos(palavra.getInfinitivo().ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verificaPassadoSimples(String passadoSimples, Verbo palavra)
        {
            if (passadoSimples.Equals(removeAcentos(palavra.gepassadoSimples().ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verificaParticipioPassado(String participioPassado, Verbo palavra)
        {
            if (participioPassado.Equals(removeAcentos(palavra.getparticipioPassado().ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verificaTraducao(String traducao, Verbo palavra)
        {
            if (traducao.Equals(removeAcentos(palavra.gettraducao().ToLower())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string removeAcentos(string texto)
        {
            StringBuilder textoRetorno = new StringBuilder();
            var arrayTexto = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letra in arrayTexto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                    textoRetorno.Append(letra);
            }
            return textoRetorno.ToString();
        }
    }
}
