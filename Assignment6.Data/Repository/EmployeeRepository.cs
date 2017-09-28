using Assignment6.Data.Entity_Models;
using Assignment6.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee1>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface IEmployeeRepository : IRepository<Employee1>
    {

    }
}
