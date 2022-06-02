using AutoMapper;
using Practical_17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<StudentContext, Student>().ReverseMap();
        }
    }
}
