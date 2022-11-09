using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Funcionario.Classe
{
    public class Funcionario
    {
        public string nome;
        public string email;
        public int idade;
        public string setor;
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public double salario;

        public string CalcSalario(double sal)
        {
            double a = sal * 0.20;
            a = sal - a;
            Math.Round(a, 2);
            return a.ToString();
        }
    }
}
