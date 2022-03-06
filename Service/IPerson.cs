using UnitTest.Models;
using UnitTest.Responsitory;
namespace UnitTest.Service{
    public interface IPerson{
        public List<Person> GetAll();
        public void Create(Person per);
        
        public void GetPersonByID(int id);
        public void Update(Person per);
        public void Delete(int id);
    }
}