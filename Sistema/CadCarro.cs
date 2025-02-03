using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class CadCarro : Form
    {
        public CadCarro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxProp.Text = "";
            richTextBoxAcess.Text = "";
            textBoxChassi.Text = "";
            textBoxCor.Text = "";
            textBoxMarca.Text = "";
            textBoxModelo.Text = "";
            textBoxPlaca.Text = "";
            maskedTextBoxValor.Text = "";
            maskedTextBoxAno.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxTel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;

            if (ValidarCPF(cpf))
            {
                labelAlert.Text = "Carro Cadastrado";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {
                labelAlert.Text = "CPF Inválido";
                labelAlert.ForeColor = Color.DarkRed;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();
            }
            // Defina sua string de conexão com o bank
            string conexaoString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

            //Defina a insert de registro no DB

            string query = "INSERT INTO tb_produtos (Proprietario, Telefone, Cpf, Placa, Modelo, Ano, Chassi, Cor, Marca, Acessorios, Valor) VALUES (@Proprietario, @Telefone, @Cpf, @Placa, @Modelo, @Ano, @Chassi, @Cor, @Marca, @Acessorios, @Valor)";

            //Crie uma conexão com o DB

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();

                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Proprietario", textBoxProp.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTel.Text);
                        comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@Placa", textBoxPlaca.Text);
                        comando.Parameters.AddWithValue("@Modelo", textBoxModelo.Text);
                        comando.Parameters.AddWithValue("@Ano", maskedTextBoxAno.Text);
                        comando.Parameters.AddWithValue("@Chassi", textBoxChassi.Text);
                        comando.Parameters.AddWithValue("@Cor", textBoxCor.Text);
                        comando.Parameters.AddWithValue("@Marca", textBoxMarca.Text);
                        comando.Parameters.AddWithValue("@Acessorios", richTextBoxAcess.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);

                        // Executa o comando inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    //em caso de erro, exiba mensagem do erro
                    MessageBox.Show("Erro: " + ex.Message);

                }

            }

        }

        private bool ValidarCPF(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        }
    }
}
