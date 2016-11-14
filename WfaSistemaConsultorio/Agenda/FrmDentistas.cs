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
    public partial class FrmDentistas : Form
    {
        DentistaServico servicoDentista = new DentistaServico();

        public FrmDentistas()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        public void IniciarFormulario()
        {
            var lstDentistas = servicoDentista.BuscarTodos();
            //var lstDentistas = new List<Dentista>();
            //Dentista d1 = new Dentista { Id=1, Nome = " joao" };
            //Dentista d2 = new Dentista { Id = 2, Nome = "maria" };
            //Dentista d3 = new Dentista { Id = 3, Nome = "mtavio" };
            //Dentista d4 = new Dentista { Id = 4, Nome = " Raquel" };
            //lstDentistas.Add(d1);
            //lstDentistas.Add(d2);
            //lstDentistas.Add(d3);
            //lstDentistas.Add(d4);

            if (lstDentistas == null)
                MessageBox.Show("Não exitem dentistas cadastrados");
            else
            {

                char letraAnterior = '#';
                int numeroTabela = -1;
                DataGridView data = new DataGridView();

                foreach (var dentista in lstDentistas)
                {
                    char primeiraLetra = dentista.Nome.Trim()[0];

                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        GerarLinha(data, dentista);
                    }
                    else
                    {
                        numeroTabela = numeroTabela + 1;
                        tabControlDentistas.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dgv = new DataGridView();
                        data = dgv;
                        tabControlDentistas.TabPages[numeroTabela].Controls.Add(dgv);
                        GerarTabela(dgv);
                        GerarLinha(dgv, dentista);
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

        public void GerarLinha(DataGridView dgv, Dentista dentista)
        {            
                int linhaAtual = dgv.Rows.Add();
                dgv.Rows[linhaAtual].Cells[0].Value = dentista.Id;
                dgv.Rows[linhaAtual].Cells[1].Value = dentista.Nome;
                dgv.Rows[linhaAtual].Cells[2].Value = dentista.Telefone.ToString("(00) 0000-0000");
                dgv.Rows[linhaAtual].Cells[3].Value = dentista.Celular.ToString("(00) 0000-0000");
        }

        public void Tabela_Clicada(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex != -1 )
                {
                    var idDentista = dgv.Rows[e.RowIndex].Cells[0].Value;
                    Dentista d = servicoDentista.Buscar(Convert.ToInt32(idDentista));
                    //Dentista d = new Dentista { Id = Convert.ToInt32(idDentista), Nome = " joao", Email = "mjaojr@gmail.com", CRO = "60135-410" };
                    var Form = new Vizualizar.FrmVizualizarDentista(d);
                    Form.ShowDialog();
                    if (Form.status == "apagado")
                    {
                        this.Close();
                        FrmDentistas form = new FrmDentistas();
                        form.Show();
                    }
                    if (Form.status == "editado")
                    {
                        dgv.Rows.RemoveAt(e.RowIndex);
                        GerarLinha(dgv, d);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor entrar em contato com o adminstrador do sistema" + ex, "Ops!");
            }
        }
    }
}
