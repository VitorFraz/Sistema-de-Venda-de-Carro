using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Gerenciamento_Carros : Form
    {
        public Gerenciamento_Carros()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvCarros.SelectedRows.Count > 0)
            {
                // Pega ID do cliente da linha selecionada
                int carroID = Convert.ToInt32(dgvCarros.SelectedRows[0].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse veiculo? (esse processo é irreversível)", "Confimar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Defina sua string de conexão com o bank
                    string connectionString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados Mysql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes
                            string listagem = "DELETE FROM tb_produtos WHERE Id = @Id";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Veiculo excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o veiculo");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor, selecione um veiculo para excluir");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Defina sua string de conexão com o bank
            string connectionString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados Mysql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão
                    consulta.Open();

                    //Consulta SQL para selecionar os clientes
                    string listagem = "SELECT Id, Proprietario, Telefone, Cpf, Placa, Valor FROM tb_produtos";

                    //Cria o comando Mysql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosCarros = new DataTable();
                        dadosCarros.Load(reader);

                        //Atribui a tabela
                        dgvCarros.DataSource = dadosCarros;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }
        }
    }
}
