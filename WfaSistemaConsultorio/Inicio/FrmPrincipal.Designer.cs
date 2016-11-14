namespace WfaSistemaConsultorio
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainerDaEsquerda = new System.Windows.Forms.SplitContainer();
            this.splitContainerDaAgenda = new System.Windows.Forms.SplitContainer();
            this.cmbDentistaAgenda = new System.Windows.Forms.ComboBox();
            this.dgvAgendaDia = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaPaciente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colunaStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerDaDireita = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainerDoLembrete = new System.Windows.Forms.SplitContainer();
            this.btnAdicionarLembrete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dentistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dentistasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarProblemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDaEsquerda)).BeginInit();
            this.splitContainerDaEsquerda.Panel2.SuspendLayout();
            this.splitContainerDaEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDaAgenda)).BeginInit();
            this.splitContainerDaAgenda.Panel1.SuspendLayout();
            this.splitContainerDaAgenda.Panel2.SuspendLayout();
            this.splitContainerDaAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDaDireita)).BeginInit();
            this.splitContainerDaDireita.Panel1.SuspendLayout();
            this.splitContainerDaDireita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDoLembrete)).BeginInit();
            this.splitContainerDoLembrete.Panel1.SuspendLayout();
            this.splitContainerDoLembrete.Panel2.SuspendLayout();
            this.splitContainerDoLembrete.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(904, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 20);
            this.toolStripStatusLabel1.Text = "Copyright © Consultas.";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 61);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainerDaEsquerda);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainerDaDireita);
            this.splitContainer6.Size = new System.Drawing.Size(904, 522);
            this.splitContainer6.SplitterDistance = 358;
            this.splitContainer6.SplitterWidth = 5;
            this.splitContainer6.TabIndex = 2;
            // 
            // splitContainerDaEsquerda
            // 
            this.splitContainerDaEsquerda.CausesValidation = false;
            this.splitContainerDaEsquerda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDaEsquerda.IsSplitterFixed = true;
            this.splitContainerDaEsquerda.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDaEsquerda.Name = "splitContainerDaEsquerda";
            // 
            // splitContainerDaEsquerda.Panel2
            // 
            this.splitContainerDaEsquerda.Panel2.Controls.Add(this.splitContainerDaAgenda);
            this.splitContainerDaEsquerda.Size = new System.Drawing.Size(358, 522);
            this.splitContainerDaEsquerda.SplitterDistance = 25;
            this.splitContainerDaEsquerda.SplitterWidth = 1;
            this.splitContainerDaEsquerda.TabIndex = 0;
            this.splitContainerDaEsquerda.TabStop = false;
            // 
            // splitContainerDaAgenda
            // 
            this.splitContainerDaAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerDaAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDaAgenda.IsSplitterFixed = true;
            this.splitContainerDaAgenda.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDaAgenda.Name = "splitContainerDaAgenda";
            this.splitContainerDaAgenda.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDaAgenda.Panel1
            // 
            this.splitContainerDaAgenda.Panel1.Controls.Add(this.label2);
            this.splitContainerDaAgenda.Panel1.Controls.Add(this.cmbDentistaAgenda);
            // 
            // splitContainerDaAgenda.Panel2
            // 
            this.splitContainerDaAgenda.Panel2.Controls.Add(this.dgvAgendaDia);
            this.splitContainerDaAgenda.Size = new System.Drawing.Size(332, 522);
            this.splitContainerDaAgenda.SplitterDistance = 55;
            this.splitContainerDaAgenda.TabIndex = 0;
            // 
            // cmbDentistaAgenda
            // 
            this.cmbDentistaAgenda.FormattingEnabled = true;
            this.cmbDentistaAgenda.Location = new System.Drawing.Point(0, 29);
            this.cmbDentistaAgenda.Name = "cmbDentistaAgenda";
            this.cmbDentistaAgenda.Size = new System.Drawing.Size(325, 23);
            this.cmbDentistaAgenda.TabIndex = 1;
            this.cmbDentistaAgenda.SelectionChangeCommitted += new System.EventHandler(this.cmbDentistaAgenda_SelectionChangeCommitted);
            // 
            // dgvAgendaDia
            // 
            this.dgvAgendaDia.AllowUserToAddRows = false;
            this.dgvAgendaDia.AllowUserToDeleteRows = false;
            this.dgvAgendaDia.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgendaDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgendaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.colunaHora,
            this.colunaPaciente,
            this.colunaStatus,
            this.CodigoPaciente});
            this.dgvAgendaDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgendaDia.Location = new System.Drawing.Point(0, 0);
            this.dgvAgendaDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAgendaDia.Name = "dgvAgendaDia";
            this.dgvAgendaDia.ReadOnly = true;
            this.dgvAgendaDia.RowHeadersVisible = false;
            this.dgvAgendaDia.Size = new System.Drawing.Size(330, 461);
            this.dgvAgendaDia.TabIndex = 0;
            this.dgvAgendaDia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendaDia_CellContentClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // colunaHora
            // 
            this.colunaHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colunaHora.HeaderText = "";
            this.colunaHora.Name = "colunaHora";
            this.colunaHora.ReadOnly = true;
            this.colunaHora.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colunaHora.Width = 19;
            // 
            // colunaPaciente
            // 
            this.colunaPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaPaciente.HeaderText = "Paciente";
            this.colunaPaciente.Name = "colunaPaciente";
            this.colunaPaciente.ReadOnly = true;
            // 
            // colunaStatus
            // 
            this.colunaStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colunaStatus.HeaderText = "Status";
            this.colunaStatus.Name = "colunaStatus";
            this.colunaStatus.ReadOnly = true;
            this.colunaStatus.Width = 47;
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.HeaderText = "CodigoPaciente";
            this.CodigoPaciente.Name = "CodigoPaciente";
            this.CodigoPaciente.ReadOnly = true;
            this.CodigoPaciente.Visible = false;
            // 
            // splitContainerDaDireita
            // 
            this.splitContainerDaDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDaDireita.IsSplitterFixed = true;
            this.splitContainerDaDireita.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDaDireita.Name = "splitContainerDaDireita";
            // 
            // splitContainerDaDireita.Panel1
            // 
            this.splitContainerDaDireita.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainerDaDireita.Size = new System.Drawing.Size(541, 522);
            this.splitContainerDaDireita.SplitterDistance = 512;
            this.splitContainerDaDireita.SplitterWidth = 1;
            this.splitContainerDaDireita.TabIndex = 2;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainerDoLembrete);
            this.splitContainer4.Size = new System.Drawing.Size(512, 522);
            this.splitContainer4.SplitterDistance = 168;
            this.splitContainer4.TabIndex = 1;
            // 
            // splitContainerDoLembrete
            // 
            this.splitContainerDoLembrete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDoLembrete.IsSplitterFixed = true;
            this.splitContainerDoLembrete.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDoLembrete.Name = "splitContainerDoLembrete";
            this.splitContainerDoLembrete.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDoLembrete.Panel1
            // 
            this.splitContainerDoLembrete.Panel1.Controls.Add(this.btnAdicionarLembrete);
            this.splitContainerDoLembrete.Panel1.Controls.Add(this.label1);
            // 
            // splitContainerDoLembrete.Panel2
            // 
            this.splitContainerDoLembrete.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerDoLembrete.Size = new System.Drawing.Size(510, 348);
            this.splitContainerDoLembrete.SplitterDistance = 33;
            this.splitContainerDoLembrete.TabIndex = 3;
            // 
            // btnAdicionarLembrete
            // 
            this.btnAdicionarLembrete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarLembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLembrete.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarLembrete.Location = new System.Drawing.Point(115, 5);
            this.btnAdicionarLembrete.Name = "btnAdicionarLembrete";
            this.btnAdicionarLembrete.Size = new System.Drawing.Size(80, 25);
            this.btnAdicionarLembrete.TabIndex = 1;
            this.btnAdicionarLembrete.Text = "+ Adicionar";
            this.btnAdicionarLembrete.UseVisualStyleBackColor = false;
            this.btnAdicionarLembrete.Click += new System.EventHandler(this.btnAdicionarLembrete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lembretes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(510, 311);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.suportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(904, 37);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dentistaToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(85, 31);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // dentistaToolStripMenuItem
            // 
            this.dentistaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.dentistaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dentistaToolStripMenuItem.Image = global::WfaSistemaConsultorio.Properties.Resources.dental62;
            this.dentistaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dentistaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.dentistaToolStripMenuItem.Name = "dentistaToolStripMenuItem";
            this.dentistaToolStripMenuItem.Size = new System.Drawing.Size(151, 48);
            this.dentistaToolStripMenuItem.Text = "Dentista";
            this.dentistaToolStripMenuItem.Click += new System.EventHandler(this.dentistaToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.pacienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pacienteToolStripMenuItem.Image = global::WfaSistemaConsultorio.Properties.Resources.dentist131;
            this.pacienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(151, 48);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultaToolStripMenuItem.Image = global::WfaSistemaConsultorio.Properties.Resources.note291;
            this.consultaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(151, 48);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.dentistasToolStripMenuItem1,
            this.pacientesToolStripMenuItem});
            this.agendaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(69, 31);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Image = global::WfaSistemaConsultorio.Properties.Resources.book2391;
            this.consultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // dentistasToolStripMenuItem1
            // 
            this.dentistasToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.dentistasToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.dentistasToolStripMenuItem1.Image = global::WfaSistemaConsultorio.Properties.Resources.notebook21;
            this.dentistasToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dentistasToolStripMenuItem1.Name = "dentistasToolStripMenuItem1";
            this.dentistasToolStripMenuItem1.Size = new System.Drawing.Size(159, 42);
            this.dentistasToolStripMenuItem1.Text = "Dentistas";
            this.dentistasToolStripMenuItem1.Click += new System.EventHandler(this.dentistasToolStripMenuItem1_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.pacientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pacientesToolStripMenuItem.Image = global::WfaSistemaConsultorio.Properties.Resources.address171;
            this.pacientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // suportToolStripMenuItem
            // 
            this.suportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportarProblemaToolStripMenuItem1});
            this.suportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.suportToolStripMenuItem.Name = "suportToolStripMenuItem";
            this.suportToolStripMenuItem.Size = new System.Drawing.Size(72, 31);
            this.suportToolStripMenuItem.Text = "Suporte";
            // 
            // reportarProblemaToolStripMenuItem1
            // 
            this.reportarProblemaToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.reportarProblemaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.reportarProblemaToolStripMenuItem1.Image = global::WfaSistemaConsultorio.Properties.Resources.settings481;
            this.reportarProblemaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportarProblemaToolStripMenuItem1.Name = "reportarProblemaToolStripMenuItem1";
            this.reportarProblemaToolStripMenuItem1.Size = new System.Drawing.Size(218, 38);
            this.reportarProblemaToolStripMenuItem1.Text = "Reportar Problema";
            this.reportarProblemaToolStripMenuItem1.Click += new System.EventHandler(this.reportarProblemaToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(904, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agenda de Hoje";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 608);
            this.Controls.Add(this.splitContainer6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Consultorio Odontológico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmPrincipal_Activated);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainerDaEsquerda.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDaEsquerda)).EndInit();
            this.splitContainerDaEsquerda.ResumeLayout(false);
            this.splitContainerDaAgenda.Panel1.ResumeLayout(false);
            this.splitContainerDaAgenda.Panel1.PerformLayout();
            this.splitContainerDaAgenda.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDaAgenda)).EndInit();
            this.splitContainerDaAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDia)).EndInit();
            this.splitContainerDaDireita.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDaDireita)).EndInit();
            this.splitContainerDaDireita.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainerDoLembrete.Panel1.ResumeLayout(false);
            this.splitContainerDoLembrete.Panel1.PerformLayout();
            this.splitContainerDoLembrete.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDoLembrete)).EndInit();
            this.splitContainerDoLembrete.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView dgvAgendaDia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dentistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dentistasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarProblemaToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cmbDentistaAgenda;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.SplitContainer splitContainerDaEsquerda;
        private System.Windows.Forms.SplitContainer splitContainerDaAgenda;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainerDaDireita;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaHora;
        private System.Windows.Forms.DataGridViewLinkColumn colunaPaciente;
        private System.Windows.Forms.DataGridViewImageColumn colunaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.Button btnAdicionarLembrete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainerDoLembrete;
        private System.Windows.Forms.Label label2;
    }
}

