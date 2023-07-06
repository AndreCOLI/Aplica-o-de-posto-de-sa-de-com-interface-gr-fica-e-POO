
namespace TrabalhoPostoDeSaude
{
    partial class F_Paciente_Receitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Paciente_Receitas));
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Mtb_data = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_pac_receita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_obs
            // 
            this.tb_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_obs.Location = new System.Drawing.Point(196, 107);
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(377, 31);
            this.tb_obs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Observação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data:";
            // 
            // Mtb_data
            // 
            this.Mtb_data.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.Mtb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_data.Location = new System.Drawing.Point(648, 107);
            this.Mtb_data.Mask = "00/00/0000";
            this.Mtb_data.Name = "Mtb_data";
            this.Mtb_data.Size = new System.Drawing.Size(164, 31);
            this.Mtb_data.TabIndex = 18;
            this.Mtb_data.ValidatingType = typeof(System.DateTime);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(196, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(602, 404);
            this.listBox1.TabIndex = 20;
            // 
            // btn_pac_receita
            // 
            this.btn_pac_receita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pac_receita.BackgroundImage")));
            this.btn_pac_receita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pac_receita.FlatAppearance.BorderSize = 0;
            this.btn_pac_receita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pac_receita.Location = new System.Drawing.Point(832, 96);
            this.btn_pac_receita.Name = "btn_pac_receita";
            this.btn_pac_receita.Size = new System.Drawing.Size(138, 58);
            this.btn_pac_receita.TabIndex = 21;
            this.btn_pac_receita.UseVisualStyleBackColor = true;
            this.btn_pac_receita.Click += new System.EventHandler(this.btn_pac_receita_Click);
            // 
            // F_Paciente_Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_pac_receita);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mtb_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_obs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Paciente_Receitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas";
            this.Load += new System.EventHandler(this.F_Paciente_Receitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Mtb_data;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_pac_receita;
    }
}