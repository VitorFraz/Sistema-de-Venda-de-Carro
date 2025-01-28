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
