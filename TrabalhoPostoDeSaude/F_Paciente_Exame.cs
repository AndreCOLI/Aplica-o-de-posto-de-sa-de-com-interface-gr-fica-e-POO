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
    public partial class F_Paciente_Exame : Form
    {
        Form_Pacientes FP;
        string cpf;
        string[] consultasSplit ;
        string exames;
        List<string> listaDeExames;


        public F_Paciente_Exame(List<string> listaDeExames , string exames, string cpf, Form_Pacientes FP)
        {
            InitializeComponent();
            this.FP = FP;
            this.cpf = cpf;
            this.exames = exames;
            this.listaDeExames = listaDeExames;
        }

        private void F_Paciente_Exame_Load(object sender, EventArgs e)
        {
            FP.Hide();

            

            for (int i = 0; i < FP.listaDePacientes.Count; i++)
            {
                if (cpf == FP.listaDePacientes[i].cpf)
                {
                    consultasSplit = exames.Split('.');

                }
            }

            for (int i = 0; i < consultasSplit.Length; i++)
            {

                listBox1.Items.Add(consultasSplit[i]);


            }

            for (int i = 0; i < FP.listaDeMedicos.Count; i++)
            {
                cb_medico.Items.Add(FP.listaDeMedicos[i].nome);

            }

            for (int i=0; i < listaDeExames.Count; i++) 
            {
                listBox1.Items.Add(listaDeExames[i]);
            }

        }

        private void F_Paciente_Exame_FormClosed(object sender, FormClosedEventArgs e)
        {
            FP.Show();
        }

        private void btn_pac_exames_inserir_Click(object sender, EventArgs e)
        {

            if (tb_tipo.Text == "" )
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {


                for (int i = 0; i < FP.listaDePacientes.Count; i++)
                {

                    if (cpf == FP.listaDePacientes[i].cpf)
                    {
                        try
                        {
                          
                                    Exame exame_aux = new Exame(tb_tipo.Text, DateTime.Parse(Mtb_data.Text), FP.listaDeMedicos[0], FP.listaDePacientes[i], tb_status.Text, tb_obs.Text);
                                    listBox1.Items.Add(exame_aux.ToString() + '.');
                                    listaDeExames.Add(exame_aux.ToString() + '.');
                                    exames += exame_aux.ToString() + '.'; 
                              
                        }
                        catch
                        {
                            MessageBox.Show("Confira os campos e tenta novamente!", "Erro!");
                        }

                    }

                }

                MessageBox.Show("Exame inserido com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
    }
}
