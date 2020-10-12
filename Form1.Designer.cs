namespace Informacao_de_Motorista__Controle_covid
{
    partial class Form1
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
            this.Detalhes = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMerdirTemp = new System.Windows.Forms.CheckBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.txtValorTemp = new System.Windows.Forms.TextBox();
            this.txtNrPass = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Accoes = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstValor = new System.Windows.Forms.ListBox();
            this.lstTemperat = new System.Windows.Forms.ListBox();
            this.lstNrPass = new System.Windows.Forms.ListBox();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMedirTemAcimaDe40 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMediaDaTemp = new System.Windows.Forms.TextBox();
            this.txtTotalNaoMed = new System.Windows.Forms.TextBox();
            this.txtTotalMediramTemp = new System.Windows.Forms.TextBox();
            this.chkMediaDaTemp = new System.Windows.Forms.CheckBox();
            this.chkTotalNaoMedTemp = new System.Windows.Forms.CheckBox();
            this.chkTotalMediramTemp = new System.Windows.Forms.CheckBox();
            this.Detalhes.SuspendLayout();
            this.Accoes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.label4);
            this.Detalhes.Controls.Add(this.label3);
            this.Detalhes.Controls.Add(this.label2);
            this.Detalhes.Controls.Add(this.label1);
            this.Detalhes.Controls.Add(this.chkMerdirTemp);
            this.Detalhes.Controls.Add(this.cboPais);
            this.Detalhes.Controls.Add(this.txtValorTemp);
            this.Detalhes.Controls.Add(this.txtNrPass);
            this.Detalhes.Controls.Add(this.txtNome);
            this.Detalhes.Location = new System.Drawing.Point(12, 1);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(409, 185);
            this.Detalhes.TabIndex = 0;
            this.Detalhes.TabStop = false;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.Enter += new System.EventHandler(this.Detalhes_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pais de Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor da Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero do  Passaport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Completo";
            // 
            // chkMerdirTemp
            // 
            this.chkMerdirTemp.AutoSize = true;
            this.chkMerdirTemp.Location = new System.Drawing.Point(214, 93);
            this.chkMerdirTemp.Name = "chkMerdirTemp";
            this.chkMerdirTemp.Size = new System.Drawing.Size(133, 17);
            this.chkMerdirTemp.TabIndex = 4;
            this.chkMerdirTemp.Text = "Mediu a Temperatura?";
            this.chkMerdirTemp.UseVisualStyleBackColor = true;
            this.chkMerdirTemp.CheckedChanged += new System.EventHandler(this.chkMerdirTemp_CheckedChanged);
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(214, 36);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(121, 21);
            this.cboPais.TabIndex = 3;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // txtValorTemp
            // 
            this.txtValorTemp.Location = new System.Drawing.Point(31, 154);
            this.txtValorTemp.Name = "txtValorTemp";
            this.txtValorTemp.Size = new System.Drawing.Size(48, 20);
            this.txtValorTemp.TabIndex = 2;
            this.txtValorTemp.TextChanged += new System.EventHandler(this.txtValorTemp_TextChanged);
            // 
            // txtNrPass
            // 
            this.txtNrPass.Location = new System.Drawing.Point(31, 93);
            this.txtNrPass.Name = "txtNrPass";
            this.txtNrPass.Size = new System.Drawing.Size(100, 20);
            this.txtNrPass.TabIndex = 1;
            this.txtNrPass.TextChanged += new System.EventHandler(this.txtNrPass_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // Accoes
            // 
            this.Accoes.Controls.Add(this.btnFechar);
            this.Accoes.Controls.Add(this.btnRegistrar);
            this.Accoes.Controls.Add(this.btnNovo);
            this.Accoes.Location = new System.Drawing.Point(427, 1);
            this.Accoes.Name = "Accoes";
            this.Accoes.Size = new System.Drawing.Size(200, 185);
            this.Accoes.TabIndex = 1;
            this.Accoes.TabStop = false;
            this.Accoes.Text = "Accoes";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(63, 143);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(63, 90);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(63, 32);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstValor);
            this.groupBox3.Controls.Add(this.lstTemperat);
            this.groupBox3.Controls.Add(this.lstNrPass);
            this.groupBox3.Controls.Add(this.lstPais);
            this.groupBox3.Controls.Add(this.lstNome);
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 171);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacoes Registradas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor da Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Medir Temperatura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nr Passaport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pais de origem";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome Completo";
            // 
            // lstValor
            // 
            this.lstValor.FormattingEnabled = true;
            this.lstValor.Location = new System.Drawing.Point(492, 36);
            this.lstValor.Name = "lstValor";
            this.lstValor.Size = new System.Drawing.Size(104, 121);
            this.lstValor.TabIndex = 4;
            this.lstValor.SelectedIndexChanged += new System.EventHandler(this.lstValor_SelectedIndexChanged);
            // 
            // lstTemperat
            // 
            this.lstTemperat.FormattingEnabled = true;
            this.lstTemperat.Location = new System.Drawing.Point(376, 36);
            this.lstTemperat.Name = "lstTemperat";
            this.lstTemperat.Size = new System.Drawing.Size(101, 121);
            this.lstTemperat.TabIndex = 3;
            this.lstTemperat.SelectedIndexChanged += new System.EventHandler(this.lstTemperat_SelectedIndexChanged);
            // 
            // lstNrPass
            // 
            this.lstNrPass.FormattingEnabled = true;
            this.lstNrPass.Location = new System.Drawing.Point(258, 36);
            this.lstNrPass.Name = "lstNrPass";
            this.lstNrPass.Size = new System.Drawing.Size(89, 121);
            this.lstNrPass.TabIndex = 2;
            this.lstNrPass.SelectedIndexChanged += new System.EventHandler(this.lstNrPass_SelectedIndexChanged);
            // 
            // lstPais
            // 
            this.lstPais.FormattingEnabled = true;
            this.lstPais.Location = new System.Drawing.Point(144, 36);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(92, 121);
            this.lstPais.TabIndex = 1;
            this.lstPais.SelectedIndexChanged += new System.EventHandler(this.lstPais_SelectedIndexChanged);
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.Location = new System.Drawing.Point(18, 36);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(113, 121);
            this.lstNome.TabIndex = 0;
            this.lstNome.SelectedIndexChanged += new System.EventHandler(this.lstNome_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMedirTemAcimaDe40);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtMediaDaTemp);
            this.groupBox1.Controls.Add(this.txtTotalNaoMed);
            this.groupBox1.Controls.Add(this.txtTotalMediramTemp);
            this.groupBox1.Controls.Add(this.chkMediaDaTemp);
            this.groupBox1.Controls.Add(this.chkTotalNaoMedTemp);
            this.groupBox1.Controls.Add(this.chkTotalMediramTemp);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estatistica";
            // 
            // txtMedirTemAcimaDe40
            // 
            this.txtMedirTemAcimaDe40.Location = new System.Drawing.Point(503, 88);
            this.txtMedirTemAcimaDe40.Name = "txtMedirTemAcimaDe40";
            this.txtMedirTemAcimaDe40.Size = new System.Drawing.Size(100, 20);
            this.txtMedirTemAcimaDe40.TabIndex = 7;
            this.txtMedirTemAcimaDe40.TextChanged += new System.EventHandler(this.txtMedirTemAcimaDe40_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(378, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Media  da temperatura dos que mediram a temperatura acima dos 40 graus";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMediaDaTemp
            // 
            this.txtMediaDaTemp.Location = new System.Drawing.Point(503, 62);
            this.txtMediaDaTemp.Name = "txtMediaDaTemp";
            this.txtMediaDaTemp.Size = new System.Drawing.Size(100, 20);
            this.txtMediaDaTemp.TabIndex = 5;
            this.txtMediaDaTemp.TextChanged += new System.EventHandler(this.txtMediaDaTemp_TextChanged);
            // 
            // txtTotalNaoMed
            // 
            this.txtTotalNaoMed.Location = new System.Drawing.Point(503, 39);
            this.txtTotalNaoMed.Name = "txtTotalNaoMed";
            this.txtTotalNaoMed.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNaoMed.TabIndex = 4;
            this.txtTotalNaoMed.TextChanged += new System.EventHandler(this.txtTotalNaoMed_TextChanged);
            // 
            // txtTotalMediramTemp
            // 
            this.txtTotalMediramTemp.Location = new System.Drawing.Point(503, 16);
            this.txtTotalMediramTemp.Name = "txtTotalMediramTemp";
            this.txtTotalMediramTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMediramTemp.TabIndex = 3;
            this.txtTotalMediramTemp.TextChanged += new System.EventHandler(this.txtTotalMediramTemp_TextChanged);
            // 
            // chkMediaDaTemp
            // 
            this.chkMediaDaTemp.AutoSize = true;
            this.chkMediaDaTemp.Location = new System.Drawing.Point(18, 65);
            this.chkMediaDaTemp.Name = "chkMediaDaTemp";
            this.chkMediaDaTemp.Size = new System.Drawing.Size(283, 17);
            this.chkMediaDaTemp.TabIndex = 2;
            this.chkMediaDaTemp.Text = "Media  da temperatura dos que mediram a temperatura";
            this.chkMediaDaTemp.UseVisualStyleBackColor = true;
            this.chkMediaDaTemp.CheckedChanged += new System.EventHandler(this.chkMediaDaTemp_CheckedChanged);
            // 
            // chkTotalNaoMedTemp
            // 
            this.chkTotalNaoMedTemp.AutoSize = true;
            this.chkTotalNaoMedTemp.Location = new System.Drawing.Point(18, 42);
            this.chkTotalNaoMedTemp.Name = "chkTotalNaoMedTemp";
            this.chkTotalNaoMedTemp.Size = new System.Drawing.Size(214, 17);
            this.chkTotalNaoMedTemp.TabIndex = 1;
            this.chkTotalNaoMedTemp.Text = "Total dos que nao medira a temperatura";
            this.chkTotalNaoMedTemp.UseVisualStyleBackColor = true;
            this.chkTotalNaoMedTemp.CheckedChanged += new System.EventHandler(this.chkTotalNaoMedTemp_CheckedChanged);
            // 
            // chkTotalMediramTemp
            // 
            this.chkTotalMediramTemp.AutoSize = true;
            this.chkTotalMediramTemp.Location = new System.Drawing.Point(18, 19);
            this.chkTotalMediramTemp.Name = "chkTotalMediramTemp";
            this.chkTotalMediramTemp.Size = new System.Drawing.Size(201, 17);
            this.chkTotalMediramTemp.TabIndex = 0;
            this.chkTotalMediramTemp.Text = "Total dos que mediram a temperatura";
            this.chkTotalMediramTemp.UseVisualStyleBackColor = true;
            this.chkTotalMediramTemp.CheckedChanged += new System.EventHandler(this.chkTotalMediramTemp_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Accoes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Detalhes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            this.Accoes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Detalhes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMerdirTemp;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.TextBox txtValorTemp;
        private System.Windows.Forms.TextBox txtNrPass;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox Accoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstValor;
        private System.Windows.Forms.ListBox lstTemperat;
        private System.Windows.Forms.ListBox lstNrPass;
        private System.Windows.Forms.ListBox lstPais;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMediaDaTemp;
        private System.Windows.Forms.TextBox txtTotalNaoMed;
        private System.Windows.Forms.TextBox txtTotalMediramTemp;
        private System.Windows.Forms.CheckBox chkMediaDaTemp;
        private System.Windows.Forms.CheckBox chkTotalNaoMedTemp;
        private System.Windows.Forms.CheckBox chkTotalMediramTemp;
        private System.Windows.Forms.TextBox txtMedirTemAcimaDe40;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

