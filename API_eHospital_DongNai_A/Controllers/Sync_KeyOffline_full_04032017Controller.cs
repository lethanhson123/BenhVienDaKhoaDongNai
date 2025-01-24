namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_KeyOffline_full_04032017Controller : BaseController<Sync_KeyOffline_full_04032017, ISync_KeyOffline_full_04032017Service>
    {
    private readonly ISync_KeyOffline_full_04032017Service _Sync_KeyOffline_full_04032017Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_KeyOffline_full_04032017Controller(ISync_KeyOffline_full_04032017Service Sync_KeyOffline_full_04032017Service, IWebHostEnvironment WebHostEnvironment) : base(Sync_KeyOffline_full_04032017Service, WebHostEnvironment)
    {
    _Sync_KeyOffline_full_04032017Service = Sync_KeyOffline_full_04032017Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

