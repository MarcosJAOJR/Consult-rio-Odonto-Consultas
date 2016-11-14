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
    public partial class FrmVizualizarConsulta : Form
    {
        Consulta consulta = new Consulta();

        ConsultaServico servicoConsulta = new ConsultaServico();
        DentistaServico servicoDentista = new DentistaServico();
        PacienteServico servicoPaciente = new PacienteServico();


        public FrmVizualizarConsulta(Consulta c)
        {
            InitializeComponent();
            IniciarFormulario(c);
        }

        public void IniciarFormulario(Consulta consultaParametro)
        {
            this.consulta = consultaParametro;

            lblIdConsulta.Text = this.consulta.IdConsulta.ToString();
            cmbPaciente.Text = servicoPaciente.Buscar(this.consulta.IdPaciente).Nome;
            cmbDentista.Text = servicoDentista.Buscar(this.consulta.IdDentista).Nome;
            txtDataConsulta.Text = this.consulta.Data.ToString();
            txtHoraMarcadaConsulta.Text = this.consulta.HoraMarcada.ToString();
            txtInicioConsulta.Text = this.consulta.HoraInicio.ToString();
            txtFimConsulta.Text = this.consulta.HoraFim.ToString();
            rtbObservacaoConsulta.Text = this.consulta.Observacao;
        }

        public bool ExclusaoValida()
        {
            DialogResult confirmacao = MessageBox.Show("Deseja realmente apagar essa consulta?", "Apagar Consulta", 
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
                servicoConsulta.Deletar(this.consulta.IdConsulta);
                MessageBox.Show("Consulta excluida com sucesso");
                this.Close();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            cmbPaciente.Enabled = true;
            cmbDentista.Enabled = true;
            txtDataConsulta.Enabled = true;
            txtHoraMarcadaConsulta.Enabled = true;
            txtInicioConsulta.Enabled = true;
            txtFimConsulta.Enabled = true;
            rtbObservacaoConsulta.Enabled = true;
            btnConfirmarEditar.Visible = true;

            try
            {
                var lista1 = servicoDentista.BuscarTodos();
                var lstDentistas = new Dictionary<int, string>();
                lstDentistas.Add(0, "");
                foreach (var item in lista1)
                {
                    lstDentistas.Add(item.Id, item.Nome);
                }
                cmbDentista.DataSource = new BindingSource(lstDentistas, null);
                cmbDentista.DisplayMember = "Value";
                cmbDentista.ValueMember = "Key";

                cmbDentista.SelectedValue = this.consulta.IdDentista;
            }
            catch { }

            try
            {
                var lista2 = servicoPaciente.BuscarTodos();
                var lstPacientes = new Dictionary<int, string>();
                lstPacientes.Add(0, "");
                foreach (var item in lista2)
                {
                    lstPacientes.Add(item.Id, item.Nome);
                }
                cmbPaciente.DataSource = new BindingSource(lstPacientes, null);
                cmbPaciente.DisplayMember = "Value";
                cmbPaciente.ValueMember = "Key";

                cmbPaciente.SelectedValue = this.consulta.IdPaciente;
            }
            catch { }
        }

        private void btnConfirmarEditar_Click(object sender, EventArgs e)
        {
            tsslblAvisoConsulta.Text = ValidarCadastro();
            if (tsslblAvisoConsulta.Text == "Sucesso")
            {
                this.consulta.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
                this.consulta.IdDentista = Convert.ToInt32(cmbDentista.SelectedValue);
                this.consulta.Data = Convert.ToDateTime(txtDataConsulta.Text);
                this.consulta.HoraMarcada = Convert.ToDateTime(txtHoraMarcadaConsulta.Text);
                this.consulta.HoraInicio = Convert.ToDateTime(txtInicioConsulta.Text);
                this.consulta.HoraFim = Convert.ToDateTime(txtFimConsulta.Text);
                this.consulta.Observacao = rtbObservacaoConsulta.Text;
                servicoConsulta.Atualizar(this.consulta);
                this.Close();
            }
        }

        public string ValidarCadastro()
        {
            tsslblAvisoConsulta.ForeColor = Color.Red;
            if (cmbDentista.SelectedIndex == 0)
            {
                return "É necessário escolher um dentista";
            }
            else if (cmbPaciente.SelectedIndex == 0)
            {
                return "É necessário escolher um paciente";
            }
            else if (txtHoraMarcadaConsulta.Text == string.Empty)
            {
                return "É necessário marcar uma hora para a consulta";
            }
            else
            {
                tsslblAvisoConsulta.ForeColor = Color.Black;
                return "Sucesso";
            }
        }
    }
}
