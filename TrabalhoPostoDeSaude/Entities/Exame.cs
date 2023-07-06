using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    class Exame
    {
        private string tipo;
        private DateTime data;
        private Medico medico;
        private Paciente paciente;
        private string status;
        private string observacao;

        public Exame(string tipo, DateTime data, Medico medico, Paciente paciente, string status, string observacao)
        {
            this.tipo = tipo;
            this.data = data;
            this.medico = medico;
            this.paciente = paciente;
            this.status = status;
            this.observacao = observacao;
        }

        public override string ToString()
        {
            return "Tipo: " + this.tipo + ", Data de entrega: " + this.data.ToString() + 
                ", Médico que solicitou: " + this.medico.ToString() + ", Exame pertence: " + this.paciente.ToString() + ", Status do exame: " + this.status + ", Observação sobre o exame: " + this.observacao;
        }

        public void imprimirExame()
        {
            this.ToString();
        }
        public void atualizarObservacoes(string mensagem) 
        {
            this.observacao += mensagem;
        }
        public string agendarRetorno(string data) 
        {
            return "O retorno para entrega do exame está marcado para: " + data;
        }
        public void atualizarstatus(string status)
        {
            this.status = status;
        }

        public void atualizarData(DateTime data)
        {
            this.data = data;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void setMedico(Medico medico)
        {
            this.medico = medico;
        }
        public void setPaciente(Paciente paciente)
        {
            this.paciente = paciente;
        }

        public void setObservacao(string observacao)
        {
            this.observacao = observacao;
        }
        public string getTipo()
        {
            return this.tipo;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public Medico getMedico()
        {
            return this.medico;
        }

        public Paciente getPaciente()
        {
            return this.paciente;
        }

        public string getStatus()
        {
            return this.status;
        }

        public string getObservacao()
        {
            return this.observacao;
        }

    }

    


}
