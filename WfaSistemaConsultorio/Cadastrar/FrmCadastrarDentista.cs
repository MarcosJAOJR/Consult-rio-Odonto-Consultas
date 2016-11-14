using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfSistemaConsultorio;
using SistemaConsultorio.Dominio;

namespace WfaSistemaConsultorio
{
    public partial class FrmCadastrarDentista : Form
    {
        DentistaServico servicoDentista = new DentistaServico();
        public FrmCadastrarDentista()
        {
            InitializeComponent();
            txtNomeDentista.Text = txtCelularDentista.Text;
        }

        private string ValidarCadastro()
        {
            tsslblAvisoDentista.ForeColor = Color.Red;
            if (txtNomeDentista.Text == string.Empty)
            {
                return "O nome do dentista é obrigatório";
            }
            else if (txtCelularDentista.Text == string.Empty && txtTelefoneDentista.Text == string.Empty)
            {
                return "É necessário cadastrar o telefone fixo ou o celular";
            }
            else if (!txtCelularDentista.MaskFull && !txtTelefoneDentista.MaskFull)
            {
                return "O numero do telefone ou do celular não é válido";
            }
            else if (txtCRODentista.Text == string.Empty)
            {
                return "O CRO do dentista é obrigatório";
            }
            else
            {
                tsslblAvisoDentista.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void btnCadastrarDentista_Click(object sender, EventArgs e)
        {
            try
            {
                tsslblAvisoDentista.Text = ValidarCadastro();
                if (tsslblAvisoDentista.Text == "Sucesso")
                {
                    servicoDentista.Cadastrar(GerarDentista());
                    MessageBox.Show("O cadastro foi realizado com sucesso!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor entrar em contato com o adminstrador do sistema\n"+ ex, "Ops!");
            }
        }

        public Dentista GerarDentista()
        {
            Dentista d = new Dentista();

            d.Nome = txtNomeDentista.Text; 
            d.Email = txtEmailDentista.Text;
            d.Telefone = txtTelefoneDentista.Text != "" ? Convert.ToInt64(txtTelefoneDentista.Text) : 0;
            d.Celular = txtCelularDentista.Text != "" ? Convert.ToInt64(txtCelularDentista.Text) : 0;
            d.CRO = txtCRODentista.Text;

            return d;
        }
    }
}
