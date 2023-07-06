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
    public partial class F_Enfermeiro_Cadastro : Form
    {
        Form_Enfermeiros FE;
        public F_Enfermeiro_Cadastro(Form_Enfermeiros FE)
        {
            InitializeComponent();
            this.FE = FE;
        }

        private void btn_conf_cad_enf_Click(object sender, EventArgs e)
        {

            if (tb1_cadastro.Text == "" || Mtb_nasc.Text == "" || Mtb_cpf.Text == "" || cb_cadastro_sexo.Text == "" || Mtb_telefone.Text == "" || cb_formacao.Text == "" || tb_salario.Text == "" || Mtb_dataadmissao.Text == "" || tb4_logradouro.Text == "" || tb44_numero.Text == "" || tb43_bairro.Text == "" || cb_cidade.Text == "" || tb45_UF.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Endereco endereco_aux = new Endereco(tb4_logradouro.Text, int.Parse(tb44_numero.Text), tb43_bairro.Text, cb_cidade.Text, tb45_UF.Text);
                Enfermeiro enfermeiro_aux = new Enfermeiro(tb1_cadastro.Text, DateTime.Parse(Mtb_nasc.Text), Mtb_cpf.Text, cb_cadastro_sexo.Text, endereco_aux, Mtb_telefone.Text, cb_formacao.Text, double.Parse(tb_salario.Text), DateTime.Parse(Mtb_dataadmissao.Text));

                FE.listaDeEnfermeiros.Add(enfermeiro_aux);

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            string message = "Você deseja cancelar o cadastro?";
            string caption = "Atenção!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.Close();
                FE.Show();

            }
        }

        private void btn_clear_cad_enf_Click(object sender, EventArgs e)
        {
 

            tb1_cadastro.Clear();
            Mtb_nasc.Clear();
            Mtb_cpf.Clear();
            cb_cadastro_sexo.ResetText();
            Mtb_telefone.Clear();
            cb_formacao.ResetText();
            tb_salario.Clear();
            Mtb_dataadmissao.Clear();
            tb4_logradouro.Clear();
            tb44_numero.Clear();
            tb43_bairro.Clear();
            cb_cidade.ResetText();
            tb45_UF.Clear();
            tb1_cadastro.Focus();




        }
    }
}
