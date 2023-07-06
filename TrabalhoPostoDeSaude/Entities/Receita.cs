using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Receita
    {
        private List<Medicamento> medicamentos;
        private string observacao;
        private DateTime data;

        public Receita(List<Medicamento> medicamentos, string observacao, DateTime data)
        {
            this.medicamentos = medicamentos;
            this.observacao = observacao;
            this.data = data;
        }

        public string GerarReceita()
        {
            string remedios = ""; 
            List<string> nomeMedicamento = new List<string>();
            for (int i = 0; i < medicamentos.Count; i++)
            {
                nomeMedicamento.Add(medicamentos[i].getNome());
                remedios += nomeMedicamento[i] + ", ";
            }

            return "Medicamentos: " + remedios + "Observação importante: " + this.observacao + ", Data da receita: " + this.data.ToString();
            
            
        }

        public void adicionarMedicamento(Medicamento medicamento)
        {
            this.medicamentos.Add(medicamento);
        
        }

        public void setMedicamentos(List<Medicamento> medicamentos) {

            this.medicamentos = medicamentos;
        }

        public void setObservacao(string observacao)
        {

            this.observacao = observacao;
        }
        public void setData(DateTime data)
        {

            this.data = data;
        }

        public List<Medicamento> getMedicamentos()
        {
            return medicamentos;
        }

        public string getObservacao()
        {
            return observacao;
        }

        public DateTime getData()
        {
            return data;
        }

    }
}

