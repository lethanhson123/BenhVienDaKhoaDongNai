namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_KeHoachDeAn_1816Controller : BaseController<DM_KeHoachDeAn_1816, IDM_KeHoachDeAn_1816Service>
    {
    private readonly IDM_KeHoachDeAn_1816Service _DM_KeHoachDeAn_1816Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_KeHoachDeAn_1816Controller(IDM_KeHoachDeAn_1816Service DM_KeHoachDeAn_1816Service, IWebHostEnvironment WebHostEnvironment) : base(DM_KeHoachDeAn_1816Service, WebHostEnvironment)
    {
    _DM_KeHoachDeAn_1816Service = DM_KeHoachDeAn_1816Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

