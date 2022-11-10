using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria
{
    class Bank
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string morada { get; set; }
        public string reciboVencimento { get; set; }
        public enum Genero
        {
            Feminino = 0, Masculino = 1, Outros = 2
        }

        public int Titular { get; set; }
        public float Saldo { get; set; }
    }
}
