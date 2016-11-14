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

namespace WfaSistemaConsultorio
{
    public partial class FrmPrincipal : Form
    {
        private PacienteServico servicoPaciente = new PacienteServico();
        DentistaServico servicoDentista = new DentistaServico();
        private ConsultaServico servicoConsulta = new ConsultaServico();

        public FrmPrincipal()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        public void IniciarFormulario()
        {
            try
            {
                var lstDentistas = new Dictionary<int, string>();
                var lista = servicoDentista.BuscarTodos();
                if (lista == null)
                {
                    lstDentistas.Add(0, "Nenhum dentista cadastrado");
                }
                else
                {
                    foreach (var item in lista)
                    {
                        lstDentistas.Add(item.Id, item.Nome);
                    }
                }
                cmbDentistaAgenda.DataSource = new BindingSource(lstDentistas, null);
                cmbDentistaAgenda.DisplayMember = "Value";
                cmbDentistaAgenda.ValueMember = "Key";

                atualizarAgenda(Convert.ToInt32(cmbDentistaAgenda.SelectedValue));
            }
            catch
            {
                MessageBox.Show("Aparentemente o banco de dados não esta configurado corretamente, entre em contato com o administrador do sistema");
            }
        }
        
        private void atualizarAgenda(int idDentista)
        {
            Dentista dentista = new Dentista();
            dentista = servicoDentista.Buscar(idDentista);
            if (dentista != null)
            {
                dgvAgendaDia.Rows.Clear();
                gerarAgendaDiaria(dentista);
            }
        }

        private void gerarAgendaDiaria (Dentista dentista)
        {
            var consultasHoje = servicoConsulta.Buscar(dentista, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))).OrderBy(c => c.HoraMarcada);
            if (consultasHoje == null)
            {
                MessageBox.Show("Esse dentista não possui pacientes hoje");
            }
            else
            {
                foreach (var item in consultasHoje)
                {
                    int linha = dgvAgendaDia.Rows.Add();
                    dgvAgendaDia.Rows[linha].Cells[0].Value = item.IdConsulta;
                    dgvAgendaDia.Rows[linha].Cells[1].Value = item.HoraMarcada.Value.ToString("HH:mm");
                    dgvAgendaDia.Rows[linha].Cells[2].Value = servicoPaciente.Buscar(item.IdPaciente).Nome; //esta busca retorna um Paciente
                    dgvAgendaDia.Rows[linha].Cells[3].Value = imagemStatus(item.Status);
                    dgvAgendaDia.Rows[linha].Cells[4].Value = item.IdPaciente;
                }
            }
        }

        private void dgvAgendaDia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DataGridView dgv = sender as DataGridView;
                int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[4].Value);
                Paciente p = servicoPaciente.Buscar(id);
                Vizualizar.FrmVizualizarPaciente verPaciente = new Vizualizar.FrmVizualizarPaciente(p);
                verPaciente.Show();
            }
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                var Id = Convert.ToInt32(dgvAgendaDia.Rows[e.RowIndex].Cells[0].Value);
                Consulta c = servicoConsulta.Buscar(Id);
                string s = c.Status;
                switch (s)
                {
                    case "Confirmado":
                        c.Status = "Desmarcado";
                        break;
                    case "Desmarcado":
                        c.Status = "Ja chegou";
                        break;
                    case "Ja chegou":
                        c.Status = "Em atendimento";
                        break;
                    case "Em atendimento":
                        c.Status = "Nao confirmado";
                        break;
                    case "Nao confirmado":
                        c.Status = "Confirmado";
                        break;
                    default:
                        c.Status = "Nao confirmado";
                        break;
                }
                servicoConsulta.Atualizar(c);
                atualizarAgenda(Convert.ToInt32(cmbDentistaAgenda.SelectedValue));
            }
        }

        private Bitmap imagemStatus (string s)
        {
            var imagem = new Bitmap(Properties.Resources.Circle_Grey);
            switch(s)
            {
                case "Confirmado":
                    imagem = new Bitmap(Properties.Resources.Circle_Blue);
                    break;
                case "Desmarcado":
                    imagem = new Bitmap(Properties.Resources.Circle_Red);
                    break;
                case "Nao confirmado":
                    imagem = new Bitmap(Properties.Resources.Circle_Grey);
                    break;
                case "Ja chegou":
                    imagem = new Bitmap(Properties.Resources.Circle_Orange);
                    break;
                case "Em atendimento":
                    imagem = new Bitmap(Properties.Resources.Circle_Green);
                    break;
                default:
                    imagem = new Bitmap(Properties.Resources.address171);
                    break;
            }
            return imagem;
        }

        private void dentistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarDentista FormDentista = new FrmCadastrarDentista();
            FormDentista.ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastarPaciente FormPaciente = new FrmCadastarPaciente();
            FormPaciente.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda.FrmAgendaCompleta agenda = new Agenda.FrmAgendaCompleta();
            agenda.Show();
            FrmCadastrarConsulta FormConsulta = new FrmCadastrarConsulta();
            FormConsulta.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda.FrmAgendaCompleta form = new Agenda.FrmAgendaCompleta();
            form.Show();
        }

        private void dentistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agenda.FrmDentistas form = new Agenda.FrmDentistas();
            form.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda.FrmPacientes form = new Agenda.FrmPacientes();
            form.Show();
        }

        private void reportarProblemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Suporte.FrmReportarProblema form = new Suporte.FrmReportarProblema();
            form.Show();
        }

        private void cmbDentistaAgenda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            atualizarAgenda(Convert.ToInt32(cmbDentistaAgenda.SelectedValue));
        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            atualizarAgenda(Convert.ToInt32(cmbDentistaAgenda.SelectedValue));
        }

        private void btnAdicionarLembrete_Click(object sender, EventArgs e)
        {
            Inicio.FrmLembrete lembrete = new Inicio.FrmLembrete();
            lembrete.ShowDialog();

            RichTextBox postit = new RichTextBox();
            postit.ReadOnly = true;
            postit.BorderStyle = BorderStyle.None;
            postit.Font = new Font(FontFamily.GenericSansSerif, 15F);
            postit.ForeColor = Color.FromArgb(64, 64, 64);
            postit.Width = 200;
            postit.Height = 200;
            postit.BackColor = lembrete.cor;
            postit.Text = lembrete.texto;
            flowLayoutPanel1.Controls.Add(postit);
        }
    }
}
