using HitatekProjectExample.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDbContext _context;
        private StudentRepository _studentRepository;
        public UnitOfWork(StudentDbContext context)
        {
            _context = context;
        }
        public IStudentRepository Students => _studentRepository ?? new StudentRepository(_context);

        public void Dispose()
        {
            _context.DisposeAsync();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
