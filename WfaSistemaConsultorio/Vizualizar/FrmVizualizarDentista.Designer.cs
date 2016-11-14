namespace WfaSistemaConsultorio.Vizualizar
{
    partial class FrmVizualizarDentista
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
            this.tsslblAvisoDentista = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCRODentista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailDentista = new System.Windows.Forms.TextBox();
            this.txtNomeDentista = new System.Windows.Forms.TextBox();
            this.lblIdDentista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelularDentista = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneDentista = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmarEditar = new System.Windows.Forms.Button();
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
            this.toolStrip1.Size = new System.Drawing.Size(501, 25);
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
            this.tsslblAvisoDentista});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(501, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Aviso:";
            // 
            // tsslblAvisoDentista
            // 
            this.tsslblAvisoDentista.Name = "tsslblAvisoDentista";
            this.tsslblAvisoDentista.Size = new System.Drawing.Size(54, 17);
            this.tsslblAvisoDentista.Text = "Nenhum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "CRO:";
            // 
            // txtCRODentista
            // 
            this.txtCRODentista.Enabled = false;
            this.txtCRODentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRODentista.Location = new System.Drawing.Point(51, 197);
            this.txtCRODentista.Name = "txtCRODentista";
            this.txtCRODentista.Size = new System.Drawing.Size(201, 21);
            this.txtCRODentista.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "E-mail:";
            // 
            // txtEmailDentista
            // 
            this.txtEmailDentista.Enabled = false;
            this.txtEmailDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailDentista.Location = new System.Drawing.Point(67, 111);
            this.txtEmailDentista.Name = "txtEmailDentista";
            this.txtEmailDentista.Size = new System.Drawing.Size(297, 21);
            this.txtEmailDentista.TabIndex = 39;
            // 
            // txtNomeDentista
            // 
            this.txtNomeDentista.Enabled = false;
            this.txtNomeDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDentista.Location = new System.Drawing.Point(13, 73);
            this.txtNomeDentista.Name = "txtNomeDentista";
            this.txtNomeDentista.Size = new System.Drawing.Size(476, 24);
            this.txtNomeDentista.TabIndex = 38;
            // 
            // lblIdDentista
            // 
            this.lblIdDentista.AutoSize = true;
            this.lblIdDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDentista.Location = new System.Drawing.Point(64, 40);
            this.lblIdDentista.Name = "lblIdDentista";
            this.lblIdDentista.Size = new System.Drawing.Size(18, 13);
            this.lblIdDentista.TabIndex = 37;
            this.lblIdDentista.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código:";
            // 
            // txtCelularDentista
            // 
            this.txtCelularDentista.Enabled = false;
            this.txtCelularDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularDentista.Location = new System.Drawing.Point(69, 167);
            this.txtCelularDentista.Mask = "(00) 0000-0000";
            this.txtCelularDentista.Name = "txtCelularDentista";
            this.txtCelularDentista.Size = new System.Drawing.Size(140, 21);
            this.txtCelularDentista.TabIndex = 47;
            this.txtCelularDentista.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneDentista
            // 
            this.txtTelefoneDentista.Enabled = false;
            this.txtTelefoneDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneDentista.Location = new System.Drawing.Point(78, 141);
            this.txtTelefoneDentista.Mask = "(00) 0000-0000";
            this.txtTelefoneDentista.Name = "txtTelefoneDentista";
            this.txtTelefoneDentista.Size = new System.Drawing.Size(140, 21);
            this.txtTelefoneDentista.TabIndex = 48;
            this.txtTelefoneDentista.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnConfirmarEditar
            // 
            this.btnConfirmarEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirmarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarEditar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarEditar.Location = new System.Drawing.Point(194, 248);
            this.btnConfirmarEditar.Name = "btnConfirmarEditar";
            this.btnConfirmarEditar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarEditar.TabIndex = 49;
            this.btnConfirmarEditar.Text = "Ok";
            this.btnConfirmarEditar.UseVisualStyleBackColor = false;
            this.btnConfirmarEditar.Visible = false;
            this.btnConfirmarEditar.Click += new System.EventHandler(this.btnConfirmarEditar_Click);
            // 
            // FrmVizualizarDentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 315);
            this.Controls.Add(this.btnConfirmarEditar);
            this.Controls.Add(this.txtTelefoneDentista);
            this.Controls.Add(this.txtCelularDentista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCRODentista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailDentista);
            this.Controls.Add(this.txtNomeDentista);
            this.Controls.Add(this.lblIdDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmVizualizarDentista";
            this.Text = "Dentista";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCRODentista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailDentista;
        private System.Windows.Forms.TextBox txtNomeDentista;
        private System.Windows.Forms.Label lblIdDentista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCelularDentista;
        private System.Windows.Forms.MaskedTextBox txtTelefoneDentista;
        private System.Windows.Forms.Button btnConfirmarEditar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblAvisoDentista;
    }
}