using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaConsultorio.Dominio;
using WcfSistemaConsultorio;

namespace WfaSistemaConsultorio.Vizualizar
{
    public partial class FrmVizualizarDentista : Form
    {
        public string status;

        Dentista dentista = new Dentista();

        DentistaServico servicoDentista = new DentistaServico();

        public FrmVizualizarDentista(Dentista d)
        {
            InitializeComponent();
            IniciarFormulario(d);
        }

        public void IniciarFormulario(Dentista dentistaParametro)
        {
            this.dentista = dentistaParametro;

            lblIdDentista.Text = this.dentista.Id.ToString();
            txtNomeDentista.Text = this.dentista.Nome;
            txtEmailDentista.Text = this.dentista.Email;
            txtTelefoneDentista.Text = this.dentista.Telefone.ToString();
            txtCelularDentista.Text = this.dentista.Celular.ToString();
            txtCRODentista.Text = this.dentista.CRO;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            txtNomeDentista.Enabled = true;
            txtEmailDentista.Enabled = true;
            txtTelefoneDentista.Enabled = true;
            txtCelularDentista.Enabled = true;
            txtCRODentista.Enabled = true;
            btnConfirmarEditar.Visible = true;
        }

        private void btnConfirmarEditar_Click(object sender, EventArgs e)
        {
            tsslblAvisoDentista.Text = ValidarCadastro();
            if (tsslblAvisoDentista.Text == "Sucesso")
            {
                if (txtNomeDentista.Text != this.dentista.Nome)
                    status = "apagado";
                else
                    status = "editado";
                this.dentista.Nome = txtNomeDentista.Text;
                this.dentista.Email = txtEmailDentista.Text;
                this.dentista.Telefone = txtTelefoneDentista.Text != "" ? Convert.ToInt64(txtTelefoneDentista.Text) : 0;
                this.dentista.Celular = txtCelularDentista.Text != "" ? Convert.ToInt64(txtCelularDentista.Text) : 0;
                this.dentista.CRO = txtCRODentista.Text;
                servicoDentista.Atualizar(this.dentista);
                this.Close();
            }
        }

        public bool ExclusaoValida()
        {
            DialogResult confirmacao = MessageBox.Show("Deseja realmente apagar esse dentista?", "Apagar Dentista",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Exclamation,
                                                        MessageBoxDefaultButton.Button2);

            if (confirmacao.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }

        private void tsbApagar_Click(object sender, EventArgs e)
        {
            if (ExclusaoValida())
            {
                servicoDentista.Deletar(this.dentista.Id);
                MessageBox.Show("Dentista excluido com sucesso");
                status = "apagado";
                this.Close();
            }
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
    }
}
