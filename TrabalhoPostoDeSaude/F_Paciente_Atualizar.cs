using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoPostoDeSaude
{
    public partial class F_Paciente_Atualizar : Form
    {
        Form_Pacientes FP;
        string cpf;



        public F_Paciente_Atualizar( string cpf, Form_Pacientes FP)
        {
            InitializeComponent();
            this.FP = FP;
      
            this.cpf = cpf;

            FP.Hide();
            

        }

        private void F_Paciente_Atualizar_Load(object sender, EventArgs e)
        {
          
            Nome_atualizar.Text = FP.CB1.Text;
           

        }

        private void F_Paciente_Atualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FP.CB1.ResetText();
            FP.tb1.Clear();
            FP.tb2.Clear();
            FP.tb3.Clear();
            FP.tb4.Clear();
            FP.tb5.Clear();

            FP.Show();
            

        }

        private void btn_att_confirmar_Click(object sender, EventArgs e)
        {
            if (tb1_nome.Text == "" || Mtb_nasc.Text == "" || Mtb_cpf.Text == "" || tb4_end.Text == "" || tb_numero.Text == "" || tb_bairro.Text == "" || tb_cidade.Text == "" || tb_UF.Text == "" || Mtb_telefone.Text == "" || cb_att_sexo.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                for (int i = 0; i < FP.listaDePacientes.Count; i++)
                {
                    
                    if (cpf == FP.listaDePacientes[i].cpf)
                    {
                     
                        FP.listaDePacientes[i].nome = tb1_nome.Text;
                        FP.listaDePacientes[i].dataNascimento = DateTime.Parse(Mtb_nasc.Text);
                        FP.listaDePacientes[i].cpf = Mtb_cpf.Text;
                        FP.listaDePacientes[i].endereco.setLogradouro(tb4_end.Text);
                        FP.listaDePacientes[i].endereco.setBairro(tb_bairro.Text);
                        FP.listaDePacientes[i].endereco.setNumero(int.Parse(tb_numero.Text));
                        FP.listaDePacientes[i].endereco.setMunicipio(tb_cidade.Text);
                        FP.listaDePacientes[i].endereco.setEstado(tb_UF.Text);
                        FP.listaDePacientes[i].telefone = Mtb_telefone.Text;
                        FP.listaDePacientes[i].sexo = cb_att_sexo.Text;
                    
                    }

                }

                MessageBox.Show("Dados atualizados com sucesso!", "Parabéns!");
            }

            }

        private void btn_att_pac_limpar_Click(object sender, EventArgs e)
        {
            tb1_nome.Clear();
            Mtb_nasc.Clear();
            Mtb_cpf.Clear();
            tb4_end.Clear();
            tb_bairro.Clear();
            tb_numero.Clear();
            tb_cidade.Clear();
            tb_UF.Clear();
            Mtb_telefone.Clear();
            cb_att_sexo.ResetText();
            tb1_nome.Focus();
          
        }

        private void btn_att_pac_cancelar_Click(object sender, EventArgs e)
        {
            string message = "Deseja cancelar a atualização dos dados?";
            string caption = "Atenção!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.Close();

            }
            else
                tb1_nome.Focus();
        }
    }
}
