namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_DM_BenhNhan_KeyGeneration_Backup_040317Controller : BaseController<Sync_DM_BenhNhan_KeyGeneration_Backup_040317, ISync_DM_BenhNhan_KeyGeneration_Backup_040317Service>
    {
    private readonly ISync_DM_BenhNhan_KeyGeneration_Backup_040317Service _Sync_DM_BenhNhan_KeyGeneration_Backup_040317Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_DM_BenhNhan_KeyGeneration_Backup_040317Controller(ISync_DM_BenhNhan_KeyGeneration_Backup_040317Service Sync_DM_BenhNhan_KeyGeneration_Backup_040317Service, IWebHostEnvironment WebHostEnvironment) : base(Sync_DM_BenhNhan_KeyGeneration_Backup_040317Service, WebHostEnvironment)
    {
    _Sync_DM_BenhNhan_KeyGeneration_Backup_040317Service = Sync_DM_BenhNhan_KeyGeneration_Backup_040317Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

