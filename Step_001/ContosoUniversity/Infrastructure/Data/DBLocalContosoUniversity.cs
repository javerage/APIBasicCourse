using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Domain.Entities;
using System.Text.Json;

namespace ContosoUniversity.Infrastructure.Data
{
    public class DBLocalContosoUniversity
    {
        private const string _fileName = "dbContosoUniversity.json";
        private const string _dataPath = "Infrastructure\\Data";
        private List<Person> _persons;

        public DBLocalContosoUniversity()
        {
            _persons = new List<Person>();
            LoadData();
        }

        private void LoadData(){
            var filePath = Path.Combine(Environment.CurrentDirectory, _dataPath, _fileName);

            if(File.Exists(filePath)){
                var jsonString = File.ReadAllText(filePath);
                _persons = JsonSerializer.Deserialize<List<Person>>(jsonString)!;
            }
        }

        public IEnumerable<Person> Persons => _persons;
    }
}