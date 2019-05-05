using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public class Consulta : ICadastro
    {
        public int CodConsulta { get; set; }
        public Medico medico { get; set; }
        public Animal animal { get; set; }
        public String Sintomas { get; set; }
        public String Diagnostico { get; set; }
        public String Observacao { get; set; }
        public double Custo { get; set; }
        public String TipoConsulta { get; set; }
        public DateTime DataConsulta { get; set; }

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
