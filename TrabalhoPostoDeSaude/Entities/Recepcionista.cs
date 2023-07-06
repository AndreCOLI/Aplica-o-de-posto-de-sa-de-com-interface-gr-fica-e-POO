using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    class Recepcionista : Pessoa
    {
        private DateTime dataAdmissao;
        private int localAtendimento;
     


        public Recepcionista(string nome, DateTime dataNascimento, string cpf, string sexo, Endereco endereco, string telefone, DateTime dataAdmissao, int localAtendimento) : base(nome, dataNascimento, cpf, sexo, endereco, telefone)
        {
            this.dataAdmissao = dataAdmissao;
            this.localAtendimento = localAtendimento;


        }

        public string mostrarDados()
        {

            return "Nome: " + this.nome + "\nData de nascimento: " + this.dataNascimento.ToString() + "\nCpf: " + this.cpf + "\nSexo: " + this.sexo + "\nEndereco: " +
                this.endereco.ToString() + "\nTelefone: " + this.telefone + "\nData de admissão: " + this.dataAdmissao.ToString() + "\nLocal de atendimento: " + localAtendimento.ToString();


        }

        public void setDataAdmissao(DateTime dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }

        public void setLocalAtendimento(int localAtendimento)
        {
            this.localAtendimento = localAtendimento;
        }

        public DateTime getDataAdmissao()
        {
            return dataAdmissao;
        }

        public int getLocalAtendimento()
        {
            return localAtendimento;
        }




    }
}
