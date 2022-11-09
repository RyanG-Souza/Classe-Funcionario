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
    public partial class Form2 : Form
    {
        Classe.Funcionario f = new Classe.Funcionario();
        public Form2(Classe.Funcionario f)
        {
            InitializeComponent();
            txb_DataM.Text = f.Data.ToString("MM:dd:yyyy");
            txb_EmailM.Text = f.email;
            txb_IdadeM.Text = f.idade.ToString();
            txb_NomeM.Text = f.nome;
            txb_SalárioM.Text = f.salario.ToString();
            txb_SetorM.Text =f.setor;
            this.f = f;
        }

        private void btm_SalarioBruto_Click(object sender, EventArgs e)
        {
           
            txb_salB.Text = "Seu salário é de: "+f.CalcSalario(f.salario);
        }
    }
}
