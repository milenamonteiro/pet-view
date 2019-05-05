using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Exame : ICadastro
    {
        public int CodExame { get; set; }
        public Medico medico { get; set; }
        public Animal animal { get; set; }
        public String Observacao { get; set; }
        public double Custo { get; set; }
        public String TipoExame { get; set; }
        public DateTime DataExame { get; set; }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
