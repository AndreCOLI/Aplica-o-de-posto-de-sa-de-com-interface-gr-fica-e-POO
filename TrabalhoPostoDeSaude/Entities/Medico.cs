using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Medico:Pessoa
    {
        private string crm;
        private string especialidade;
        private double salario;
        private DateTime dataAdmissao;
        private int localAtendimento;


        public Medico(string nome, DateTime dataNascimento, string cpf, string sexo, Endereco endereco, string telefone, string crm, string especialidade, double salario, DateTime dataAdmissao, int localAtendimento) : base(nome, dataNascimento, cpf, sexo, endereco, telefone)
        {
            this.crm = crm;
            this.especialidade = especialidade;
            this.salario = salario;
            this.dataAdmissao = dataAdmissao;
            this.localAtendimento = localAtendimento;
        }


        public override string ToString()
        {
            return "Nome: " + this.nome + "\nData de nascimento: " + this.dataNascimento.ToString() + "\nCpf: " + this.cpf + "\nSexo: " + this.sexo + "\nEndereco: " +
                this.endereco.ToString() + "\nTelefone: " + this.telefone + "\nEspecialidade: " + this.especialidade + "\nSalario: " + this.salario.ToString() + "\nData de admissão: " + this.dataAdmissao + "\nLocal de atendimento: " + this.localAtendimento + "\nCrm: " + this.crm;
        }


        public void mostrarDados()
        {
            this.ToString();
        }



        public void setCrm(string crm)
        {
            this.crm = crm;
        }

        public void setEspecialidade(string especialidade)
        {
            this.especialidade = especialidade;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public void setDataAdmissao(DateTime dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }

        public void setLocalAtendimento(int localAtendimento)
        {
            this.localAtendimento = localAtendimento;
        }


        public string getCrm()
        {
            return crm;
        }


        public string getEspecialidade()
        {
            return especialidade;
        }

        public double getSalario()
        {
            return salario;
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
