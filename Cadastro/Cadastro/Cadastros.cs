using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cadastro
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnValidarfisico_Click(object sender, EventArgs e)
        {
            lblCPFObg.Visible = false;
            lblDataNascimento.Visible = false;
            lblName.Visible = false;
            lblSobrenome.Visible = false;
            lblCEP.Visible = false;
            lblLogradouro.Visible = false;
            lblNumero.Visible = false;
            lblBairro.Visible = false;
            lblCidade.Visible = false;
            lblUF.Visible = false;

            bool validador = true;
            if (!maskCPF.MaskCompleted)
            {
                validador = false;
                lblCPFObg.Visible = true;
                lblCPFObg.Text = "Campo CPF Obrigatório";

            }
            else if (!mskDateNascimento.MaskCompleted)
            {
                validador = false;
                lblDataNascimento.Visible = true;
                lblDataNascimento.Text = "Campo Data Nascimento Obrigatório";
            }
            else if (Convert.ToDateTime(mskDateNascimento.Text).AddYears(19) > DateTime.Now)
            {
                validador = false;
                lblDataNascimento.Visible = true;
                lblDataNascimento.Text = $"Usuário Menor de 19 Anos {mskDateNascimento.Text} Incorreta";
            }
            else if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                validador = false;
                lblName.Visible = true;
                lblName.Text = "Campo Nome é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtsobrenome.Text))
            {
                validador = false;
                txtsobrenome.MaxLength = 8;
                lblSobrenome.Visible = true;
                lblSobrenome.Text = "Campo SobreNome é Obrigatório";
            }
            else if (!mskCep.MaskCompleted)
            {
                validador = false;
                lblCEP.Visible = true;
                lblCEP.Text = "Campo CEP é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtlogradouro.Text))
            {
                validador = false;
                lblLogradouro.Visible = true;
                lblLogradouro.Text = "Campo Logradouro é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtnumero.Text))
            {
                validador = false;
                lblNumero.Visible = true;
                lblNumero.Text = "Campo Número é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                validador = false;
                lblBairro.Visible = true;
                lblBairro.Text = "Campo Bairro é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                validador = false;
                lblCidade.Visible = true;
                lblCidade.Text = "Campo Cidade é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtUF.Text))
            {
                validador = false;
                lblUF.Visible = true;
                lblUF.Text = "Campo UF é Obrigatório";
            }

            if (validador == false)
            {
                MessageBox.Show("Erro ao Cadastrar, favor validar os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (validador.Equals(true))
            {
                MessageBox.Show($"Cadastro efetuado com sucesso no dia e horário de: {DateTime.Now}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                maskCPF.Clear();
                mskDateNascimento.Clear();
                txtname.Clear();
                txtsobrenome.Clear();
                mskCep.Clear();
                txtlogradouro.Clear();
                txtnumero.Clear();
                txtcomplemento.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtUF.Clear();
            }
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtsobrenome_TextChanged(object sender, EventArgs e)
        {
            txtsobrenome.MaxLength = 15;
        }

        private void txtcep_TextChanged(object sender, EventArgs e)
        {
            //mskCep.MaxLength = 8;
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            txtUF.MaxLength = 8;
        }

        private void mskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCep.MaxLength = 8;
        }
        private void btnEnviarJuri_Click(object sender, EventArgs e)
        {
            lblcnpjJuri.Visible = false;
            lblrazaoJuri.Visible = false;
            lblnomefantasiaJurical.Visible = false;
            lblCEPJuri.Visible = false;
            lblLogradourojuri.Visible = false;
            lblNumeroJuri.Visible = false;
            lblbairrojuri.Visible = false;
            lblCidadejuri.Visible = false;
            lblUFjuri.Visible = false;
            bool validador = true;

            if (!mskCNPJ.MaskCompleted)
            {
                validador = false;
                lblcnpjJuri.Visible = true;
                lblcnpjJuri.Text = "Campo CNPJ é Obrigatório.";
            }
            else if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
            {
                validador = false;
                lblrazaoJuri.Visible = true;
                lblrazaoJuri.Text = "Campo Razão Social é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtNomeFantasia.Text))
            {
                validador = false;
                lblnomefantasiaJurical.Visible = true;
                lblnomefantasiaJurical.Text = "Campo Nome Fantasia é Obrigatório";
            }
            else if (!mskCEPJuri.MaskCompleted)
            {
                validador = false;
                lblCEPJuri.Visible = true;
                lblCEPJuri.Text = "Campo CEP é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtlogradourojuri.Text))
            {
                validador = false;
                lblLogradourojuri.Visible = true;
                lblLogradourojuri.Text = "Campo Logradouro é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtnumjuridi.Text))
            {
                validador = false;
                lblNumeroJuri.Visible = true;
                lblNumeroJuri.Text = "Campo Número é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtbairrojuri.Text))
            {
                validador = false;
                lblbairrojuri.Visible = true;
                lblbairrojuri.Text = "Campo Bairro é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtcidadejuri.Text))
            {
                validador = false;
                lblCidadejuri.Visible = true;
                lblCidadejuri.Text = "Campo Cidade é Obrigatório";
            }
            else if (string.IsNullOrWhiteSpace(txtufjuri.Text))
            {
                validador = false;
                lblUFjuri.Visible = true;
                lblUFjuri.Text = "Campo UF é Obrigatório";
            }
            if (validador == false)
            {
                MessageBox.Show("Erro ao Cadastrar, favor validar os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (validador.Equals(true))
            {
                MessageBox.Show($"Cadastro efetuado com sucesso no dia e horário de: {DateTime.Now}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                mskCNPJ.Clear();
                txtRazaoSocial.Clear();
                txtNomeFantasia.Clear();
                mskCEPJuri.Clear();
                txtlogradourojuri.Clear();
                txtnumjuridi.Clear();
                txtcompljuri.Clear();
                txtbairrojuri.Clear();
                txtcidadejuri.Clear();
                txtufjuri.Clear();
            }

        }

        private void mskCEPJuri_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCEPJuri.MaxLength = 8;
        }

        private void txtufjuri_TextChanged(object sender, EventArgs e)
        {
            txtufjuri.MaxLength = 8;
        }
    }
}
