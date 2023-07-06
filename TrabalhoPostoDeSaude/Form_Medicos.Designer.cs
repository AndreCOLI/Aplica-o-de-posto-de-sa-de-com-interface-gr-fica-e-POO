
namespace TrabalhoPostoDeSaude
{
    partial class Form_Medicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Medicos));
            this.label6 = new System.Windows.Forms.Label();
            this.tb6_espec = new System.Windows.Forms.TextBox();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_medico_excluir = new System.Windows.Forms.Button();
            this.btn_medico_cadastro = new System.Windows.Forms.Button();
            this.btn_medico_atualizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb7_crm = new System.Windows.Forms.TextBox();
            this.Mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb4_end = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Mtb_admissao = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Especialidade:";
            // 
            // tb6_espec
            // 
            this.tb6_espec.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb6_espec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6_espec.Location = new System.Drawing.Point(195, 442);
            this.tb6_espec.Name = "tb6_espec";
            this.tb6_espec.ReadOnly = true;
            this.tb6_espec.Size = new System.Drawing.Size(308, 29);
            this.tb6_espec.TabIndex = 51;
            // 
            // CB1
            // 
            this.CB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB1.FormattingEnabled = true;
            this.CB1.Location = new System.Drawing.Point(122, 70);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(385, 31);
            this.CB1.TabIndex = 50;
            this.CB1.SelectedIndexChanged += new System.EventHandler(this.CB1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(615, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 198);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btn_medico_excluir
            // 
            this.btn_medico_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_medico_excluir.BackgroundImage")));
            this.btn_medico_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_medico_excluir.FlatAppearance.BorderSize = 0;
            this.btn_medico_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medico_excluir.Location = new System.Drawing.Point(605, 525);
            this.btn_medico_excluir.Name = "btn_medico_excluir";
            this.btn_medico_excluir.Size = new System.Drawing.Size(308, 64);
            this.btn_medico_excluir.TabIndex = 38;
            this.btn_medico_excluir.UseVisualStyleBackColor = true;
            this.btn_medico_excluir.Click += new System.EventHandler(this.btn_medico_excluir_Click);
            // 
            // btn_medico_cadastro
            // 
            this.btn_medico_cadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_medico_cadastro.BackgroundImage")));
            this.btn_medico_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_medico_cadastro.FlatAppearance.BorderSize = 0;
            this.btn_medico_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medico_cadastro.Location = new System.Drawing.Point(605, 399);
            this.btn_medico_cadastro.Name = "btn_medico_cadastro";
            this.btn_medico_cadastro.Size = new System.Drawing.Size(308, 64);
            this.btn_medico_cadastro.TabIndex = 37;
            this.btn_medico_cadastro.UseVisualStyleBackColor = true;
            this.btn_medico_cadastro.Click += new System.EventHandler(this.btn_medico_cadastro_Click);
            // 
            // btn_medico_atualizar
            // 
            this.btn_medico_atualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_medico_atualizar.BackgroundImage")));
            this.btn_medico_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_medico_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_medico_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medico_atualizar.Location = new System.Drawing.Point(605, 275);
            this.btn_medico_atualizar.Name = "btn_medico_atualizar";
            this.btn_medico_atualizar.Size = new System.Drawing.Size(308, 64);
            this.btn_medico_atualizar.TabIndex = 36;
            this.btn_medico_atualizar.UseVisualStyleBackColor = true;
            this.btn_medico_atualizar.Click += new System.EventHandler(this.btn_medico_atualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "CRM:";
            // 
            // tb7_crm
            // 
            this.tb7_crm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb7_crm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb7_crm.Location = new System.Drawing.Point(195, 490);
            this.tb7_crm.Name = "tb7_crm";
            this.tb7_crm.ReadOnly = true;
            this.tb7_crm.Size = new System.Drawing.Size(308, 29);
            this.tb7_crm.TabIndex = 53;
            // 
            // Mtb_cpf
            // 
            this.Mtb_cpf.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_cpf.Location = new System.Drawing.Point(195, 300);
            this.Mtb_cpf.Mask = "000.000.000-00";
            this.Mtb_cpf.Name = "Mtb_cpf";
            this.Mtb_cpf.ReadOnly = true;
            this.Mtb_cpf.Size = new System.Drawing.Size(308, 31);
            this.Mtb_cpf.TabIndex = 100;
            // 
            // Mtb_nascimento
            // 
            this.Mtb_nascimento.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_nascimento.Location = new System.Drawing.Point(195, 253);
            this.Mtb_nascimento.Mask = "00/00/0000";
            this.Mtb_nascimento.Name = "Mtb_nascimento";
            this.Mtb_nascimento.ReadOnly = true;
            this.Mtb_nascimento.Size = new System.Drawing.Size(308, 31);
            this.Mtb_nascimento.TabIndex = 99;
            this.Mtb_nascimento.ValidatingType = typeof(System.DateTime);
            // 
            // Mtb_telefone
            // 
            this.Mtb_telefone.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_telefone.Location = new System.Drawing.Point(195, 394);
            this.Mtb_telefone.Mask = "(00) 0 0000-0000";
            this.Mtb_telefone.Name = "Mtb_telefone";
            this.Mtb_telefone.ReadOnly = true;
            this.Mtb_telefone.Size = new System.Drawing.Size(308, 31);
            this.Mtb_telefone.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 97;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 95;
            this.label3.Text = "Cpf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nome:";
            // 
            // tb4_end
            // 
            this.tb4_end.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb4_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4_end.Location = new System.Drawing.Point(195, 346);
            this.tb4_end.Name = "tb4_end";
            this.tb4_end.ReadOnly = true;
            this.tb4_end.Size = new System.Drawing.Size(308, 29);
            this.tb4_end.TabIndex = 92;
            // 
            // tb1
            // 
            this.tb1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(195, 209);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(308, 29);
            this.tb1.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 583);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 104;
            this.label8.Text = "Data Admissão:";
            // 
            // Mtb_admissao
            // 
            this.Mtb_admissao.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_admissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_admissao.Location = new System.Drawing.Point(195, 580);
            this.Mtb_admissao.Mask = "00/00/0000";
            this.Mtb_admissao.Name = "Mtb_admissao";
            this.Mtb_admissao.ReadOnly = true;
            this.Mtb_admissao.Size = new System.Drawing.Size(308, 31);
            this.Mtb_admissao.TabIndex = 103;
            this.Mtb_admissao.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 102;
            this.label9.Text = "Salário:";
            // 
            // tb_salario
            // 
            this.tb_salario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salario.Location = new System.Drawing.Point(195, 536);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.ReadOnly = true;
            this.tb_salario.Size = new System.Drawing.Size(308, 29);
            this.tb_salario.TabIndex = 101;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.LightBlue;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Location = new System.Drawing.Point(522, 70);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(38, 35);
            this.refresh.TabIndex = 105;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form_Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Mtb_admissao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.Mtb_cpf);
            this.Controls.Add(this.Mtb_nascimento);
            this.Controls.Add(this.Mtb_telefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb4_end);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb7_crm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb6_espec);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_medico_excluir);
            this.Controls.Add(this.btn_medico_cadastro);
            this.Controls.Add(this.btn_medico_atualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Medicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Médicos";
            this.Load += new System.EventHandler(this.Form_Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb6_espec;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_medico_excluir;
        private System.Windows.Forms.Button btn_medico_cadastro;
        private System.Windows.Forms.Button btn_medico_atualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb7_crm;
        public System.Windows.Forms.MaskedTextBox Mtb_cpf;
        public System.Windows.Forms.MaskedTextBox Mtb_nascimento;
        public System.Windows.Forms.MaskedTextBox Mtb_telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb4_end;
        public System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox Mtb_admissao;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.Button refresh;
    }
}