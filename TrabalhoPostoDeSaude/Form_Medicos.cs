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
using TrabalhoPostoDeSaude.Entities;

namespace TrabalhoPostoDeSaude
{
    public partial class Form_Medicos : Form
    {

        public List<Paciente> listaDePacientes;
        public List<Enfermeiro> listaDeEnfermeiros;
        public List<Medico> listaDeMedicos;
        Form1 form1;
        string cpf;


        public Form_Medicos(List<Paciente> listaDePacientes, List<Enfermeiro> listaDeEnfermeiros, List<Medico> listaDeMedicos, Form1 form1)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.att;

            this.form1 = form1;
            this.listaDePacientes = listaDePacientes;
            this.listaDeEnfermeiros = listaDeEnfermeiros;
            this.listaDeMedicos = listaDeMedicos;
        }

        private void Form_Medicos_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listaDeMedicos.Count; i++)
            {
                CB1.Items.Add(listaDeMedicos[i].getNome());
                if (CB1.Text == listaDeMedicos[i].nome)
                {
                    tb1.Text = listaDeMedicos[i].nome;
                    Mtb_nascimento.Text = listaDeMedicos[i].getDataNascimento().ToString();
                    Mtb_cpf.Text = listaDeMedicos[i].cpf;
                    tb4_end.Text = listaDeMedicos[i].endereco.ToString();
                    Mtb_telefone.Text = listaDeMedicos[i].telefone;
                    tb6_espec.Text = listaDeMedicos[i].getEspecialidade();
                    tb7_crm.Text = listaDeMedicos[i].getCrm();
                    tb_salario.Text = listaDeMedicos[i].getSalario().ToString();
                    Mtb_admissao.Text = listaDeMedicos[i].getDataAdmissao().ToString();
                    cpf = listaDeMedicos[i].cpf;
                }

            }
        }

        private void btn_medico_atualizar_Click(object sender, EventArgs e)
        {
            F_Medico_Atualizar f_Medico_Atualizar = new F_Medico_Atualizar(cpf, this);
            f_Medico_Atualizar.ShowDialog();
        }

        private void btn_medico_cadastro_Click(object sender, EventArgs e)
        {
            F_Medico_Cadastro f_Medico_Cadastro = new F_Medico_Cadastro(this);
            f_Medico_Cadastro.ShowDialog();
        }

        private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listaDeMedicos.Count; i++)
            {
                if (CB1.Text == listaDeMedicos[i].nome)
                {
                    tb1.Text = listaDeMedicos[i].nome;
                    Mtb_nascimento.Text = listaDeMedicos[i].getDataNascimento().ToString();
                    Mtb_cpf.Text = listaDeMedicos[i].cpf;
                    tb4_end.Text = listaDeMedicos[i].endereco.ToString();
                    Mtb_telefone.Text = listaDeMedicos[i].telefone;
                    tb6_espec.Text = listaDeMedicos[i].getEspecialidade();
                    tb7_crm.Text = listaDeMedicos[i].getCrm();
                    tb_salario.Text = listaDeMedicos[i].getSalario().ToString();
                    Mtb_admissao.Text = listaDeMedicos[i].getDataAdmissao().ToString();
                    cpf = listaDeMedicos[i].cpf;
                }

            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            CB1.Items.Clear();
            for (int i = 0; i < listaDeMedicos.Count; i++)
            {
                CB1.Items.Add(listaDeMedicos[i].getNome());
                if (CB1.Text == listaDeMedicos[i].nome)
                {
                    tb1.Text = listaDeMedicos[i].nome;
                    Mtb_nascimento.Text = listaDeMedicos[i].getDataNascimento().ToString();
                    Mtb_cpf.Text = listaDeMedicos[i].cpf;
                    tb4_end.Text = listaDeMedicos[i].endereco.ToString();
                    Mtb_telefone.Text = listaDeMedicos[i].telefone;
                    tb6_espec.Text = listaDeMedicos[i].getEspecialidade();
                    tb7_crm.Text = listaDeMedicos[i].getCrm();
                    tb_salario.Text = listaDeMedicos[i].getSalario().ToString();
                    Mtb_admissao.Text = listaDeMedicos[i].getDataAdmissao().ToString();
                    cpf = listaDeMedicos[i].cpf;
                }

            }

        }

        private void btn_medico_excluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaDeMedicos.Count; i++)
            {
                if (CB1.Text == listaDeMedicos[i].getNome())
                {
                    CB1.Items.Remove(CB1.Text);
                    listaDeMedicos.Remove(listaDeMedicos[i]);
                    CB1.ResetText();
                    tb1.Clear();
                    Mtb_nascimento.Clear();
                    Mtb_cpf.Clear();
                    tb4_end.Clear();
                    Mtb_telefone.Clear();
                    tb6_espec.Clear();
                    tb7_crm.Clear();
                    tb_salario.Clear();
                    Mtb_admissao.Clear();
                    tb1.Focus();
                    pictureBox1.Image = Properties.Resources.att;
                    
                }
            }
        }
    }
}
