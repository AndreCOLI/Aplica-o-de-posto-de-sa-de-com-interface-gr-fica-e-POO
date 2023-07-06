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
    public partial class F_Medico_Cadastro : Form
    {
        Form_Medicos FM;
        public F_Medico_Cadastro(Form_Medicos FM)
        {
            InitializeComponent();
            this.FM = FM;
        }

        private void btn_conf_cad_med_Click(object sender, EventArgs e)
        {

            if (tb1_nome.Text == "" || Mtb_nasc.Text == "" || Mtb_cpf.Text == "" || tb4_end.Text == "" || tb_bairro.Text == "" || tb_cidade.Text == "" || tb_numero.Text == "" || Mtb_telefone.Text == "" || cb_att_sexo.Text == "" || tb_crm.Text == "" || tb_salario.Text == "" || tb_sala.Text == "" || tb_espec.Text == "" || Mtb_dataadmissao.Text == "" || tb_UF.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                Endereco endereco_aux = new Endereco(tb4_end.Text, int.Parse(tb_numero.Text), tb_bairro.Text, tb_cidade.Text, tb_UF.Text);
                Medico medico_aux = new Medico(tb1_nome.Text, DateTime.Parse(Mtb_nasc.Text), Mtb_cpf.Text, cb_att_sexo.Text, endereco_aux, Mtb_telefone.Text, tb_crm.Text, tb_espec.Text, double.Parse(tb_salario.Text), DateTime.Parse(Mtb_dataadmissao.Text), int.Parse(tb_sala.Text));


                FM.listaDeMedicos.Add(medico_aux);

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }







        }

        private void btn_canc_cad_med_Click(object sender, EventArgs e)
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
                FM.Show();

            }
        }

        private void btn_clear_cad_med_Click(object sender, EventArgs e)
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
            Mtb_dataadmissao.Clear();
            tb_UF.Clear();
            tb1_nome.Focus();
        }
    }
}
