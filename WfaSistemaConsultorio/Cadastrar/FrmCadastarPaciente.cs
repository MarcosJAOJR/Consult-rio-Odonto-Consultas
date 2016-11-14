using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaConsultorio.Servico;
using SistemaConsultorio.Dominio;
using WcfSistemaConsultorio;

namespace WfaSistemaConsultorio
{
    public partial class FrmCadastarPaciente : Form
    {

        private PacienteServico servicoPaciente = new PacienteServico();


        public FrmCadastarPaciente()
        {
            InitializeComponent();
        }

        private string ValidarCadastro()
        {
            tsslblAvisoPaciente.ForeColor = Color.Red;
            if (txtNomePaciente.Text == string.Empty)
            {
                return "O nome do paciente é obrigatório";
            }
            else if(txtCelularPaciente.Text == string.Empty && txtTelefonePaciente.Text == string.Empty)
            {
                return "É necessário cadastrar o telefone fixo ou o celular";
            }
            else if (!txtCelularPaciente.MaskFull && !txtTelefonePaciente.MaskFull)
            {
                return "O numero do telefone ou do celular não é válido";
            }
            else
            {
                tsslblAvisoPaciente.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                tsslblAvisoPaciente.Text = ValidarCadastro();
                if (tsslblAvisoPaciente.Text == "Sucesso")
                {
                    servicoPaciente.Cadastrar(GerarPaciente());
                    this.Close();
                    MessageBox.Show("O cadastro foi realizado com sucesso!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor entrar em contato com o adminstrador do sistema\n"+ex,"Ops!");
            }
        }

        public Paciente GerarPaciente()
        {
            Paciente p = new Paciente();

            p.Nome = txtNomePaciente.Text;
            p.Email = txtEmailPaciente.Text;
            p.Telefone = txtTelefonePaciente.Text != "" ? Convert.ToInt64(txtTelefonePaciente.Text): 0 ;
            p.Celular = txtCelularPaciente.Text != "" ? Convert.ToInt64(txtCelularPaciente.Text) : 0;
            p.CEP = txtCEPPaciente.Text;
            p.Endereco = txtEnderecoPaciente.Text;
            p.Complemento = txtComplementoPaciente.Text;
            p.Nascimento = dtpNascimentoPaciente.Value;
            if (radioButtonFeminino.Text == "True")
                p.Sexo = "F";
            else if (radioButtonMasculino.Text == "True")
                p.Sexo = "M";

            return p;
        }
    }
}
