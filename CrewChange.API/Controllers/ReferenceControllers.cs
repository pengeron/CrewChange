using CrewChange.Domain.Entities;
using CrewChange.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace CrewChange.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatesController : ReferenceControllerBase<State>
{
    public StatesController(ApplicationDbContext context) : base(context, "State") { }
}

[ApiController]
[Route("api/[controller]")]
public class MaritalStatusesController : ReferenceControllerBase<MaritalStatus>
{
    public MaritalStatusesController(ApplicationDbContext context) : base(context, "MaritalStatus") { }
}

[ApiController]
[Route("api/[controller]")]
public class EmployeeStatusesController : ReferenceControllerBase<EmployeeStatus>
{
    public EmployeeStatusesController(ApplicationDbContext context) : base(context, "EmployeeStatus") { }
}

[ApiController]
[Route("api/[controller]")]
public class EmployeeGroupsController : ReferenceControllerBase<EmployeeGroup>
{
    public EmployeeGroupsController(ApplicationDbContext context) : base(context, "EmployeeGroup") { }
}

[ApiController]
[Route("api/[controller]")]
public class EducationLevelsController : ReferenceControllerBase<EducationLevel>
{
    public EducationLevelsController(ApplicationDbContext context) : base(context, "EducationLevel") { }
}

[ApiController]
[Route("api/[controller]")]
public class WorkStatusesController : ReferenceControllerBase<WorkStatus>
{
    public WorkStatusesController(ApplicationDbContext context) : base(context, "WorkStatus") { }
}

[ApiController]
[Route("api/[controller]")]
public class LocationsController : ReferenceControllerBase<Location>
{
    public LocationsController(ApplicationDbContext context) : base(context, "Location") { }
}

[ApiController]
[Route("api/[controller]")]
public class JobsController : ReferenceControllerBase<Job>
{
    public JobsController(ApplicationDbContext context) : base(context, "Job") { }
}

[ApiController]
[Route("api/[controller]")]
public class EmployeeScheduleTypesController : ReferenceControllerBase<EmployeeScheduleType>
{
    public EmployeeScheduleTypesController(ApplicationDbContext context) : base(context, "EmployeeScheduleType") { }
}

[ApiController]
[Route("api/[controller]")]
public class GenderTypesController : ReferenceControllerBase<GenderType>
{
    public GenderTypesController(ApplicationDbContext context) : base(context, "GenderType") { }
}

[ApiController]
[Route("api/[controller]")]
public class NationalityTypesController : ReferenceControllerBase<NationalityType>
{
    public NationalityTypesController(ApplicationDbContext context) : base(context, "NationalityType") { }
}

[ApiController]
[Route("api/[controller]")]
public class VeteranStatusTypesController : ReferenceControllerBase<VeteranStatusType>
{
    public VeteranStatusTypesController(ApplicationDbContext context) : base(context, "VeteranStatusType") { }
}

[ApiController]
[Route("api/[controller]")]
public class TerminationReasonsController : ReferenceControllerBase<TerminationReason>
{
    public TerminationReasonsController(ApplicationDbContext context) : base(context, "TerminationReason") { }
}
