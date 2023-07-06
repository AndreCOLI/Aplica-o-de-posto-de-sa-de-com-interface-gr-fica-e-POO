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
    public partial class Form_Enfermeiros : Form
    {

        public List<Paciente> listaDePacientes;
        public List<Enfermeiro> listaDeEnfermeiros;
        public List<Medico> listaDeMedicos;

        Form1 form1;
        string cpf;


        public Form_Enfermeiros(List<Paciente> listaDePacientes, List<Enfermeiro> listaDeEnfermeiros, List<Medico> listaDeMedicos, Form1 form1)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.att;
            this.form1 = form1;
            this.listaDePacientes = listaDePacientes;
            this.listaDeEnfermeiros = listaDeEnfermeiros;
            this.listaDeMedicos = listaDeMedicos;
        }

        private void Form_Enfermeiros_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < listaDeEnfermeiros.Count; i++)
            {
                CB1.Items.Add(listaDeEnfermeiros[i].getNome());
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = listaDeEnfermeiros[i].nome;
                    Mtb_nascimento.Text = listaDeEnfermeiros[i].getDataNascimento().ToString();
                    Mtb_cpf.Text = listaDeEnfermeiros[i].cpf;
                    tb4.Text = listaDeEnfermeiros[i].endereco.ToString();
                    Mtb_telefone.Text = listaDeEnfermeiros[i].telefone;
                    tb6.Text = listaDeEnfermeiros[i].getFormacao(); ;
                    tb_salario.Text = listaDeEnfermeiros[i].getSalario().ToString();
                    Mtb_admissao.Text = listaDeEnfermeiros[i].getDataAdmissao().ToString();
                    cpf = listaDeEnfermeiros[i].cpf;
                }

            }
        }

        private void btn_enf_atualizar_Click(object sender, EventArgs e)
        {
            F_Enfermeiro_Atualizar f_Enfermeiro_Atualizar = new F_Enfermeiro_Atualizar(cpf, this);
            f_Enfermeiro_Atualizar.ShowDialog();
        }

        private void btn_enf_cadastrar_Click(object sender, EventArgs e)
        {
            F_Enfermeiro_Cadastro f_Enfermeiro_Cadastro = new F_Enfermeiro_Cadastro(this);
            f_Enfermeiro_Cadastro.ShowDialog();
        }

        private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listaDeEnfermeiros.Count; i++)
            {
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = listaDeEnfermeiros[i].nome;
                    Mtb_nascimento.Text = listaDeEnfermeiros[i].getDataNascimento().ToString();
                    Mtb_cpf.Text = listaDeEnfermeiros[i].cpf;
                    tb4.Text = listaDeEnfermeiros[i].endereco.ToString();
                    Mtb_telefone.Text = listaDeEnfermeiros[i].telefone;
                    tb6.Text = listaDeEnfermeiros[i].getFormacao(); ;
                    tb_salario.Text = listaDeEnfermeiros[i].getSalario().ToString();
                    Mtb_admissao.Text = listaDeEnfermeiros[i].getDataAdmissao().ToString();
                    cpf = listaDeEnfermeiros[i].cpf;
                }

            }
        }

        private void btn_enf_excluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaDeEnfermeiros.Count; i++)
            {
                if (CB1.Text == listaDeEnfermeiros[i].nome)
                {
                    listaDeEnfermeiros.Remove(listaDeEnfermeiros[i]);
                    tb1.Clear();
                    Mtb_nascimento.Clear();
                    Mtb_cpf.Clear();
                    tb4.Clear();
                    Mtb_telefone.Clear();
                    tb6.Clear();
                    tb_salario.Clear();
                    Mtb_admissao.Clear();
                    CB1.ResetText();
                    tb1.Focus();
                    pictureBox1.Image = Properties.Resources.att;
                    CB1.Items.Remove(CB1.Text);
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            CB1.Items.Clear();
            for (int i = 0; i < listaDeEnfermeiros.Count; i++)
            {
                CB1.Items.Add(listaDeEnfermeiros[i].getNome()); 
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = listaDeEnfermeiros[i].nome;
                    Mtb_nascimento.Text = listaDeEnfermeiros[i].getDataNascimento().ToString();
                    Mtb_cpf.Text = listaDeEnfermeiros[i].cpf;
                    tb4.Text = listaDeEnfermeiros[i].endereco.ToString();
                    Mtb_telefone.Text = listaDeEnfermeiros[i].telefone;
                    tb6.Text = listaDeEnfermeiros[i].getFormacao(); ;
                    tb_salario.Text = listaDeEnfermeiros[i].getSalario().ToString();
                    Mtb_admissao.Text = listaDeEnfermeiros[i].getDataAdmissao().ToString();
                    cpf = listaDeEnfermeiros[i].cpf;
                }

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
