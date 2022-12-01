using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;

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
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
            
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
                    @"CREATE TABLE IF NOT EXISTS Cidades (
                        id INT AUTO_INCREMENT,
                        nome VARCHAR(48),
                        uf CHAR(02),
                        PRIMARY KEY (id)
                    );", Conexao);

                Comando.ExecuteNonQuery();

                // Marca
                Comando = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTS Marca (
                        id INT AUTO_INCREMENT,
                        nome VARCHAR(48),
                        PRIMARY KEY (id)
                    );", Conexao);

                Comando.ExecuteNonQuery();

                //Categoria
                Comando = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTS Categoria (
                        id INT AUTO_INCREMENT,
                        nome VARCHAR(48),
                        PRIMARY KEY (id)
                    );", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTS Clientes (
                        id INT AUTO_INCREMENT,
                        nome VARCHAR(40),
                        id_cidade INT,
                        data_nasc DATE,
                        renda DECIMAL(10, 2),
                        cpf CHAR(14),
                        foto VARCHAR(100),
                        venda BOOLEAN,
                        FOREIGN KEY (id_cidade) REFERENCES Cidades(id),
                        PRIMARY KEY (id)
                    );", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTS VendaCab (
                        id INT AUTO_INCREMENT,
                        id_cliente INT,
                        data DATE,
                        total DECIMAL(10, 2),
                        PRIMARY KEY (id)
                    );", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTS VendaDet (
                        id INT AUTO_INCREMENT,
                        id_venda_cab INT,
                        id_produto INT,
                        qtde DECIMAL(10, 3),
                        valor_unitario DECIMAL(10, 2),
                        PRIMARY KEY (id)
                    );", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand(
                    @"CREATE TABLE IF NOT EXISTS Produtos (
                        id INT AUTO_INCREMENT,
                        descricao VARCHAR(40),
                        id_categoria INT,
                        id_marca INT,
                        estoque DECIMAL(10, 3),
                        valor_venda DECIMAL(10, 2),
                        foto VARCHAR(100),      
                        PRIMARY KEY (id)
                    );", Conexao);

                Comando.ExecuteNonQuery();

                FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
