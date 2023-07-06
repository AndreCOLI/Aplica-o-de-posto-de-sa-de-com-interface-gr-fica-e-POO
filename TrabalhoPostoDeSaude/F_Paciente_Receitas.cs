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
    public partial class F_Paciente_Receitas : Form
    {
        Form_Pacientes FP;
        string cpf;
        public F_Paciente_Receitas(string cpf, Form_Pacientes FP)
        {
            InitializeComponent();
            this.cpf = cpf;
            this.FP = FP;
        }

        private void F_Paciente_Receitas_Load(object sender, EventArgs e)
        {
            for (int i=0; i < FP.listaDeReceitas.Count; i++) 
            {
                listBox1.Items.Add(FP.listaDeReceitas[i]);
            }
        }

        private void btn_pac_receita_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FP.listaDePacientes.Count; i++)
            {

                if (cpf == FP.listaDePacientes[i].cpf)
                {
                    Receita receita_aux = new Receita(FP.listaDeMedicamentos, tb_obs.Text, DateTime.Parse(Mtb_data.Text));
                    FP.listaDeReceitas.Add("Paciente: " + FP.listaDePacientes[i].nome + ", " + receita_aux.GerarReceita());
                    listBox1.Items.Add("Paciente: " + FP.listaDePacientes[i].nome + ", " + receita_aux.GerarReceita());
                }
            }
        }
    }
}
