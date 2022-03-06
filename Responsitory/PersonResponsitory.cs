using UnitTest.Models;
namespace UnitTest.Responsitory
{
    public class PersonResponsitory : IPersonResponsitory
    {
        private PersonDbContext _dbContext;
        public PersonResponsitory(PersonDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       public List<Person> GetAll(){
           return _dbContext.Persons.ToList();
       }
       public void Create(Person per){
           _dbContext.Persons.Add(per);
           _dbContext.SaveChanges();
       }
       public void GetPersonByID(int id){
           var person = _dbContext.Persons.Where(x=>x.StudentID==id).FirstOrDefault();
       }
       
       public void Update(Person per){
           var perUpdate = _dbContext.Persons.Where(x=>x.StudentID == per.StudentID).FirstOrDefault();
           perUpdate.StudentName = per.StudentName;
           perUpdate.Age = per.Age;
           perUpdate.Address = per.Address;
           _dbContext.SaveChanges();
       }
       public void Delete(int id){
           var perDelete = _dbContext.Persons.Where(x=>x.StudentID == id).FirstOrDefault();
           _dbContext.Persons.Remove(perDelete);
           _dbContext.SaveChanges();
       }
    }
}