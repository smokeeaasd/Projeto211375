using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Projeto211375
{
    public class Banco
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

            try
            {
                Conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas;", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTE Cidades ();
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    nome varchar(48),
                    uf char(02)", Conexao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
