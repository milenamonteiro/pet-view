using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Medico : ICadastro
    {
        public int CodigoMedico { get; set; }
        public String NomeMedico { get; set; }
        public char CRMVMedico { get; set; }
        public char CPFMedico { get; set; }
        public char RGMedico { get; set; }
        public char CelMedico { get; set; }
        public char TelMedico { get; set; }
        public String EmailMedico { get; set; }
        public String FuncaoMedico { get; set; }
        public Double SalarioMedico { get; set; }
        public Endereco endereco { get; set; }

        public void Cadastrar() { }
    }
}
