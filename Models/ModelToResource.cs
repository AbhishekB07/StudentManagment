using AutoMapper;
using DuckTaleSolutionTask.Models.Entities;
using DuckTaleSolutionTask.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckTaleSolutionTask.Models
{

    public class ModelToResource : Profile
    {
        public ModelToResource()
        {
            CreateMap<Student, StudentViewModel>()
                 .ForMember(svm => svm.Id, opt => opt.MapFrom(st => st.Id))
            .ForMember(svm => svm.FirstName, opt => opt.MapFrom(st => st.FirstName))
            .ForMember(svm => svm.LastName, opt => opt.MapFrom(st => st.LastName))
            .ForMember(svm => svm.Class, opt => opt.MapFrom(st => st.Class))
            .ForMember(svm => svm.Subjects, opt => opt.MapFrom(st => st.Subjects));

            

        }

    }

}
