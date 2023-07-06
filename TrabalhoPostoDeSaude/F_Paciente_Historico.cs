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
    public partial class F_Paciente_Historico : Form
    {
        string cpf;
        string nome;
        Form_Pacientes FP;
        string[] consultasSplit;
        public F_Paciente_Historico(string nome, string cpf, Form_Pacientes FP)
        {
            InitializeComponent();
            this.FP = FP;
            this.cpf = cpf;
            this.nome = nome;
        }

        private void F_Paciente_Historico_Load(object sender, EventArgs e)
        {
            FP.Hide();



            for (int i = 0; i < FP.listaDePacientes.Count; i++)
            {
                if (cpf == FP.listaDePacientes[i].cpf)
                {
                    consultasSplit = FP.listaDePacientes[i].historico.imprimirHistorico().Split('.');
                  // textBox1.Text = FP.listaDePacientes[i].historico.imprimirHistorico() + "\n";
                    
                }
            }
            
                for (int i = 0; i < consultasSplit.Length; i++)
                {

                    listBox1.Items.Add(consultasSplit[i]);
                }
                  
        }

        private void F_Paciente_Historico_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
            FP.Show();
        }

        private void btn_inserir_registro_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < FP.listaDePacientes.Count; i++)
            {

                if (cpf == FP.listaDePacientes[i].cpf)
                {
                    try 
                    {
                        Consulta consulta_aux = new Consulta(int.Parse(tb1.Text), FP.listaDeMedicos[0], FP.listaDePacientes[i], DateTime.Parse(Mtb_data.Text), DateTime.Parse(Mtb_retorno.Text));
                        FP.listaDePacientes[i].historico.AdicionarConsulta(consulta_aux);
                        listBox1.Items.Add ( FP.listaDePacientes[i].historico.imprimirHistorico() + "\n");
                    }
                    catch
                    {
                        MessageBox.Show( "Confira os campos e tenta novamente!", "Erro!");
                    }
                    
                }

            }

        }

        private void btn_apagar_registro_Click(object sender, EventArgs e)
        {

        }
    }
}
