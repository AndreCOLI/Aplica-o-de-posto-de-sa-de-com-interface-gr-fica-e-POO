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
    public partial class Form_Pacientes : Form
    {
        public List<Paciente> listaDePacientes;
        public List<Enfermeiro> listaDeEnfermeiros;
        public List<Medico> listaDeMedicos;
        public List<string> consultas;
        public List<string> triagens;
        public List<string> listaDeTriagens;
        public List<string> listaDeExames;
        public List<Medicamento> listaDeMedicamentos;
        public List<string> listaDeReceitas;
        Form1 form1;
        string cpf;
        string nome;
        string exames = "";


        public Form_Pacientes(List<string> listaDeReceitas, List<Medicamento> listaDeMedicamentos, List<string> listaDeExames, List<string> listaDeTriagens ,List<Paciente> listaDePacientes, List<Enfermeiro> listaDeEnfermeiros, List<Medico> listaDeMedicos, Form1 form1)
        {
            
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.att;
            this.form1 = form1;
            this.listaDePacientes = listaDePacientes;
            this.listaDeEnfermeiros = listaDeEnfermeiros;
            this.listaDeMedicos = listaDeMedicos;
            this.listaDeTriagens = listaDeTriagens;
            this.listaDeExames = listaDeExames;
            this.listaDeMedicamentos = listaDeMedicamentos;
            this.listaDeReceitas = listaDeReceitas;


            for (int i = 0; i < listaDePacientes.Count; i++)
            {
                CB1.Items.Add(listaDePacientes[i].getNome());
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Pacientes_cadastro f_Pacientes_Cadastro = new F_Pacientes_cadastro(this);
            f_Pacientes_Cadastro.ShowDialog();
        }

        private void cb_ListaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listaDePacientes.Count; i++)
            {
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = listaDePacientes[i].nome;
                    tb2.Text = listaDePacientes[i].getDataNascimento().ToString();
                    tb3.Text = listaDePacientes[i].cpf;
                    tb4.Text = listaDePacientes[i].endereco.ToString();
                    tb5.Text = listaDePacientes[i].telefone;
                    cpf = listaDePacientes[i].cpf;
                    nome = listaDePacientes[i].nome;
                }

            }
        }

        private void btn_pacientes_excluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaDePacientes.Count; i++)
            {
                if (CB1.Text == listaDePacientes[i].getNome())
                {
                    listaDePacientes.Remove(listaDePacientes[i]);
                    CB1.ResetText();
                    tb1.Clear();
                    tb2.Clear();
                    tb3.Clear();
                    tb4.Clear();
                    tb5.Clear();
                    tb1.Focus();
                    pictureBox1.Image = Properties.Resources.att;
                    CB1.Items.Remove(CB1.Text);
                }
            }
        }

        private void btn_paciente_atualiza_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Atualizar f_Paciente_Atualizar = new F_Paciente_Atualizar(cpf, this);
                f_Paciente_Atualizar.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum paciente selecionado!", "Atenção!");
        }

        private void btn_paciente_historico_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Historico f_Paciente_Historico = new F_Paciente_Historico(nome, cpf, this);
                f_Paciente_Historico.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum paciente selecionado!","Atenção!");
            
        }

        private void Form_Pacientes_Load(object sender, EventArgs e)
        {
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            CB1.Items.Clear();
            for (int i = 0; i < listaDePacientes.Count; i++)
            {
                CB1.Items.Add(listaDePacientes[i].getNome());
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = listaDePacientes[i].nome;
                    tb2.Text = listaDePacientes[i].getDataNascimento().ToString();
                    tb3.Text = listaDePacientes[i].cpf;
                    tb4.Text = listaDePacientes[i].endereco.ToString();
                    tb5.Text = listaDePacientes[i].telefone;
                    cpf = listaDePacientes[i].cpf;
                }

            }

            CB1.ResetText();


        }

        private void btn_paciente_exames_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Exame f_Paciente_Exame = new F_Paciente_Exame(listaDeExames ,exames, cpf, this);
            f_Paciente_Exame.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum paciente selecionado!", "Atenção!");
        }

        private void btn_paciente_triagens_Click(object sender, EventArgs e)
        {
            F_Paciente_Triagens f_Paciente_Triagens = new F_Paciente_Triagens(nome, cpf, this);
            f_Paciente_Triagens.ShowDialog();
        }

        private void btn_paciente_receitas_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Receitas f_Paciente_Receitas = new F_Paciente_Receitas(cpf, this);
            f_Paciente_Receitas.ShowDialog();
            }
            else
                MessageBox.Show("Nenhum paciente selecionado!", "Atenção!");
        }
    }
}
