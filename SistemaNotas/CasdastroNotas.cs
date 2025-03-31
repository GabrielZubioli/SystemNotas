using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace SistemaNotas
{
    internal class CadastroNotas
    {
        private int id;
        private string aluno;
        private string disciplina;
        private double valor;
        private DateTime dataLancamento;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }
        public string Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public DateTime DataLancamento
        {
            get { return dataLancamento; }
            set { dataLancamento = value; }
        }

        public bool cadastrarNotas()
        {
            try
            {
                using (MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    MysqlConexaoBanco.Open();

                    string insert = "INSERT INTO nota (aluno, disciplina, valor, dataLancamento) VALUES (@Aluno, @Disciplina, @Valor, @DataLancamento)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, MysqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@Aluno", Aluno);
                        comandoSql.Parameters.AddWithValue("@Disciplina", Disciplina);
                        comandoSql.Parameters.AddWithValue("@Valor", Valor);
                        comandoSql.Parameters.AddWithValue("@DataLancamento", DataLancamento.ToString("yyyy-MM-dd HH:mm:ss"));

                        comandoSql.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados -- método cadastrarNotas: " + ex.Message);
                return false;
            }
        }

        public MySqlDataReader localizarNota()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id, aluno, disciplina, valor, dataLancamento from nota where id = '{id}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao bucar dados - metodo localizarNota: " + ex.Message);
                return null;
            }
        }

        public bool atualizarNota()
        {
            try
            {
                string query = "UPDATE nota SET aluno = @Aluno, disciplina = @Disciplina, valor = @Valor, dataLancamento = @DataLancamento WHERE id = @Id";

                using (MySqlConnection conn = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", this.Id);
                        cmd.Parameters.AddWithValue("@Aluno", this.Aluno);
                        cmd.Parameters.AddWithValue("@Disciplina", this.Disciplina);
                        cmd.Parameters.AddWithValue("@Valor", this.Valor);
                        cmd.Parameters.AddWithValue("@DataLancamento", this.DataLancamento);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar nota: " + ex.Message);
                return false;
            }

        }

        public bool deletarNota()
        {
            try
            {
                string query = "DELETE FROM Nota WHERE id = @Id";

                using (MySqlConnection conn = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", this.Id);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar nota: " + ex.Message);
                return false;
            }
        }
        public DataTable ListarTodasNotas()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    conn.Open();
                    string query = "SELECT id, aluno, disciplina, valor, dataLancamento FROM nota";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar notas: " + ex.Message);
            }
            return dt;
        }

    }

}
