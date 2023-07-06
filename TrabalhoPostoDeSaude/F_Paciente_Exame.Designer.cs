
namespace TrabalhoPostoDeSaude
{
    partial class F_Paciente_Exame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Paciente_Exame));
            this.btn_pac_exames_inserir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Mtb_data = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cb_medico = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_pac_exames_inserir
            // 
            this.btn_pac_exames_inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pac_exames_inserir.BackgroundImage")));
            this.btn_pac_exames_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pac_exames_inserir.FlatAppearance.BorderSize = 0;
            this.btn_pac_exames_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pac_exames_inserir.Location = new System.Drawing.Point(858, 88);
            this.btn_pac_exames_inserir.Name = "btn_pac_exames_inserir";
            this.btn_pac_exames_inserir.Size = new System.Drawing.Size(138, 58);
            this.btn_pac_exames_inserir.TabIndex = 3;
            this.btn_pac_exames_inserir.UseVisualStyleBackColor = true;
            this.btn_pac_exames_inserir.Click += new System.EventHandler(this.btn_pac_exames_inserir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insira um novo exame:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data:";
            // 
            // Mtb_data
            // 
            this.Mtb_data.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_data.Location = new System.Drawing.Point(688, 169);
            this.Mtb_data.Mask = "00/00/0000";
            this.Mtb_data.Name = "Mtb_data";
            this.Mtb_data.Size = new System.Drawing.Size(164, 31);
            this.Mtb_data.TabIndex = 16;
            this.Mtb_data.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Médico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo:";
            // 
            // tb_tipo
            // 
            this.tb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tipo.Location = new System.Drawing.Point(135, 99);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(167, 31);
            this.tb_tipo.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(197, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 329);
            this.listBox1.TabIndex = 20;
            // 
            // cb_medico
            // 
            this.cb_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_medico.FormattingEnabled = true;
            this.cb_medico.Location = new System.Drawing.Point(690, 99);
            this.cb_medico.Name = "cb_medico";
            this.cb_medico.Size = new System.Drawing.Size(162, 33);
            this.cb_medico.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Observação:";
            // 
            // tb_obs
            // 
            this.tb_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(197, 169);
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(410, 31);
            this.tb_obs.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Status:";
            // 
            // tb_status
            // 
            this.tb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_status.Location = new System.Drawing.Point(393, 99);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(201, 31);
            this.tb_status.TabIndex = 28;
            // 
            // F_Paciente_Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.cb_medico);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mtb_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_pac_exames_inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Paciente_Exame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exames do paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Paciente_Exame_FormClosed);
            this.Load += new System.EventHandler(this.F_Paciente_Exame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_pac_exames_inserir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Mtb_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cb_medico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_status;
    }
}