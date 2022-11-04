using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Domain.Entities;
using ContosoUniversity.Infrastructure.Data;

namespace ContosoUniversity.Infrastructure.Repositories
{
    public class PersonRepository
    {
        private DBLocalContosoUniversity _dbContext;

        public PersonRepository()
        {
            _dbContext = new DBLocalContosoUniversity();
        }

        /// <summary>
        /// return all elements
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Person> Get(){
            return _dbContext.Persons;
        }

        public Person Get(int id){
            //return _dbContext.Persons.Single(x => x.Id == id);
            //return _dbContext.Persons.FirstOrDefault(x => x.Id == id)!;
            return _dbContext.Persons.FirstOrDefault(x => x.Id == id) 
                    ?? new Person();
        }

        public IEnumerable<Person> Get(Person p){
            var query = _dbContext.Persons;

            if(!string.IsNullOrEmpty(p.FirstName))
                query = query.Where(x => x.FirstName.Contains(p.FirstName));

            if(!string.IsNullOrEmpty(p.LastName))
                query = query.Where(x => x.LastName.Contains(p.LastName));

            if(!string.IsNullOrEmpty(p.Address))
                query = query.Where(x => x.Address != null && x.Address.Contains(p.Address));

            if(p.EnrollmentDate.HasValue)
                query = query.Where(x => x.EnrollmentDate == p.EnrollmentDate.Value);
                
            if(p.HasParkingLot.HasValue)
                query = query.Where(x => x.HasParkingLot == p.HasParkingLot.Value);
            
            return query;
        }
    }
}