using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto211375.Model
{
    public class VendaCab
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public DateTime data { get; set; }

        public double total { get; set; }

        public int Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO vendaCab (idCliente, data, total) VALUES(@idCliente, @data, @total)", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@idCliente", IdCliente);
                Banco.Comando.Parameters.AddWithValue("@data", data);
                Banco.Comando.Parameters.AddWithValue("@total", total);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
                return (int)Banco.Comando.LastInsertedId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}