namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_KeyOffline_Backup_040317Controller : BaseController<Sync_KeyOffline_Backup_040317, ISync_KeyOffline_Backup_040317Service>
    {
    private readonly ISync_KeyOffline_Backup_040317Service _Sync_KeyOffline_Backup_040317Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_KeyOffline_Backup_040317Controller(ISync_KeyOffline_Backup_040317Service Sync_KeyOffline_Backup_040317Service, IWebHostEnvironment WebHostEnvironment) : base(Sync_KeyOffline_Backup_040317Service, WebHostEnvironment)
    {
    _Sync_KeyOffline_Backup_040317Service = Sync_KeyOffline_Backup_040317Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

