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

namespace WfaSistemaConsultorio.Agenda
{
    public partial class FrmAgendaCompleta : Form
    {
        private PacienteServico servicoPaciente = new PacienteServico();
        private ConsultaServico servicoConsulta = new ConsultaServico();
        private DentistaServico servicoDentista = new DentistaServico();

        private Dictionary<int, DataGridView> DataGridViews = new Dictionary<int, DataGridView>();

        public FrmAgendaCompleta()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        public void IniciarFormulario()
        {
            var lstDentistas = servicoDentista.BuscarTodos();
            //var lstDentistas = new List<Dentista>();
            //Dentista d1 = new Dentista { Nome = " joao", Id=1 };
            //Dentista d2 = new Dentista { Nome = "maria", Id = 2 };
            //Dentista d3 = new Dentista { Nome = "mtavio", Id = 7 };
            //Dentista d4 = new Dentista { Nome = " Raquel", Id = 4 };
            //lstDentistas.Add(d1);
            //lstDentistas.Add(d2);
            //lstDentistas.Add(d3);
            //lstDentistas.Add(d4);

            foreach (var dentista in lstDentistas)
            {
                tabControlAgenda.TabPages.Add(dentista.Id.ToString(), dentista.Nome);

                DataGridView dgv = new DataGridView();
                DataGridViews.Add(dentista.Id, dgv);
                GerarTabela(dgv);
                tabControlAgenda.TabPages[dentista.Id.ToString()].Controls.Add(dgv);                
            }
        }

        public void GerarTabela(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Chocolate;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.Columns.Add("ColunaCodigoConsulta", "CodigoConsulta");
            dgv.Columns[0].Visible = false;
            dgv.Columns.Add("ColunaHora", "");
            DataGridViewLinkColumn colPaciente = new DataGridViewLinkColumn();
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "ColunaNomePaciente";
            dgv.Columns.Add(colPaciente);
            dgv.Columns.Add("ColunaStatus", "Status");
            DataGridViewLinkColumn colConsulta = new DataGridViewLinkColumn();
            colConsulta.HeaderText = "";
            colConsulta.Name = "ColunaVerConsulta";
            dgv.Columns.Add(colConsulta);
            dgv.CellContentClick += new DataGridViewCellEventHandler(this.Tabela_Clicada);
        }

        public void GerarLinha(DataGridView dgv, int dentistaId)
        {
            var dentista = servicoDentista.Buscar(dentistaId);
            List<Consulta> consultas = servicoConsulta.Buscar(dentista, Convert.ToDateTime(dtpDataMostrada.Value.ToString("dd/MM/yyyy"))).OrderBy(x => x.HoraMarcada).ToList();
            //List<Consulta> consultas = new List<Consulta>();
            //Consulta d1 = new Consulta { IdConsulta = 1, HoraMarcada = DateTime.Parse("8:00") };
            //Consulta d2 = new Consulta { IdConsulta = 1, HoraMarcada = DateTime.Parse("12:00") };
            //Consulta d3 = new Consulta { IdConsulta = 1, HoraMarcada = DateTime.Parse("13:00") };
            //Consulta d4 = new Consulta { IdConsulta = 1, HoraMarcada = DateTime.Parse("22:00") };
            //consultas.Add(d1);
            //consultas.Add(d2);
            //consultas.Add(d3);
            //consultas.Add(d4);

            foreach (var consulta in consultas)
            {
                int linhaAtual = dgv.Rows.Add();
                dgv.Rows[linhaAtual].Cells[0].Value = consulta.IdConsulta;
                dgv.Rows[linhaAtual].Cells[1].Value = consulta.HoraMarcada.Value.ToString("HH:mm");
                dgv.Rows[linhaAtual].Cells[2].Value = servicoPaciente.Buscar(Convert.ToInt32(consulta.IdPaciente)).Nome;
                dgv.Rows[linhaAtual].Cells[3].Value = consulta.Status;
                dgv.Rows[linhaAtual].Cells[4].Value = "Ver Consulta";
            }
        }

        public void AtualizarLinhas()
        {
            if (tabControlAgenda.SelectedTab.Name != "HomeAgenda")
            {

                var indiceTab = Convert.ToInt32(tabControlAgenda.SelectedTab.Name);
                DataGridViews[indiceTab].Rows.Clear();
                GerarLinha(DataGridViews[indiceTab], indiceTab);
            }
        }

        private void tabControlAgenda_Selecting(Object sender, TabControlCancelEventArgs e)
        {
            AtualizarLinhas();
        }

        private void btnBuscarData_Click(object sender, EventArgs e)
        {
            AtualizarLinhas();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            dtpDataMostrada.Value = dtpDataMostrada.Value.AddDays(1);
            AtualizarLinhas();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dtpDataMostrada.Value = dtpDataMostrada.Value.AddDays(-1);
            AtualizarLinhas();
        }

        public void Tabela_Clicada(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var idConsulta = dgv.Rows[e.RowIndex].Cells[0].Value;
            Consulta c = servicoConsulta.Buscar(Convert.ToInt32(idConsulta));
            //Consulta c = new Consulta { IdConsulta = Convert.ToInt32(idConsulta), HoraMarcada = DateTime.Parse("8:00") };
            try
            {
                if (e.ColumnIndex == 2 && e.RowIndex != -1)
                {
                    Paciente p = servicoPaciente.Buscar(c.IdPaciente);
                    Vizualizar.FrmVizualizarPaciente verPaciente = new Vizualizar.FrmVizualizarPaciente(p);
                    verPaciente.ShowDialog();
                    AtualizarLinhas();
                }
                if (e.ColumnIndex == 4 && e.RowIndex != -1)
                {
                    var Form = new Vizualizar.FrmVizualizarConsulta(c);
                    Form.ShowDialog();
                    AtualizarLinhas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor entrar em contato com o adminstrador do sistema", "Ops!");
            }
        }
    }
}
