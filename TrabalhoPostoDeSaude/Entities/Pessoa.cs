using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Pessoa
    {
        public string nome;
        public DateTime dataNascimento;
        public string cpf;
        public string sexo;
        public Endereco endereco;
        public string telefone;

        public Pessoa(string nome, DateTime dataNascimento, string cpf, string sexo, Endereco endereco, string telefone)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.sexo = sexo;
            this.endereco = endereco;
            this.telefone = telefone;

        }

        public void atualizarDados(string nome, DateTime dataNascimento, string cpf, string sexo, Endereco endereco, string telefone)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.sexo = sexo;
            this.endereco = endereco;
            this.telefone = telefone;

        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }
        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;        
        
        }

        public string getNome()
        {
            return nome;
        }
        public DateTime getDataNascimento()
        {
            return dataNascimento;
        }
        public string getCPF()
        {
            return cpf;
        }
        public string getSexo()
        {
            return sexo;
        }
        public Endereco getEndereco()
        {
            return endereco;
        }
       
        public string getTelefone()
        {
            return telefone;
        }
    }
}
