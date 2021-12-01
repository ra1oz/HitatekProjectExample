using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.DataAccess.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students {get;}

        Task<int> SaveAsync();
    }
}
