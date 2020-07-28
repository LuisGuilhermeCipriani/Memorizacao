using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorizacao
{
    class Verbo
    {
		private int id;
		private String nome;
		private String infinitivo;
		private String passadoSimples;
		private String participioPassado;
		private String traducao;

		public Verbo() { }

        public Verbo(int id, String nome, String infinitivo, String passadoSimples, String participioPassado, String traducao)
        {
			this.id = id;
			this.nome = nome;
			this.infinitivo = infinitivo;
			this.passadoSimples = passadoSimples;
			this.participioPassado = participioPassado;
			this.traducao = traducao;
        }

		public int getId()
        {
			return id;
        }

		public void setId(int id)
        {
			this.id = id; 
        }

		public String getNome()
        {
			return nome;
        }

		public void setNome(String nome)
        {
			this.nome = nome;
        }

		public String getInfinitivo()
		{
			return infinitivo;
		}

		public void setInfinitivo(String infinitivo)
		{
			this.infinitivo = infinitivo;
		}

		public String gepassadoSimples()
		{
			return passadoSimples;
		}

		public void setpassadoSimples(String passadoSimples)
		{
			this.passadoSimples = passadoSimples;
		}

		public String getparticipioPassado()
		{
			return participioPassado;
		}

		public void setparticipioPassado(String participioPassado)
		{
			this.participioPassado = participioPassado;
		}

		public String gettraducao()
		{
			return traducao;
		}

		public void settraducao(String traducao)
		{
			this.traducao = traducao;
		}

	}
}
