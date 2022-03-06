using UnitTest.Models;
namespace UnitTest.Responsitory{
    public interface IPersonResponsitory{
        public List<Person> GetAll();
        
        public void Create(Person per);
        public void GetPersonByID(int id);
        public void Update(Person per);
        public void Delete(int id);
    }
}