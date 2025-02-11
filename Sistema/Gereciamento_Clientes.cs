using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema
{
    public partial class Gereciamento_Clientes : Form
    {
        public Gereciamento_Clientes()
        {
            InitializeComponent();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
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
                    string listagem = "SELECT Id_Cliente, NomeCompleto, Telefone FROM tb_clientes";

                    //Cria o comando Mysql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtem os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela
                        dgvClientes.DataSource = dadosClientes;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Pega ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id_Cliente"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse cliente? (esse processo é irreversível)", "Confimar Exclusão", MessageBoxButtons.YesNo);

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
                            string listagem = "DELETE FROM tb_clientes WHERE Id_Cliente = @Id_Cliente";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_Cliente", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente");
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
                    MessageBox.Show("Por Favor, selecione um cliente para excluir");
                }
            }
        }
    }
}
