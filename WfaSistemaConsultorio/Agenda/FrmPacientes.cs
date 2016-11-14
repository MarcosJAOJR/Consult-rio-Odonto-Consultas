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

namespace WfaSistemaConsultorio.Agenda
{
    public partial class FrmPacientes : Form
    {
        PacienteServico servicoPaciente = new PacienteServico();

        public FrmPacientes()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        public void IniciarFormulario()
        {
            var lstPacientes = servicoPaciente.BuscarTodos();
            //var lstPacientes = new List<Paciente>();
            //Paciente p1 = new Paciente { Nome = " joao", Telefone = 8599156060 };
            //Paciente p2 = new Paciente { Nome = "maria", Celular = 0 };
            //Paciente p3 = new Paciente { Nome = "mtavio" };
            //Paciente p4 = new Paciente { Nome = " Raquel" };
            //lstPacientes.Add(p1);
            //lstPacientes.Add(p2);
            //lstPacientes.Add(p3);
            //lstPacientes.Add(p4);

            if (lstPacientes == null)
                MessageBox.Show("Não exitem dentistas cadastrados");
            else
            {

                char letraAnterior = '#';
                int numeroTabela = -1;
                DataGridView data = new DataGridView();

                foreach (var paciente in lstPacientes)
                {
                    char primeiraLetra = paciente.Nome.Trim()[0];

                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        GerarLinha(data, paciente);
                    }
                    else
                    {
                        numeroTabela = numeroTabela + 1;
                        tabControlPacientes.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dgv = new DataGridView();
                        data = dgv;
                        tabControlPacientes.TabPages[numeroTabela].Controls.Add(dgv);
                        GerarTabela(dgv);
                        GerarLinha(dgv, paciente);
                    }

                    letraAnterior = primeiraLetra;
                }
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
            dgv.Columns.Add("ColunaCodigo", "Codigo");
            dgv.Columns[0].Visible = false;
            DataGridViewLinkColumn col = new DataGridViewLinkColumn();
            col.HeaderText = "Nome";
            col.Name = "ColunaNome";
            dgv.Columns.Add(col);
            dgv.Columns.Add("ColunaTelefone", "Telefone");
            dgv.Columns.Add("ColunaCelular", "Celular");
            dgv.CellContentClick += new DataGridViewCellEventHandler(this.Tabela_Clicada);
        }

        public void GerarLinha(DataGridView dgv, Paciente paciente)
        {            
                int linhaAtual = dgv.Rows.Add();
                dgv.Rows[linhaAtual].Cells[0].Value = paciente.Id;
                dgv.Rows[linhaAtual].Cells[1].Value = paciente.Nome;
                dgv.Rows[linhaAtual].Cells[2].Value = paciente.Telefone.ToString("(00) 0000-0000");
                dgv.Rows[linhaAtual].Cells[3].Value = paciente.Celular.ToString("(00) 0000-0000");
        }

        public void Tabela_Clicada(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex != -1 )
                {
                    var idPaciente = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value;
                    Paciente p = servicoPaciente.Buscar(Convert.ToInt32(idPaciente));
                    //Paciente p = new Paciente { Nome = " joao", Email = "mjaojr@gmail.com", CEP = "60135-410", Endereco = "Rua dom Expedito Lopes, 2371", Complemento = "Apto 601" };
                    var Form = new Vizualizar.FrmVizualizarPaciente(p);
                    Form.ShowDialog();
                    if (Form.status == "apagado")
                    {
                        this.Close();
                        FrmPacientes form = new FrmPacientes();
                        form.Show();
                    }
                    if (Form.status == "editado")
                    {
                        dgv.Rows.RemoveAt(e.RowIndex);
                        GerarLinha(dgv, p);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor entrar em contato com o adminstrador do sistema", "Ops!");
            }
        }
    }
}
