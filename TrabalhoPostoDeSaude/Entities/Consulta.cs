using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Consulta
    {
        public int id;
        private Medico medico;
        private Paciente paciente;
        private DateTime dataInicio;
        private DateTime dataRetorno;


        public Consulta(int id, Medico medico, Paciente paciente, DateTime dataInicio, DateTime dataRetorno)
        {
            this.medico = medico;
            this.paciente = paciente;
            this.dataInicio = dataInicio;
            this.dataRetorno = dataRetorno;
            this.id = id;
        }
        

        public string imprimirConsulta()
        {
            return "Médico: " + getMedico().nome + ", Paciente: " + getPaciente().nome + ", Data da consulta: " + dataInicio.ToString() + ", Data de retorno: " + dataRetorno.ToString() +"."; 
        }

        public void marcarRetorno(DateTime dataRetorno)
        {
            this.dataRetorno = dataRetorno;
        }

        public void setMedico(Medico medico)
        {
            this.medico = medico;       
        }

        public void setPaciente(Paciente paciente)
        {
            this.paciente = paciente;
        }

        public void setDataInicio(DateTime dataInicio)
        {
            this.dataInicio = dataInicio;

        }

        public Medico getMedico()
        {
            return medico;
        }

        public Paciente getPaciente()
        {
            return paciente;
        }

        public DateTime getDataInicio()
        {
            return dataInicio;
        }

        public DateTime getDataRetorno()
        {
            return dataRetorno;
        }
    }
}
