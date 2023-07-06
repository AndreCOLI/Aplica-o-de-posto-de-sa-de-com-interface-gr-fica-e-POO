using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Medicamento
    {
        private string nome;
        private string dosagem;
        private string instrucaoUso;
        private string restricoes;
        private string efeitosColaterais;

        public Medicamento(string nome, string dosagem, string instrucaoUso, string restricoes, string efeitosColaterais)
        {
            this.nome = nome;
            this.dosagem = dosagem;
            this.instrucaoUso = instrucaoUso;
            this.restricoes = restricoes;
            this.efeitosColaterais = efeitosColaterais;
        }

        public override string ToString()
        {
            return "Nome do medicamento: " + this.nome + ", Dosagem do medicamento: " + this.dosagem + ", Instruções de uso: " + this.instrucaoUso + ", Restrições do medicamento" +
                this.restricoes + ", Efeitos colaterais do medicamento: " + this.efeitosColaterais;
        }

        public void ExibirInformacoes()
        {
            this.ToString();
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setDosagem(string dosagem)
        {
            this.dosagem = dosagem;
        }

        public void setInstrucaoUso(string instrucaoUso)
        {
            this.instrucaoUso = instrucaoUso;
        }

        public void setRestricoes(string restricoes)
        {
            this.restricoes = restricoes;
        }

        public void setEfeitosColaterais(string efeitosColaterais)
        {
            this.efeitosColaterais = efeitosColaterais;
        }


        public string getNome()
        {
            return nome;
        }

        public string getDosagem()
        {
            return dosagem;
        }

        public string getInstrucaoUso()
        {
            return instrucaoUso;
        }

        public string getRestricoes()
        {
            return restricoes;
        }

        public string getEfeitosColaterais()
        {
            return efeitosColaterais;
        }
    }
}
