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
    public partial class F_Medico_Atualizar : Form
    {

        string cpf;
        Form_Medicos FM;

        public F_Medico_Atualizar(string cpf, Form_Medicos FM)
        {
            InitializeComponent();
            this.cpf = cpf;
            this.FM = FM;
        }

        private void btn_att_med_limpar_Click(object sender, EventArgs e)
        {
            tb1_nome.Clear();
            Mtb_nasc.Clear();
            Mtb_cpf.Clear();
            tb4_end.Clear();
            tb_bairro.Clear();
            tb_cidade.Clear();
            tb_numero.Clear();
            Mtb_telefone.Clear();
            cb_att_sexo.ResetText();
            tb_crm.Clear();
            tb_salario.Clear();
            tb_sala.Clear();
            tb_espec.Clear();
            tb_UF.Clear();
            Mtb_dataadmissao.Clear();
            tb1_nome.Focus();
        }

        private void btn_att_med_cancelar_Click(object sender, EventArgs e)
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

        private void btn_att_med_confirmar_Click(object sender, EventArgs e)
        {
            if (tb1_nome.Text == "" || Mtb_nasc.Text == "" || Mtb_cpf.Text == "" || tb4_end.Text == "" || tb_bairro.Text == "" || tb_cidade.Text == "" || tb_numero.Text == "" || Mtb_telefone.Text == "" || cb_att_sexo.Text == "" || tb_crm.Text == "" || tb_salario.Text == "" || tb_sala.Text == "" || tb_espec.Text == "" || Mtb_dataadmissao.Text == "" || tb_UF.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                for (int i = 0; i < FM.listaDeMedicos.Count; i++)
                {
                    if (cpf == FM.listaDeMedicos[i].cpf)
                    {
                        FM.listaDeMedicos[i].setNome(tb1_nome.Text);
                        FM.listaDeMedicos[i].setDataNascimento(DateTime.Parse(Mtb_nasc.Text));
                        FM.listaDeMedicos[i].setCPF(Mtb_cpf.Text);
                        FM.listaDeMedicos[i].setSexo(cb_att_sexo.Text);
                        FM.listaDeMedicos[i].endereco.setLogradouro(tb4_end.Text);
                        FM.listaDeMedicos[i].endereco.setBairro(tb_bairro.Text);
                        FM.listaDeMedicos[i].endereco.setNumero(int.Parse(tb_numero.Text));
                        FM.listaDeMedicos[i].endereco.setMunicipio(tb_cidade.Text);
                        FM.listaDeMedicos[i].endereco.setEstado(tb_UF.Text);
                        FM.listaDeMedicos[i].telefone = Mtb_telefone.Text;
                        FM.listaDeMedicos[i].setCrm(tb_crm.Text);
                        FM.listaDeMedicos[i].setEspecialidade(tb_espec.Text);
                        FM.listaDeMedicos[i].setSalario(double.Parse(tb_salario.Text));
                        FM.listaDeMedicos[i].setDataAdmissao(DateTime.Parse(Mtb_dataadmissao.Text));
                        FM.listaDeMedicos[i].setLocalAtendimento(int.Parse(tb_sala.Text));
                    }
                }

                MessageBox.Show("Dados atualizados com sucesso!", "Parabéns!");

            }


            
        }

        private void F_Medico_Atualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
