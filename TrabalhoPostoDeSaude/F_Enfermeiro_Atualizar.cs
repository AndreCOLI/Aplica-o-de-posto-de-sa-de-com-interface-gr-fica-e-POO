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
    public partial class F_Enfermeiro_Atualizar : Form
    {
        Form_Enfermeiros FE;
        string cpf;


        public F_Enfermeiro_Atualizar(string cpf, Form_Enfermeiros FE)
        {
            InitializeComponent();
            this.FE = FE;
            this.cpf = cpf;
            FE.Hide();
        }

        private void btn_att_enf_confirmar_Click(object sender, EventArgs e)
        {
            if (tb1_nome.Text == "" || Mtb_nasc.Text == "" || Mtb_cpf.Text == "" || tb4_end.Text == "" || tb_bairro.Text == "" || tb_numero.Text == "" || tb_cidade.Text == "" || tb_UF.Text == "" || Mtb_telefone.Text == "" || cb_att_sexo.Text == "" || tb_salario.Text == "" || tb_formacao.Text == "" || Mtb_dataadmissao.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

                for (int i = 0; i < FE.listaDeEnfermeiros.Count; i++)
                {

                    if (cpf == FE.listaDeEnfermeiros[i].cpf)
                    {


                        FE.listaDeEnfermeiros[i].nome = tb1_nome.Text;
                        FE.listaDeEnfermeiros[i].setDataNascimento(DateTime.Parse(Mtb_nasc.Text));
                        FE.listaDeEnfermeiros[i].cpf = Mtb_cpf.Text;
                        FE.listaDeEnfermeiros[i].endereco.setLogradouro(tb4_end.Text);
                        FE.listaDeEnfermeiros[i].endereco.setBairro(tb_bairro.Text);
                        FE.listaDeEnfermeiros[i].endereco.setNumero(int.Parse(tb_numero.Text));
                        FE.listaDeEnfermeiros[i].endereco.setMunicipio(tb_cidade.Text);
                        FE.listaDeEnfermeiros[i].endereco.setEstado(tb_UF.Text);
                        FE.listaDeEnfermeiros[i].telefone = Mtb_telefone.Text;
                        FE.listaDeEnfermeiros[i].setSalario(double.Parse(tb_salario.Text));
                        FE.listaDeEnfermeiros[i].setFormacao(tb_formacao.Text);
                        FE.listaDeEnfermeiros[i].sexo = cb_att_sexo.Text;
                        FE.listaDeEnfermeiros[i].setDataAdmissao(DateTime.Parse(Mtb_dataadmissao.Text)); ;


                    }

                }




            MessageBox.Show("Dados atualizados com sucesso!", "Parabéns!");
        }

        private void btn_att_enf_limpar_Click(object sender, EventArgs e)
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
            tb_salario.Clear();
            tb_formacao.Clear();
            cb_att_sexo.ResetText();
            Mtb_dataadmissao.Clear();
            tb1_nome.Focus();


        }

        private void btn_att_enf_cancelar_Click(object sender, EventArgs e)
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

        private void F_Enfermeiro_Atualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FE.tb1.Clear();
            FE.Mtb_nascimento.Clear();
            FE.Mtb_cpf.Clear();
            FE.tb4.Clear();
            FE.Mtb_telefone.Clear();
            FE.tb6.Clear();
            FE.tb_salario.Clear();
            FE.Mtb_admissao.Clear();
            FE.tb1.Focus();

            FE.Show();

        }

        private void F_Enfermeiro_Atualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
