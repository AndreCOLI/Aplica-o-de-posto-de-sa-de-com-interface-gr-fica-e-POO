
namespace TrabalhoPostoDeSaude
{
    partial class F_Paciente_Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Paciente_Historico));
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btn_inserir_registro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_medico = new System.Windows.Forms.TextBox();
            this.Mtb_data = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mtb_retorno = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira um novo registro de consulta:";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(94, 98);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(93, 31);
            this.tb1.TabIndex = 1;
            // 
            // btn_inserir_registro
            // 
            this.btn_inserir_registro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inserir_registro.BackgroundImage")));
            this.btn_inserir_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inserir_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inserir_registro.FlatAppearance.BorderSize = 0;
            this.btn_inserir_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir_registro.Location = new System.Drawing.Point(403, 545);
            this.btn_inserir_registro.Name = "btn_inserir_registro";
            this.btn_inserir_registro.Size = new System.Drawing.Size(138, 58);
            this.btn_inserir_registro.TabIndex = 3;
            this.btn_inserir_registro.UseVisualStyleBackColor = true;
            this.btn_inserir_registro.Click += new System.EventHandler(this.btn_inserir_registro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Médico:";
            // 
            // tb_medico
            // 
            this.tb_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_medico.Location = new System.Drawing.Point(308, 98);
            this.tb_medico.Name = "tb_medico";
            this.tb_medico.Size = new System.Drawing.Size(93, 31);
            this.tb_medico.TabIndex = 6;
            // 
            // Mtb_data
            // 
            this.Mtb_data.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_data.Location = new System.Drawing.Point(486, 98);
            this.Mtb_data.Mask = "00/00/0000";
            this.Mtb_data.Name = "Mtb_data";
            this.Mtb_data.Size = new System.Drawing.Size(164, 31);
            this.Mtb_data.TabIndex = 8;
            this.Mtb_data.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Retorno:";
            // 
            // Mtb_retorno
            // 
            this.Mtb_retorno.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_retorno.Location = new System.Drawing.Point(775, 98);
            this.Mtb_retorno.Mask = "00/00/0000";
            this.Mtb_retorno.Name = "Mtb_retorno";
            this.Mtb_retorno.Size = new System.Drawing.Size(164, 31);
            this.Mtb_retorno.TabIndex = 10;
            this.Mtb_retorno.ValidatingType = typeof(System.DateTime);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(193, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 303);
            this.listBox1.TabIndex = 12;
            // 
            // F_Paciente_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Mtb_retorno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mtb_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_medico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_inserir_registro);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Paciente_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico diagnósticos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Paciente_Historico_FormClosed);
            this.Load += new System.EventHandler(this.F_Paciente_Historico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btn_inserir_registro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_medico;
        private System.Windows.Forms.MaskedTextBox Mtb_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Mtb_retorno;
        private System.Windows.Forms.ListBox listBox1;
    }
}