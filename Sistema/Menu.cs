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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadClientes form = new CadClientes();
            form.ShowDialog();
        }

        private void buttonCadastrarCarro_Click(object sender, EventArgs e)
        {
            CadCarro form = new CadCarro();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gereciamento_Clientes form = new Gereciamento_Clientes();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Gerenciamento_Carros form = new Gerenciamento_Carros();
            form.ShowDialog();
        }
    }
}
