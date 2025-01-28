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
    public partial class Form1 : Form
    {
        bool VerSenhaTxt = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_usuario.Text = "";
            textBox_Senha.Text = "";
            textBox_usuario.Focus();
        }

        private void button_mostrarSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBox_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                button_mostrarSenha.Text = "Ocultar Senha";
            }
            else 
            {
                textBox_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                button_mostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string senha = textBox_Senha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMenssagem.Text = "Acesso Confirmado";
                labelMenssagem.ForeColor = Color.Green;
                Menu form = new Menu();
                form.ShowDialog();
            }
            else 
            {
                labelMenssagem.Text = "Acesso Negado";
                labelMenssagem.ForeColor = Color.Red;
                textBox_usuario.Text = "";
                textBox_Senha.Text = "";
                textBox_usuario.Focus();
            }
        }
    }
}
