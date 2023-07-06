using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrabalhoPostoDeSaude
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tb1_login.Focus();


            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
        
        }

      

        private void tb2_login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1_login.Text == "123" && tb2_login.Text == "123")
            {
                
                Form_Menu form_menu = new Form_Menu(this);
                this.Hide();
                form_menu.ShowDialog();
                
            }
                
            
        }

    }
    }

