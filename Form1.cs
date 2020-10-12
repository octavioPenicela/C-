using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informacao_de_Motorista__Controle_covid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPais.Items.Add("Africa do sul");
            cboPais.Items.Add("Zimbabwe");
            cboPais.Items.Add("Tazania");
            cboPais.Items.Add("Swazilandia");
            cboPais.Items.Add("Zambia");
            txtValorTemp.Enabled = false;
            txtValorTemp.Text = "0.00";
        }

        private void chkMerdirTemp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMerdirTemp.Checked)
            {
                txtValorTemp.Enabled = true;
            }
            else 
            {
                txtValorTemp.Enabled = false;
                txtValorTemp.Text = "39.00";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNrPass.Text = "";
            txtValorTemp.Enabled = false;
            txtValorTemp.Text = "0.00";
            cboPais.SelectedIndex=-1;
            chkMerdirTemp.Checked = false;  
        }
        private void Registrar()
        {
            lstNome.Items.Add(txtNome.Text);
            lstPais.Items.Add(cboPais.SelectedItem.ToString());
            lstNrPass.Items.Add(txtNrPass.Text);
            lstTemperat.Items.Add(chkMerdirTemp.Checked?"sim":"Nao");
            lstValor.Items.Add(txtValorTemp.Text);
        }
        private bool CamposObrigatorios() 
        {
            return !string.IsNullOrEmpty(txtNome.Text) && cboPais.SelectedIndex != -1 
                && !string.IsNullOrEmpty(txtNrPass.Text);
        }
        private bool valorDaTemperatura() 
        {
            return chkMerdirTemp.Checked && double.Parse(txtValorTemp.Text) > 0;
        
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (CamposObrigatorios() && !chkMerdirTemp.Checked)
            {
                Registrar();
            }
            else if (CamposObrigatorios() && valorDaTemperatura())
            {
                Registrar();

            }
            else if (!CamposObrigatorios())
            {
                MessageBox.Show("Os campos devem ser preechidos!");

            }
            else 
            {
                MessageBox.Show("O valor da temperatura deve ser superior a zero");
            }
        }

        private void Detalhes_Enter(object sender, EventArgs e)
        {

        }

        private void chkTotalMediramTemp_CheckedChanged(object sender, EventArgs e)
        {
            int total = 0;
            if(chkTotalMediramTemp.Checked)
            {
                for (int i = 0; i < lstValor.Items.Count; i++)
                {
                    double valorTemp = double.Parse(lstValor.Items[i].ToString());
                }
            }
            
        }

        private void lstValor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNrPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void lstNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstNrPass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstTemperat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkTotalNaoMedTemp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMediaDaTemp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalMediramTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalNaoMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMediaDaTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMedirTemAcimaDe40_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
