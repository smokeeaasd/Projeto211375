using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projeto211375.Model
{
    public class Cliente
    {
        public int id { get; set; }

        public string nome { get; set; }

        public int id_cidade { get; set; }
        
        public DateTime data_nasc { get; set; }

        public double renda { get; set; }

        public string cpf { get; set; }

        public string foto { get; set; }

        public bool venda { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO Clientes (nome, id_cidade, data_nasc, renda, cpf, foto, venda) VALUES(@nome, @id_cidade, @data_nasc, @renda, @cpf, @foto, @venda)", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                Banco.Comando.Parameters.AddWithValue("@data_nasc", data_nasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("UPDATE Clientes SET nome = @nome, id_cidade = @id_cidade, data_nasc = @data_nasc, renda = @renda, cpf = @cpf, foto = @foto, venda = @venda WHERE id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@id_cidade", id_cidade);
                Banco.Comando.Parameters.AddWithValue("@data_nasc", data_nasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("DELETE FROM Clientes WHERE id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand(
                    @"SELECT cl.*, ci.nome, ci.nome cidade FROM Clientes cl
                    JOIN Cidades ci on (ci.id = cl.id_cidade)
                    WHERE cl.nome like ?Nome ORDER BY cl.nome", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");

                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);

                Banco.datTabela = new DataTable();

                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();

                return Banco.datTabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
