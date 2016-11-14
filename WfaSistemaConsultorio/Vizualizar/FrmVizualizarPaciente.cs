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
    public partial class FrmVizualizarPaciente : Form
    {
        public string status;

        Paciente paciente { get; set; }

        PacienteServico servicoPaciente = new PacienteServico();

        public FrmVizualizarPaciente(Paciente p)
        {
            InitializeComponent();
            IniciarFormulario(p);
        }

        public void IniciarFormulario(Paciente pacienteParametro)
        {
            this.paciente = pacienteParametro;

            lblIdPaciente.Text = this.paciente.Id.ToString();
            txtNomePaciente.Text = this.paciente.Nome;
            txtEmailPaciente.Text = this.paciente.Email;
            txtTelefonePaciente.Text = this.paciente.Telefone.ToString();
            txtCelularPaciente.Text = this.paciente.Celular.ToString();
            txtCepPaciente.Text = this.paciente.CEP;
            txtEnderecoPaciente.Text = this.paciente.Endereco;
            txtComplementoPaciente.Text = this.paciente.Complemento;
            txtNascimentoPaciente.Text = this.paciente.Nascimento.ToString();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            txtNomePaciente.Enabled = true;
            txtEmailPaciente.Enabled = true;
            txtTelefonePaciente.Enabled = true;
            txtCelularPaciente.Enabled = true;
            txtCepPaciente.Enabled = true;
            txtEnderecoPaciente.Enabled = true;
            txtComplementoPaciente.Enabled = true;
            txtNascimentoPaciente.Enabled = true;
            btnConfirmarEditar.Visible = true;
        }

        private void btnConfirmarEditar_Click(object sender, EventArgs e)
        {
            tsslblAvisoPaciente.Text = ValidarCadastro();
            if (tsslblAvisoPaciente.Text == "Sucesso")
            {
                if (txtNomePaciente.Text != this.paciente.Nome)
                    status = "apagado";
                else
                    status = "editado";
                this.paciente.Nome = txtNomePaciente.Text;
                this.paciente.Email = txtEmailPaciente.Text;
                this.paciente.Telefone = txtTelefonePaciente.Text != "" ? Convert.ToInt64(txtTelefonePaciente.Text) : 0;
                this.paciente.Celular = txtCelularPaciente.Text != "" ? Convert.ToInt64(txtCelularPaciente.Text) : 0;
                this.paciente.CEP = txtCepPaciente.Text;
                this.paciente.Endereco = txtEnderecoPaciente.Text;
                this.paciente.Complemento = txtComplementoPaciente.Text;
                this.paciente.Nascimento = Convert.ToDateTime(txtNascimentoPaciente.Text);
                servicoPaciente.Atualizar(this.paciente);
                this.Close();
            }
        }

        public bool ExclusaoValida()
        {
            DialogResult confirmacao = MessageBox.Show("Deseja realmente apagar esse paciente?", "Apagar Paciente",
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
                try
                {
                    servicoPaciente.Deletar(1);
                    MessageBox.Show("Paciente excluido com sucesso");
                    status = "apagado";
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
        }

        private string ValidarCadastro()
        {
            tsslblAvisoPaciente.ForeColor = Color.Red;
            if (txtNomePaciente.Text == string.Empty)
            {
                return "O nome do paciente é obrigatório";
            }
            else if (txtCelularPaciente.Text == string.Empty && txtTelefonePaciente.Text == string.Empty)
            {
                return "É necessário cadastrar o telefone fixo ou o celular";
            }
            else
            {
                tsslblAvisoPaciente.ForeColor = Color.Black;
                return "Sucesso";
            }
        }
    }
}
