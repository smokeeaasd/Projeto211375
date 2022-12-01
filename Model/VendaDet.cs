using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto211375.Model
{
    public class VendaDet
    {
        public int Id { get; set; }

        public int IdVendaCab { get; set; }

        public int IdProduto { get; set; }

        public double Qtde { get; set; }

        public double ValorUnitario { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO vendaDet(id_venda_cab, id_produto, qtde, valor_unitario) VALUES(@idVendaCab, @idProduto, @qtde, @valorUnitario)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@idVendaCab", IdVendaCab);
                Banco.Comando.Parameters.AddWithValue("@idProduto", IdProduto);
                Banco.Comando.Parameters.AddWithValue("@qtde", Qtde);
                Banco.Comando.Parameters.AddWithValue("@valorUnitario", ValorUnitario);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, e.Message, MessageBoxButtons.OK);
            }
        }
    }
}
