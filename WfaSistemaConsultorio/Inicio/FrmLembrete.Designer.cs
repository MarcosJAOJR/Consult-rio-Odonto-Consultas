namespace WfaSistemaConsultorio.Inicio
{
    partial class FrmLembrete
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnLaranja = new System.Windows.Forms.Button();
            this.btnRoxo = new System.Windows.Forms.Button();
            this.btnRoseo = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnAdicionarLembrete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(-1, 49);
            this.richTextBox1.MaxLength = 144;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 213);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.GreenYellow;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerde.Location = new System.Drawing.Point(162, 13);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(24, 24);
            this.btnVerde.TabIndex = 1;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnLaranja
            // 
            this.btnLaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLaranja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaranja.Location = new System.Drawing.Point(192, 13);
            this.btnLaranja.Name = "btnLaranja";
            this.btnLaranja.Size = new System.Drawing.Size(24, 24);
            this.btnLaranja.TabIndex = 2;
            this.btnLaranja.UseVisualStyleBackColor = false;
            this.btnLaranja.Click += new System.EventHandler(this.btnLaranja_Click);
            // 
            // btnRoxo
            // 
            this.btnRoxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoxo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoxo.Location = new System.Drawing.Point(222, 13);
            this.btnRoxo.Name = "btnRoxo";
            this.btnRoxo.Size = new System.Drawing.Size(24, 24);
            this.btnRoxo.TabIndex = 3;
            this.btnRoxo.UseVisualStyleBackColor = false;
            this.btnRoxo.Click += new System.EventHandler(this.btnRoxo_Click);
            // 
            // btnRoseo
            // 
            this.btnRoseo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoseo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoseo.Location = new System.Drawing.Point(252, 13);
            this.btnRoseo.Name = "btnRoseo";
            this.btnRoseo.Size = new System.Drawing.Size(24, 24);
            this.btnRoseo.TabIndex = 4;
            this.btnRoseo.UseVisualStyleBackColor = false;
            this.btnRoseo.Click += new System.EventHandler(this.btnRoseo_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAmarelo.Location = new System.Drawing.Point(132, 13);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(24, 24);
            this.btnAmarelo.TabIndex = 5;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnAdicionarLembrete
            // 
            this.btnAdicionarLembrete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarLembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLembrete.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarLembrete.Location = new System.Drawing.Point(12, 14);
            this.btnAdicionarLembrete.Name = "btnAdicionarLembrete";
            this.btnAdicionarLembrete.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarLembrete.TabIndex = 6;
            this.btnAdicionarLembrete.Text = "Adicionar";
            this.btnAdicionarLembrete.UseVisualStyleBackColor = false;
            this.btnAdicionarLembrete.Click += new System.EventHandler(this.btnAdicionarLembrete_Click);
            // 
            // FrmLembrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAdicionarLembrete);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnRoseo);
            this.Controls.Add(this.btnRoxo);
            this.Controls.Add(this.btnLaranja);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.richTextBox1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmLembrete";
            this.Text = "Novo Lembrete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnLaranja;
        private System.Windows.Forms.Button btnRoxo;
        private System.Windows.Forms.Button btnRoseo;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnAdicionarLembrete;
    }
}