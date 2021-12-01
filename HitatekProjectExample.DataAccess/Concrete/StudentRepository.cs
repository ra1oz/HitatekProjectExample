using HitatekProjectExample.DataAccess.Abstract;
using HitatekProjectExample.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.DataAccess.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;
        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }
        public Student CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public void DeleteStudent(int id)
        {
            var deletedHotel = GetStudentById(id);
            _context.Students.Remove(deletedHotel);
            _context.SaveChanges();
        }

        public List<Student> GetAllHotels()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public Student UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            return student;
        }
    }
}
