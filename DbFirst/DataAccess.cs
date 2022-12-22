using DbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFirst.Models;

namespace DbFirst
{
    public class DataAccess
    {
        DbFirstContext context;

        public DataAccess()
        {
            context = new DbFirstContext();
        }

        public void Update(int id, Employee employee)
        {
            var recordToUpdate = context.Employees.Find(id);

            recordToUpdate.FirstName = employee.FirstName;
            recordToUpdate.Age = employee.Age;
            context.SaveChanges();
        }
    }
}
