using AutoMapper;
using HitatekProjectExample.Business.Abstract;
using HitatekProjectExample.DataAccess.Abstract;
using HitatekProjectExample.DataAccess.Concrete;
using HitatekProjectExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public StudentManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Student CreateStudent(Student student)
        {
            var _student = _mapper.Map<Student>(student);
            _student.Id = student.Id;
            _student.Adi = student.Adi;
            _student.Soyadi = student.Soyadi;
            _student.NotOrtalamasi = student.NotOrtalamasi;
            return _unitOfWork.Students.CreateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _unitOfWork.Students.DeleteStudent(id);
        }

        public List<Student> GetAllStudents()
        {
            return _unitOfWork.Students.GetAllHotels();
        }

        public Student GetStudentById(int id)
        {
            if (id > 0)
            {
                return _unitOfWork.Students.GetStudentById(id);
            }
            throw new Exception("");
        }

        public Student UpdateStudent(Student student)
        {
            return _unitOfWork.Students.UpdateStudent(student);
        }
    }
}
