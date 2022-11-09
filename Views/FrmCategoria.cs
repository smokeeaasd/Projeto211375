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
    public partial class FrmCategoria : Form
    {
        Categoria c;
        public FrmCategoria()
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
            c = new Categoria()
            {
                nome = pesquisa
            };

            dgvCategorias.DataSource = c.Consultar();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            LimpaControles();
            CarregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty) return;

            c = new Categoria()
            {
                nome = txtNome.Text,
            };
            c.Incluir();

            LimpaControles();
            CarregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            c = new Categoria()
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text,
            };

            c.Alterar();

            LimpaControles();

            CarregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty) return;

            if (MessageBox.Show("Deseja excluir a Categoria?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Categoria()
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

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                txtID.Text = dgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCategorias.CurrentRow.Cells["nome"].Value.ToString();
            }
        }
    }
}
