namespace WfaSistemaConsultorio.Vizualizar
{
    partial class FrmVizualizarConsulta
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbApagar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblAvisoConsulta = new System.Windows.Forms.ToolStripStatusLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbObservacaoConsulta = new System.Windows.Forms.RichTextBox();
            this.btnConfirmarEditar = new System.Windows.Forms.Button();
            this.cmbDentista = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.txtHoraMarcadaConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtFimConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditar,
            this.tsbApagar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(506, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::WfaSistemaConsultorio.Properties.Resources.edit45;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(59, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbApagar
            // 
            this.tsbApagar.Image = global::WfaSistemaConsultorio.Properties.Resources.slightly;
            this.tsbApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApagar.Name = "tsbApagar";
            this.tsbApagar.Size = new System.Drawing.Size(66, 22);
            this.tsbApagar.Text = "Apagar";
            this.tsbApagar.Click += new System.EventHandler(this.tsbApagar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DimGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslblAvisoConsulta});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Aviso:";
            // 
            // tsslblAvisoConsulta
            // 
            this.tsslblAvisoConsulta.Name = "tsslblAvisoConsulta";
            this.tsslblAvisoConsulta.Size = new System.Drawing.Size(54, 17);
            this.tsslblAvisoConsulta.Text = "Nenhum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 53;
            this.label9.Text = "Paciente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "Observação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Fim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Hora Marcada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dentista:";
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConsulta.Location = new System.Drawing.Point(72, 43);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(18, 13);
            this.lblIdConsulta.TabIndex = 37;
            this.lblIdConsulta.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código:";
            // 
            // rtbObservacaoConsulta
            // 
            this.rtbObservacaoConsulta.Enabled = false;
            this.rtbObservacaoConsulta.Location = new System.Drawing.Point(104, 230);
            this.rtbObservacaoConsulta.Name = "rtbObservacaoConsulta";
            this.rtbObservacaoConsulta.Size = new System.Drawing.Size(342, 96);
            this.rtbObservacaoConsulta.TabIndex = 55;
            this.rtbObservacaoConsulta.Text = "";
            // 
            // btnConfirmarEditar
            // 
            this.btnConfirmarEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEditar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarEditar.Location = new System.Drawing.Point(206, 353);
            this.btnConfirmarEditar.Name = "btnConfirmarEditar";
            this.btnConfirmarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarEditar.TabIndex = 59;
            this.btnConfirmarEditar.Text = "Ok";
            this.btnConfirmarEditar.UseVisualStyleBackColor = false;
            this.btnConfirmarEditar.Visible = false;
            this.btnConfirmarEditar.Click += new System.EventHandler(this.btnConfirmarEditar_Click);
            // 
            // cmbDentista
            // 
            this.cmbDentista.Enabled = false;
            this.cmbDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDentista.FormattingEnabled = true;
            this.cmbDentista.Location = new System.Drawing.Point(83, 116);
            this.cmbDentista.Name = "cmbDentista";
            this.cmbDentista.Size = new System.Drawing.Size(227, 23);
            this.cmbDentista.TabIndex = 60;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.Enabled = false;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(86, 86);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(227, 21);
            this.cmbPaciente.TabIndex = 61;
            // 
            // txtHoraMarcadaConsulta
            // 
            this.txtHoraMarcadaConsulta.CustomFormat = "HH:mm";
            this.txtHoraMarcadaConsulta.Enabled = false;
            this.txtHoraMarcadaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHoraMarcadaConsulta.Location = new System.Drawing.Point(117, 170);
            this.txtHoraMarcadaConsulta.Name = "txtHoraMarcadaConsulta";
            this.txtHoraMarcadaConsulta.ShowUpDown = true;
            this.txtHoraMarcadaConsulta.Size = new System.Drawing.Size(74, 20);
            this.txtHoraMarcadaConsulta.TabIndex = 62;
            // 
            // txtInicioConsulta
            // 
            this.txtInicioConsulta.CustomFormat = "HH:mm";
            this.txtInicioConsulta.Enabled = false;
            this.txtInicioConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtInicioConsulta.Location = new System.Drawing.Point(65, 199);
            this.txtInicioConsulta.Name = "txtInicioConsulta";
            this.txtInicioConsulta.ShowUpDown = true;
            this.txtInicioConsulta.Size = new System.Drawing.Size(74, 20);
            this.txtInicioConsulta.TabIndex = 63;
            this.txtInicioConsulta.Value = new System.DateTime(2015, 2, 3, 0, 0, 0, 0);
            // 
            // txtFimConsulta
            // 
            this.txtFimConsulta.CustomFormat = "HH:mm";
            this.txtFimConsulta.Enabled = false;
            this.txtFimConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFimConsulta.Location = new System.Drawing.Point(236, 199);
            this.txtFimConsulta.Name = "txtFimConsulta";
            this.txtFimConsulta.ShowUpDown = true;
            this.txtFimConsulta.Size = new System.Drawing.Size(74, 20);
            this.txtFimConsulta.TabIndex = 64;
            this.txtFimConsulta.Value = new System.DateTime(2015, 2, 3, 0, 0, 0, 0);
            // 
            // txtDataConsulta
            // 
            this.txtDataConsulta.Enabled = false;
            this.txtDataConsulta.Location = new System.Drawing.Point(64, 145);
            this.txtDataConsulta.Name = "txtDataConsulta";
            this.txtDataConsulta.Size = new System.Drawing.Size(227, 20);
            this.txtDataConsulta.TabIndex = 65;
            // 
            // FrmVizualizarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 415);
            this.Controls.Add(this.txtDataConsulta);
            this.Controls.Add(this.txtFimConsulta);
            this.Controls.Add(this.txtInicioConsulta);
            this.Controls.Add(this.txtHoraMarcadaConsulta);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.cmbDentista);
            this.Controls.Add(this.btnConfirmarEditar);
            this.Controls.Add(this.rtbObservacaoConsulta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmVizualizarConsulta";
            this.Text = "Consulta";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbApagar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbObservacaoConsulta;
        private System.Windows.Forms.Button btnConfirmarEditar;
        private System.Windows.Forms.ComboBox cmbDentista;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblAvisoConsulta;
        private System.Windows.Forms.DateTimePicker txtHoraMarcadaConsulta;
        private System.Windows.Forms.DateTimePicker txtInicioConsulta;
        private System.Windows.Forms.DateTimePicker txtFimConsulta;
        private System.Windows.Forms.DateTimePicker txtDataConsulta;
    }
}