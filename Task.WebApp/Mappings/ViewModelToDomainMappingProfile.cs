using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Task.Domain.Entities;
using Task.WebApp.ViewModels;

namespace Task.WebApp.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public new string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<TaskFormViewModel, TaskToDo>()
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.TaskDescription))
                .ForMember(g => g.CreatingDate, map => map.MapFrom(vm => vm.TaskCreatingDate))
                .ForMember(g => g.RealizationDate, map => map.MapFrom(vm => vm.TaskRealizationDate))
                .ForMember(g => g.RealizationState, map => map.MapFrom(vm => vm.TaskRealizationState));
        }
    }
}