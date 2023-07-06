using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class HistoricoConsulta
    {
        private List<Consulta> consultas;

        public HistoricoConsulta()
        {
            consultas = new List<Consulta>();
        }

        public void AdicionarConsulta(Consulta consulta)
        {
            consultas.Add(consulta);
        }

        public string imprimirHistorico()
        {
            string nomes = "";
            List<string> nomeConsultas = new List<string>();
            for (int i = 0; i < consultas.Count; i++)
            {

                nomes += consultas[i].imprimirConsulta() + "\n";
            }

            return nomes; 


        }

        public void setConsultas(List<Consulta> consultas)
        {
            this.consultas = consultas;
        }

        public List<Consulta> getConsultas()
        {
            return consultas;        
        }

    }
}
