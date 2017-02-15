using AutoMapper;
using WorkWithEF.Models;
using WorkWithEF.ViewModels;

namespace WorkWithEF.Mapping
{
    public class MappingProfile : Profile {
        public MappingProfile()
        {
            CreateMap<Task, TaskViewModel>();
            CreateMap<Bug, BugViewModel>();
        }
    }
}