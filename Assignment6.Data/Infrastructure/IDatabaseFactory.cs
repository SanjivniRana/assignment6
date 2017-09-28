using Assignment6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        EmpContext Get();
    }
}
