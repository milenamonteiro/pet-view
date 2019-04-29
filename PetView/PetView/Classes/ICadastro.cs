using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public interface ICadastro<C>
    {
        //IEnumerable<Animal> SelectAll();
        //Animal SelectByID(string id);
        void Insert<C>();
        void Update<C>();
        void Delete<C>();
    }
}
