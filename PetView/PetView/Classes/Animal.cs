using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Animal : ICadastro<Animal>
    {
        public int CodigoAnimal { get; set; }
        public int RGA { get; set; }
        public String NomeAnimal { get; set; }
        public int IdadeAnimal { get; set; }
        public String Especie { get; set; }
        public String Raca { get; set; }
        public String Descricao { get; set; }
        public Dono dono { get; set; }

        public Animal() { }

        public Animal(int codigoAnimal, int rGA, string nomeAnimal, int idadeAnimal, string especie, string raca, string descricao, Dono dono)
        {
            CodigoAnimal = codigoAnimal;
            RGA = rGA;
            NomeAnimal = nomeAnimal;
            IdadeAnimal = idadeAnimal;
            Especie = especie;
            Raca = raca;
            Descricao = descricao;
            this.dono = dono;
        }

        public void Insert<C>() { }
        public void Update<C>() { }
        public void Delete<C>() { }
    }
}
