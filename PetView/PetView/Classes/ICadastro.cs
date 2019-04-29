using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetView
{
    public interface ICadastroAnimal
    {
        IEnumerable<Animal> SelectAll();
        Animal SelectByID(string id);
        void Insert(Animal obj);
        void Update(Animal obj);
        void Delete(string id);
    }
    public interface ICadastro
    {
        IEnumerable<Animal> SelectAll();
        Animal SelectByID(string id);
        void Insert(Animal obj);
        void Update(Animal obj);
        void Delete(string id);
    }
}
