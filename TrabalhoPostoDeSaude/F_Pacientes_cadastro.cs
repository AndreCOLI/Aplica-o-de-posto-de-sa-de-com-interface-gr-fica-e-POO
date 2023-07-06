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
using MySql.Data.MySqlClient;

namespace TrabalhoPostoDeSaude
{
    public partial class F_Pacientes_cadastro : Form
    {
        Form_Pacientes f;
 


        public F_Pacientes_cadastro( Form_Pacientes fp)
        {
            InitializeComponent();
            f = fp;
           
        }
        
        private void btn_conf_cad_pac_Click(object sender, EventArgs e)
        {


            if (tb1_cadastro_pac.Text == "" || Mtb_nascimento.Text == "" || Mtb_cpf.Text == "" || tb4_cadastro_pac.Text == "" || tb_cidade.Text == "" || tb43_cadastro_pac.Text == "" || tb44_cadastro_pac.Text == "" || tb45_cadastro_pac.Text == "" || Mtb_telefone.Text == "" || cb_cadastro_sexo.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Endereco endereco_aux = new Endereco(tb4_cadastro_pac.Text, int.Parse(tb44_cadastro_pac.Text), tb43_cadastro_pac.Text, tb_cidade.Text, tb45_cadastro_pac.Text);
                Paciente paciente_aux = new Paciente(tb1_cadastro_pac.Text, DateTime.Parse(Mtb_nascimento.Text), Mtb_cpf.Text, cb_cadastro_sexo.Text, endereco_aux, Mtb_telefone.Text);


                f.listaDePacientes.Add(paciente_aux);

                 MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_cad_pac_Click(object sender, EventArgs e)
        {
            tb1_cadastro_pac.Clear();
            Mtb_nascimento.Clear();
            Mtb_cpf.Clear();
            tb4_cadastro_pac.Clear();
            tb_cidade.ResetText();
            tb43_cadastro_pac.Clear();
            tb44_cadastro_pac.Clear();
            tb45_cadastro_pac.Clear();
            Mtb_telefone.Clear();
            cb_cadastro_sexo.ResetText();
            tb_email.Clear();
            tb1_cadastro_pac.Focus();
            
        }

        private void btn_canc_cad_pac_Click(object sender, EventArgs e)
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
                f.Show();

            }
        }

        private void F_Pacientes_cadastro_Load(object sender, EventArgs e)
        {
            f.Hide();
        }

        private void F_Pacientes_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }
    }
    }

