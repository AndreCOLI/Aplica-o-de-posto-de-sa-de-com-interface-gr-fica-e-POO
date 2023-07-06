using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabalhoPostoDeSaude.Entities
{
    public class Enfermeiro : Pessoa
    {
        private string formacao;
        private double salario;
        private DateTime dataAdmissao;

        public Enfermeiro(string nome, DateTime dataNascimento, string cpf, string sexo, Endereco endereco, string telefone, string formacao, double salario, DateTime dataAdmissao) : base(nome, dataNascimento, cpf, sexo, endereco, telefone)
        {
            this.formacao = formacao;
            this.salario = salario;
            this.dataAdmissao = dataAdmissao;

        }
        
        public void setFormacao(string formacao)
        {
            this.formacao = formacao;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public void setDataAdmissao(DateTime dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }

        public string getFormacao()
        {
            return formacao;
        }
    
        public double getSalario()
        {
            return salario;
        }
        public DateTime getDataAdmissao()
        {
            return dataAdmissao;
        }



        public void atualizarDados(string nome, DateTime data, string cpf, string sexo, Endereco endereco, string telefone, string formacao, double salario, DateTime dataAdmissao)
        {
            this.nome = nome;
            this.dataAdmissao = data;
            this.cpf = cpf;
            this.sexo = sexo;
            this.endereco = endereco;
            this.telefone = telefone;
            this.formacao = formacao;
            this.salario = salario;
            this.dataAdmissao = dataAdmissao;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + "\nData de nascimento: " + this.dataNascimento.ToString() + "\nCpf: " + this.cpf + "\nSexo: " + this.sexo + "\nEndereco: " +
                this.endereco.ToString() + "\nTelefone: " + this.telefone + "\nFormação: " + this.formacao + "\nSalario: " + this.salario.ToString() + "\nData de admissão: " + this.dataAdmissao;
        }


        public void mostrarDados()
        {
            this.ToString();
        }
    }


}

