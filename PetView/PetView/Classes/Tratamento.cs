using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Tratamento : ICadastro
    {
        public int CodTratamento { get; set; }
        public Medico medico { get; set; }
        public Animal animal { get; set; }
        public String Observacao { get; set; }
        public double Custo { get; set; }
        public String TipoTratamento { get; set; }
        public DateTime DataTratamento { get; set; }

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
