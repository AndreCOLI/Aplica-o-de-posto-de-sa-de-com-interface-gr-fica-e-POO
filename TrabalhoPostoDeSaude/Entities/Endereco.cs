using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Endereco
    {
        private string logradouro;
        private int numero;
        private string bairro;
        private string municipio;
        private string estado;
   
        public Endereco(string logradouro, int numero, string bairro, string municipio, string estado)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.municipio = municipio;
            this.estado = estado;


        }

        public override string ToString()
        {
            return logradouro + ", " + numero + ", " + bairro + ", " + municipio + ", " + estado;
        }


        public void alterarEndereco(string logradouro, int numero, string bairro, string municipio, string estado)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.municipio = municipio;
            this.estado = estado;
        }


        public void setLogradouro(string logradouro)
        {
            this.logradouro = logradouro;

        }

        public void setNumero(int numero)
        {
            this.numero = numero;

        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;

        }
        public void setMunicipio(string municipio)
        {
            this.municipio = municipio;

        }
        public void setEstado(string estado)
        {
            this.estado = estado;

        }


        public string getLogradouro()
        {
            return logradouro; 
        }

        public int getNumero()
        {
            return numero;
        }

        public string getBairro()
        {
            return bairro;
        }

        public string getMunicipio()
        {
            return municipio;
        }

        public string getEstado()
        {
            return estado;
        }









    }
}
