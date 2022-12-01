using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Projeto211375.Model
{
    public class Produto
    {
        public string descricao { get; set; }
        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT p.*, m.marca, c.categoria FROM Produtos p JOIN Marcas m ON (m.id = p.id_marca) JOIN Categorias c on (c.id = p.id_categoria) WHERE p.descricao like @descricao ORDER BY p.descricao", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);

                return Banco.datTabela;
            } catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, e.Message, MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
