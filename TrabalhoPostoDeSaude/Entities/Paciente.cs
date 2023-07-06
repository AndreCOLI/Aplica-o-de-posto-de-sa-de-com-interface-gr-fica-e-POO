using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Paciente:Pessoa
    {
        public HistoricoConsulta historico;

        public Paciente(string nome, DateTime dataNascimento, string cpf, string sexo, Endereco endereco, string telefone) : base(nome, dataNascimento, cpf, sexo, endereco, telefone)
        {

             historico = new HistoricoConsulta();
         
        }



        public void setHistorico(HistoricoConsulta historico)
        {
            this.historico = historico;        
        
        }
        
        public HistoricoConsulta getHistorico()
        {
            return historico;

        }


        public string mostrarDados()
        {

            return "Nome: " + this.nome + "\nData de nascimento: " + this.dataNascimento.ToString() + "\nCpf: " + this.cpf + "\nSexo: " + this.sexo + "\nEndereco: " +
                this.endereco.ToString() + "\nTelefone: " + this.telefone;
        }


    }



}


