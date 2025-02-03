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
using MySql.Data.MySqlClient;

namespace Sistema
{
    public partial class CadClientes : Form
    {
        public CadClientes()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;

            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF Válido";
                labelAlert.ForeColor = Color.Green;
            } 
            else
            {
                labelAlert.Text = "CPF Inválido";
                labelAlert.ForeColor= Color.DarkRed;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();
            }

            // Defina sua string de conexão com o bank
            string conexaoString = "Server=localhost; Port=3306; Database=db_sistema; Uid=root; Pwd=;";

            //Defina a insert de registro no DB

            string query = "INSERT INTO tb_clientes (NomeCompleto, Cpf, Email, Cep, Numero, Telefone) VALUES (@NomeCompleto, @Cpf, @Email, @Cep, @Numero, @Telefone)";

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
                        //Adicionar os parâmetros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@NomeCompleto", textBoxNome.Text);
                        comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@Cep", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@Numero", maskedTextBoxNum.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTel.Text);

                        // Executa o comando inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                    } 
                }
                catch(Exception ex)
                {
                    //em caso de erro, exiba mensagem do erro
                    MessageBox.Show("Erro: " + ex.Message);

                }


            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            maskedTextBoxCPF.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxNum.Text = "";
            maskedTextBoxTel.Text = "";
        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private bool ValidarCpf(string cpf)
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

        private void CadClientes_Load(object sender, EventArgs e)
        {

        }
    }
}