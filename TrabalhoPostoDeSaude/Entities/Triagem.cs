using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    class Triagem
    {
        private Paciente paciente;
        private Enfermeiro enfermeiro;
        private string horario;
        private string sintomas;
        private string pressao;
        private float temperatura;
        private float peso;
        private int batimentoCardiaco;

        public Triagem(Paciente paciente, Enfermeiro enfermeiro, string horario, string sintomas, string pressao, float temperatura, float peso, int batimentoCardiaco)
        {
            this.paciente = paciente;
            this.enfermeiro = enfermeiro;
            this.horario = horario;
            this.sintomas = sintomas;
            this.pressao = pressao;
            this.temperatura = temperatura;
            this.peso = peso;
            this.batimentoCardiaco = batimentoCardiaco;

        }

        public void setHorario(string horario)
        {
            this.horario = horario;
        }
        public void setSintoma(string sintomas)
        {
            this.sintomas = sintomas;
        }
        public void setPressao(string pressao)
        {
            this.pressao = pressao;
        }
        public void setTemperatura(float temperatura)
        {
            this.temperatura = temperatura;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public void setBatimentoCardiaco(int batimentoCardiaco)
        {
            this.batimentoCardiaco = batimentoCardiaco;
        }
        public string getHorario()
        {
            return horario;
        }
        public string getSintomas()
        {
            return sintomas;
        }
        public string getPressao()
        {
            return pressao;
        }
        public float getTemperatura()
        {
            return temperatura;
        }
        public float getPeso()
        {
            return peso;
        }
        public int getBatimentoCardiaco()
        {
            return batimentoCardiaco;
        }


        public string gerarRelatorio()
        {
            return "Nome do paciente da triagem: " + this.paciente.nome + ", Nome do enfermeiro da triagem: " + this.enfermeiro.nome +
                ", Horario de fim da triagem: " + this.horario + ", Sintomas: " + this.sintomas + ", Pressão do paciente: " + this.pressao + ", Temperatura do paciente: " + this.temperatura +
                ", Peso do paciente: " + this.peso + ", Batimentos cardíacos do paciente:" + this.batimentoCardiaco;

        }

        }
}
