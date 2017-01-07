using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Task.Domain.Entities;
using Task.WebApp.ViewModels;

namespace Task.WebApp.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public new string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<TaskToDo, MainViewModel>();
            Mapper.CreateMap<TaskToDo, TaskViewModel>();
            Mapper.CreateMap<MainViewModel, TaskViewModel>();
        }
    }
}