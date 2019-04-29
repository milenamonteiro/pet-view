using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Dono : ICadastro
    {
        public int CodigoDono { get; set; }
        public String NomeDono { get; set; }
        public char CPFDono { get; set; }
        public char RGDono { get; set; }
        public char CelDono { get; set; }
        public char TelDono { get; set; }
        public String EmailDono { get; set; }
        public Endereco endereco { get; set; }

        public Dono(int codigoDono, string nomeDono, char cPFDono, char rGDono, char celDono, char telDono, string emailDono, Endereco endereco)
        {
            CodigoDono = codigoDono;
            NomeDono = nomeDono;
            CPFDono = cPFDono;
            RGDono = rGDono;
            CelDono = celDono;
            TelDono = telDono;
            EmailDono = emailDono;
            this.endereco = endereco;
        }

        public void Cadastrar() { }
    }
}
