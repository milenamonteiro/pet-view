using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Funcionario : ICadastro
    {
        public int CodigoFunc { get; set; }
        public String NomeFunc { get; set; }
        public char CRMVFunc { get; set; }
        public char CPFFunc { get; set; }
        public char RGFunc { get; set; }
        public char CelFunc { get; set; }
        public char TelFunc { get; set; }
        public String EmailFunc { get; set; }
        public String FuncaoFunc { get; set; }
        public Double SalarioFunc { get; set; }
        public Endereco endereco { get; set; }

        public void Cadastrar() { }
    }
}
