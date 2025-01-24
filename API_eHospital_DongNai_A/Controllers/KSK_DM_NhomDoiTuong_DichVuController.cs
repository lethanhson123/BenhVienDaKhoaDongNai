namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_DM_NhomDoiTuong_DichVuController : BaseController<KSK_DM_NhomDoiTuong_DichVu, IKSK_DM_NhomDoiTuong_DichVuService>
    {
    private readonly IKSK_DM_NhomDoiTuong_DichVuService _KSK_DM_NhomDoiTuong_DichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_DM_NhomDoiTuong_DichVuController(IKSK_DM_NhomDoiTuong_DichVuService KSK_DM_NhomDoiTuong_DichVuService, IWebHostEnvironment WebHostEnvironment) : base(KSK_DM_NhomDoiTuong_DichVuService, WebHostEnvironment)
    {
    _KSK_DM_NhomDoiTuong_DichVuService = KSK_DM_NhomDoiTuong_DichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

