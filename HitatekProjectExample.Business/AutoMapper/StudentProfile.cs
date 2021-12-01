using AutoMapper;
using HitatekProjectExample.Entities;
using HitatekProjectExample.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.Business.AutoMapper
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentAddDto, Student>();
        }
    }
}
