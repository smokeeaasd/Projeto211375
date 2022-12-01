namespace Projeto211375.Views
{
    partial class FrmCliente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCidades = new System.Windows.Forms.ComboBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(15, 311);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(120, 38);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(141, 311);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 38);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(267, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 38);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(393, 311);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 38);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(519, 311);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 38);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(15, 378);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(624, 20);
            this.txtPesquisa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite o nome do Cliente para pesquisa:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(645, 378);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(15, 404);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(705, 337);
            this.dgvClientes.TabIndex = 14;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(10, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(141, 27);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(115, 17);
            this.chkVenda.TabIndex = 15;
            this.chkVenda.Text = "Bloqueia a venda?";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cidade";
            // 
            // cboCidades
            // 
            this.cboCidades.FormattingEnabled = true;
            this.cboCidades.Location = new System.Drawing.Point(10, 124);
            this.cboCidades.Name = "cboCidades";
            this.cboCidades.Size = new System.Drawing.Size(121, 21);
            this.cboCidades.TabIndex = 17;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(161, 125);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 20);
            this.txtUF.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "UF:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(12, 179);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "CPF";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(12, 222);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNasc.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Data de Nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Renda:";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(10, 269);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(100, 20);
            this.txtRenda.TabIndex = 25;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(570, 9);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(150, 150);
            this.picFoto.TabIndex = 27;
            this.picFoto.TabStop = false;
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 753);
            this.ControlBox = false;
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.cboCidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCidades;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}