using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Animal : ICadastro
    {
        public int CodigoAnimal { get; set; }
        public int RGA { get; set; }
        public String NomeAnimal { get; set; }
        public int IdadeAnimal { get; set; }
        public String Especie { get; set; }
        public String Raca { get; set; }
        public String Descricao { get; set; }

        public void Cadastrar() { }
    }
}
