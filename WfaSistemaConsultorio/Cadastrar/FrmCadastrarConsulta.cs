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
    public partial class FrmCadastrarConsulta : Form
    {
        DentistaServico servicoDentista = new DentistaServico();
        PacienteServico servicoPaciente = new PacienteServico();
        ConsultaServico servicoConsulta = new ConsultaServico();

        public FrmCadastrarConsulta()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        public void IniciarFormulario()
        {
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
            }
            catch
            {

            }

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
            }
            catch { }
        }

        public string ValidarCadastro()
        {
            tsslblAvisoConsulta.ForeColor = Color.Red;
            if (Convert.ToInt32(cmbDentista.SelectedValue) == 0)
            {
                return "É necessário escolher um dentista";
            }
            else if (Convert.ToInt32(cmbPaciente.SelectedValue) == 0)
            {
                return "É necessário escolher um paciente";
            }
            else if (txtHorarioConsulta.Text == string.Empty)
            {
                return "É necessário marcar uma hora para a consulta";
            }
            else
            {
                tsslblAvisoConsulta.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void btnCadastrarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                tsslblAvisoConsulta.Text = ValidarCadastro();
                if (tsslblAvisoConsulta.Text == "Sucesso")
                {
                    servicoConsulta.Cadastrar(GerarConsulta());
                    MessageBox.Show("O cadastro foi realizado com sucesso!");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor entrar em contato com o adminstrador do sistema\n"+ex, "Ops!");
            }
        }

        public Consulta GerarConsulta()
        {
            Consulta c = new Consulta();

            c.IdDentista = Convert.ToInt32(cmbDentista.SelectedValue);
            c.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            c.Data = Convert.ToDateTime(dtpDataConsulta.Value.ToString("dd/MM/yyyy"));
            c.HoraMarcada = txtHorarioConsulta.Value;
            c.HoraInicio = Convert.ToDateTime("00:00");
            c.HoraFim = Convert.ToDateTime("00:00");
            c.Observacao = txtObservacoesConsulta.Text;
            c.Status = "Nao confirmado";

            return c;
        }
    }
}
