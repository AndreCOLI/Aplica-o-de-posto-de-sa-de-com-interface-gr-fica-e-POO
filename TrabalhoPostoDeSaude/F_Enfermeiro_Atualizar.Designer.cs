﻿
namespace TrabalhoPostoDeSaude
{
    partial class F_Enfermeiro_Atualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Enfermeiro_Atualizar));
            this.btn_att_enf_limpar = new System.Windows.Forms.Button();
            this.btn_att_enf_cancelar = new System.Windows.Forms.Button();
            this.btn_att_enf_confirmar = new System.Windows.Forms.Button();
            this.Mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_UF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.Mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.Mtb_nasc = new System.Windows.Forms.MaskedTextBox();
            this.cb_att_sexo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb4_end = new System.Windows.Forms.TextBox();
            this.tb1_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_formacao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.Mtb_dataadmissao = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_att_enf_limpar
            // 
            this.btn_att_enf_limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_att_enf_limpar.BackgroundImage")));
            this.btn_att_enf_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_att_enf_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_att_enf_limpar.FlatAppearance.BorderSize = 0;
            this.btn_att_enf_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_att_enf_limpar.Location = new System.Drawing.Point(685, 560);
            this.btn_att_enf_limpar.Name = "btn_att_enf_limpar";
            this.btn_att_enf_limpar.Size = new System.Drawing.Size(174, 62);
            this.btn_att_enf_limpar.TabIndex = 29;
            this.btn_att_enf_limpar.UseVisualStyleBackColor = true;
            this.btn_att_enf_limpar.Click += new System.EventHandler(this.btn_att_enf_limpar_Click);
            // 
            // btn_att_enf_cancelar
            // 
            this.btn_att_enf_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_att_enf_cancelar.BackgroundImage")));
            this.btn_att_enf_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_att_enf_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_att_enf_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_att_enf_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_att_enf_cancelar.Location = new System.Drawing.Point(419, 560);
            this.btn_att_enf_cancelar.Name = "btn_att_enf_cancelar";
            this.btn_att_enf_cancelar.Size = new System.Drawing.Size(174, 62);
            this.btn_att_enf_cancelar.TabIndex = 28;
            this.btn_att_enf_cancelar.UseVisualStyleBackColor = true;
            this.btn_att_enf_cancelar.Click += new System.EventHandler(this.btn_att_enf_cancelar_Click);
            // 
            // btn_att_enf_confirmar
            // 
            this.btn_att_enf_confirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_att_enf_confirmar.BackgroundImage")));
            this.btn_att_enf_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_att_enf_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_att_enf_confirmar.FlatAppearance.BorderSize = 0;
            this.btn_att_enf_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_att_enf_confirmar.Location = new System.Drawing.Point(151, 560);
            this.btn_att_enf_confirmar.Name = "btn_att_enf_confirmar";
            this.btn_att_enf_confirmar.Size = new System.Drawing.Size(174, 62);
            this.btn_att_enf_confirmar.TabIndex = 27;
            this.btn_att_enf_confirmar.UseVisualStyleBackColor = true;
            this.btn_att_enf_confirmar.Click += new System.EventHandler(this.btn_att_enf_confirmar_Click);
            // 
            // Mtb_telefone
            // 
            this.Mtb_telefone.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_telefone.Location = new System.Drawing.Point(291, 341);
            this.Mtb_telefone.Mask = "(00) 0 0000-0000";
            this.Mtb_telefone.Name = "Mtb_telefone";
            this.Mtb_telefone.Size = new System.Drawing.Size(519, 31);
            this.Mtb_telefone.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(712, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 25);
            this.label11.TabIndex = 106;
            this.label11.Text = "UF:";
            // 
            // tb_UF
            // 
            this.tb_UF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UF.Location = new System.Drawing.Point(758, 280);
            this.tb_UF.Name = "tb_UF";
            this.tb_UF.Size = new System.Drawing.Size(52, 31);
            this.tb_UF.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(613, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 25);
            this.label10.TabIndex = 104;
            this.label10.Text = "N:";
            // 
            // tb_numero
            // 
            this.tb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numero.Location = new System.Drawing.Point(648, 280);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(52, 31);
            this.tb_numero.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(569, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 102;
            this.label9.Text = "Cidade:";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(648, 225);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(162, 31);
            this.tb_cidade.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 100;
            this.label8.Text = "Bairro:";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(291, 280);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(272, 31);
            this.tb_bairro.TabIndex = 99;
            // 
            // Mtb_cpf
            // 
            this.Mtb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_cpf.Location = new System.Drawing.Point(493, 173);
            this.Mtb_cpf.Name = "Mtb_cpf";
            this.Mtb_cpf.Size = new System.Drawing.Size(317, 31);
            this.Mtb_cpf.TabIndex = 98;
            // 
            // Mtb_nasc
            // 
            this.Mtb_nasc.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_nasc.Location = new System.Drawing.Point(291, 173);
            this.Mtb_nasc.Mask = "00/00/0000";
            this.Mtb_nasc.Name = "Mtb_nasc";
            this.Mtb_nasc.Size = new System.Drawing.Size(146, 31);
            this.Mtb_nasc.TabIndex = 97;
            this.Mtb_nasc.ValidatingType = typeof(System.DateTime);
            // 
            // cb_att_sexo
            // 
            this.cb_att_sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_att_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_att_sexo.FormattingEnabled = true;
            this.cb_att_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_att_sexo.Location = new System.Drawing.Point(291, 393);
            this.cb_att_sexo.Name = "cb_att_sexo";
            this.cb_att_sexo.Size = new System.Drawing.Size(519, 32);
            this.cb_att_sexo.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 95;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 94;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 93;
            this.label5.Text = "Logradouro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Cpf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(195, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(398, 43);
            this.label12.TabIndex = 89;
            this.label12.Text = "Insira os novos dados para: ";
            // 
            // tb4_end
            // 
            this.tb4_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4_end.Location = new System.Drawing.Point(291, 225);
            this.tb4_end.Name = "tb4_end";
            this.tb4_end.Size = new System.Drawing.Size(272, 31);
            this.tb4_end.TabIndex = 88;
            // 
            // tb1_nome
            // 
            this.tb1_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1_nome.Location = new System.Drawing.Point(291, 119);
            this.tb1_nome.Name = "tb1_nome";
            this.tb1_nome.Size = new System.Drawing.Size(519, 31);
            this.tb1_nome.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 109;
            this.label1.Text = "Formação:";
            // 
            // tb_formacao
            // 
            this.tb_formacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_formacao.Location = new System.Drawing.Point(291, 448);
            this.tb_formacao.Name = "tb_formacao";
            this.tb_formacao.Size = new System.Drawing.Size(272, 31);
            this.tb_formacao.TabIndex = 108;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(569, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 111;
            this.label13.Text = "Salário:";
            // 
            // tb_salario
            // 
            this.tb_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salario.Location = new System.Drawing.Point(648, 448);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(162, 31);
            this.tb_salario.TabIndex = 110;
            // 
            // Mtb_dataadmissao
            // 
            this.Mtb_dataadmissao.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_dataadmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_dataadmissao.Location = new System.Drawing.Point(291, 495);
            this.Mtb_dataadmissao.Mask = "00/00/0000";
            this.Mtb_dataadmissao.Name = "Mtb_dataadmissao";
            this.Mtb_dataadmissao.Size = new System.Drawing.Size(519, 31);
            this.Mtb_dataadmissao.TabIndex = 112;
            this.Mtb_dataadmissao.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(125, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 25);
            this.label14.TabIndex = 113;
            this.label14.Text = "Data de admissão:";
            // 
            // F_Enfermeiro_Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Mtb_dataadmissao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_salario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_formacao);
            this.Controls.Add(this.Mtb_telefone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_UF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.Mtb_cpf);
            this.Controls.Add(this.Mtb_nasc);
            this.Controls.Add(this.cb_att_sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb4_end);
            this.Controls.Add(this.tb1_nome);
            this.Controls.Add(this.btn_att_enf_limpar);
            this.Controls.Add(this.btn_att_enf_cancelar);
            this.Controls.Add(this.btn_att_enf_confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Enfermeiro_Atualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar enfermeiro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Enfermeiro_Atualizar_FormClosed);
            this.Load += new System.EventHandler(this.F_Enfermeiro_Atualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_att_enf_limpar;
        private System.Windows.Forms.Button btn_att_enf_cancelar;
        private System.Windows.Forms.Button btn_att_enf_confirmar;
        private System.Windows.Forms.MaskedTextBox Mtb_telefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_UF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.MaskedTextBox Mtb_cpf;
        private System.Windows.Forms.MaskedTextBox Mtb_nasc;
        private System.Windows.Forms.ComboBox cb_att_sexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb4_end;
        private System.Windows.Forms.TextBox tb1_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_formacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.MaskedTextBox Mtb_dataadmissao;
        private System.Windows.Forms.Label label14;
    }
}