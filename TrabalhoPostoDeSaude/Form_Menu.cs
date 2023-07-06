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
    public partial class Form_Menu : Form
    {
        public List<Paciente> listaDePacientes = new List<Paciente>();
        public List<Medico> listaDeMedicos = new List<Medico>();
        public List<Enfermeiro> listaDeEnfermeiros = new List<Enfermeiro>();
        public List<string> listaDeTriagens = new List<string>();
        public List<string> listaDeExames = new List<string>();
        public List<Medicamento> listaDeMedicamentos = new List<Medicamento>();
        public List<string> listaDeReceitas = new List<string>();


        Form1 form1;
        public Form_Menu(Form1 form1)
        {
            this.form1 = form1;
   
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Endereco endereco_ = new Endereco("Avenida brasil", 10, "Alto antena", "Arcos", "Minas Gerais");
            Medico medico_ = new Medico("Joaquin", DateTime.Parse("10/10/2000"), "123.123.123-32", "Masculino", endereco_, "(37) 99999-9999", "1234", "Cirurgião geral", 10000.0, DateTime.Parse("11/11/2000"), 10);
            Paciente paciente_ = new Paciente("André", DateTime.Parse("10/10/2000"), "123.123.123-32", "Masculino", endereco_, "(37) 99999-9999");
            Enfermeiro enfermeiro_ = new Enfermeiro("Julia", DateTime.Parse("11/11/2020"), "123.123.123-32", "Feminino", endereco_, "(37) 11111-2222", "Chefe", 4000, DateTime.Parse("11/11/2022"));
            Medicamento medicamento1 = new Medicamento("Ritalina", "1mg", "Ingestão oral", "Não beber alcool", "Febre e dor na garganta");
            Medicamento medicamento2 = new Medicamento("Rivotril", "2mg", "Ingestão oral", "Não beber alcool", "Sonolência, tontura, boca seca");
            listaDeMedicamentos.Add(medicamento1);
            listaDeMedicamentos.Add(medicamento2);
            listaDeMedicos.Add(medico_);
            listaDePacientes.Add(paciente_);
            listaDeEnfermeiros.Add(enfermeiro_);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            string message = "Você deseja finalizar a sessão?";
            string caption = "Atenção!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                form1.Close();
                
            }
        }

        private void bt_Pacientes_Form_Click(object sender, EventArgs e)
        {
            Form_Pacientes form_Pacientes = new Form_Pacientes(listaDeReceitas, listaDeMedicamentos, listaDeExames, listaDeTriagens, listaDePacientes, listaDeEnfermeiros, listaDeMedicos, form1);
            form_Pacientes.ShowDialog();
        }

        private void bt_Enfer_Form_Click(object sender, EventArgs e)
        {
            Form_Enfermeiros form_Enfermeiros = new Form_Enfermeiros(listaDePacientes, listaDeEnfermeiros, listaDeMedicos, form1);
            form_Enfermeiros.ShowDialog();
        }

        private void bt_Medicos_Form_Click(object sender, EventArgs e)
        {
            Form_Medicos form_Medicos = new Form_Medicos(listaDePacientes, listaDeEnfermeiros, listaDeMedicos, form1);
            form_Medicos.ShowDialog();
        }

        private void bt_Ajuda_Form_Click(object sender, EventArgs e)
        {
            F_Ajuda f_Ajuda = new F_Ajuda();
            f_Ajuda.ShowDialog();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    
                }
                else
                    form1.Close();
            }
        }
    }

    
}
