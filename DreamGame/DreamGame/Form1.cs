using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DreamGame
{
    public partial class DreamGame : Form
    {
        public DreamGame()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            // Defina sua string de conexão com o banco 
            string conexaoString = "Server=localhost; Port=3306; Database=tb_jogos; Uid=root; Pwd=;";

            // Defina a inserção de registro no Bd
            string query = "INSERT INTO tb_jogos(Titulo, Avaliacao, Tamanho, Descricao, Valor, Desenvolvedor, Genero) VALUES " +
                "(@Titulo, @Avaliacao, @Tamanho, @Descricao, @Valor, @Desenvolvedor, @Genero)";

            // Crie conexao com o Bd
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexao
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //adicionar os parametros com os valores do TextBox
                        comando.Parameters.AddWithValue("@Titulo", textBoxTitulo.Text);
                        comando.Parameters.AddWithValue("@Avaliacao", comboBoxAvaliacao.Text);
                        comando.Parameters.AddWithValue("@Tamanho", textBoxTamanho.Text);
                        comando.Parameters.AddWithValue("@Descricao", richTextBox1.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Desenvolvedor", textBoxDesenvolvedor.Text);
                        comando.Parameters.AddWithValue("@Genero", comboBoxGenero.Text);

                        //Executeo comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        textBoxTitulo.Text = "";
                        comboBoxAvaliacao.Text = "";
                        textBoxTamanho.Text = "";
                        richTextBox1.Text = "";
                        maskedTextBoxValor.Text = "";
                        textBoxDesenvolvedor.Text = "";
                        comboBoxGenero.Text = "";
                        textBoxTitulo.Focus();
                    }

                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba a mensagem do erro 
                    MessageBox.Show("Erro: " + ex.Message);
                }



            }
        }
    }
    
}
