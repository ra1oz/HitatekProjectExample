using HitatekProjectExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.DataAccess.Abstract
{
    public interface IStudentRepository
    {
        List<Student> GetAllHotels();
        Student GetStudentById(int id);
        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
