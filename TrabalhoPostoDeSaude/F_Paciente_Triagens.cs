using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPostoDeSaude.Entities;

namespace TrabalhoPostoDeSaude
{
    public partial class F_Paciente_Triagens : Form
    {
        Form_Pacientes FP;
        string cpf;
        string nome;
        public F_Paciente_Triagens(string nome, string cpf, Form_Pacientes FP)
        {
            InitializeComponent();
            this.FP = FP;
            this.cpf = cpf;
            this.nome = nome;
        }

        private void F_Paciente_Triagens_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < FP.listaDeEnfermeiros.Count; i++)
            {
                cb1_enfermeiros.Items.Add(FP.listaDeEnfermeiros[i].nome);
            }

            for(int j = 0; j < FP.listaDeTriagens.Count; j++)
            {
                listBox1.Items.Add(FP.listaDeTriagens[j]);
            }


            }

        private void btn_pac_triagem_inserir_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < FP.listaDePacientes.Count; i++)
            {

                if ((cpf == FP.listaDePacientes[i].cpf)) 
                {
                    for (int j = 0; j < FP.listaDeEnfermeiros.Count; j++)
                    {
                        if (cb1_enfermeiros.Text == FP.listaDeEnfermeiros[j].nome) 
                        {
                            Triagem triagem_aux = new Triagem(FP.listaDePacientes[i], FP.listaDeEnfermeiros[j], Mtb_horario.Text, tb_sintomas.Text, tb_pressao.Text, float.Parse(tb_temp.Text), float.Parse(tb_peso.Text), int.Parse(tb_batimentos.Text));
                            listBox1.Items.Add(triagem_aux.gerarRelatorio());
                            FP.listaDeTriagens.Add(triagem_aux.gerarRelatorio());
                        }
                    }

                }
            }

        }
    }
}
