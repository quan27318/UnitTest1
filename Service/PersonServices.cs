using UnitTest.Models;
using UnitTest.Responsitory;
namespace UnitTest.Service{
    public class PersonServices : IPerson{
        private readonly IPersonResponsitory _responsitory;
        public PersonServices(IPersonResponsitory responsitory)
        {
            _responsitory = responsitory;
        }
        public List<Person> GetAll(){
            return _responsitory.GetAll();
        }
        public void Create(Person per){
            _responsitory.Create(per);
        }
        public void GetPersonByID(int id){
            
             _responsitory.GetPersonByID(id);
        }
       
        public void Update(Person per){
            _responsitory.Update(per);
        }
        public void Delete(int id){
            _responsitory.Delete(id);
        }
    }
}