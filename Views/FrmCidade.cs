using Projeto211375.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto211375.Views
{
    public partial class FrmCidade : Form
    {
        Cidade c;
        public FrmCidade()
        {
            InitializeComponent();
        }

        void LimpaControles()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
        }

        void CarregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };

            dgvCidades.DataSource = c.Consultar();
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            c = new Cidade()
            {
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.Incluir();

            LimpaControles();
            CarregarGrid("");
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                txtID.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            c = new Cidade()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text,
                uf = txtUF.Text
            };

            c.Alterar();

            LimpaControles();

            CarregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    id = int.Parse(txtID.Text)
                };

                c.Excluir();

                LimpaControles();

                CarregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControles();

            CarregarGrid("");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid(txtPesquisa.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
