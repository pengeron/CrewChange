using AutoMapper;
using CrewChange.Domain.Entities;

namespace CrewChange.Application.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Employee, EmployeeDto>();
        CreateMap<CreateEmployeeDto, Employee>();
        CreateMap<UpdateEmployeeDto, Employee>();
        
        CreateMap<Employee, EmployeeListDto>()
            .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title))
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location.Name))
            .ForMember(dest => dest.EmployeeStatus, opt => opt.MapFrom(src => src.EmployeeStatus.Name));

        CreateMap<EmployeeCertification, EmployeeCertificationDto>();
        CreateMap<CreateEmployeeCertificationDto, EmployeeCertification>();

        // Reference entities
        CreateMap<State, BaseDto>();
        CreateMap<MaritalStatus, BaseDto>();
        CreateMap<EmployeeStatus, BaseReferenceDto>();
        CreateMap<EmployeeGroup, BaseDto>();
        CreateMap<EducationLevel, BaseReferenceDto>();
        CreateMap<WorkStatus, BaseReferenceDto>();
        CreateMap<Location, BaseDto>();
        CreateMap<Job, BaseDto>();
        CreateMap<EmployeeScheduleType, BaseDto>();
        CreateMap<GenderType, BaseDto>();
        CreateMap<NationalityType, BaseDto>();
        CreateMap<VeteranStatusType, BaseReferenceDto>();
        CreateMap<TerminationReason, BaseReferenceDto>();
    }
}
