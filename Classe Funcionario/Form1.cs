using Classe_Funcionario.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btm_Cadastrar_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            fun.salario = double.Parse(txb_Salário.Text);
            fun.email = txb_Email.Text;
            fun.idade = int.Parse(txb_Idade.Text);
            fun.setor = txb_Setor.Text;
            fun.Data = DateTime.Parse(txb_Data.Text);
            fun.nome = txb_Nome.Text;

            Form2 cadastro = new Form2(fun);
            cadastro.ShowDialog();
        }
        
    }
}
