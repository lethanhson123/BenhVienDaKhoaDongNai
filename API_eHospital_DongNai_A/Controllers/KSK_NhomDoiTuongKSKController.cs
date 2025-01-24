namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_NhomDoiTuongKSKController : BaseController<KSK_NhomDoiTuongKSK, IKSK_NhomDoiTuongKSKService>
    {
    private readonly IKSK_NhomDoiTuongKSKService _KSK_NhomDoiTuongKSKService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_NhomDoiTuongKSKController(IKSK_NhomDoiTuongKSKService KSK_NhomDoiTuongKSKService, IWebHostEnvironment WebHostEnvironment) : base(KSK_NhomDoiTuongKSKService, WebHostEnvironment)
    {
    _KSK_NhomDoiTuongKSKService = KSK_NhomDoiTuongKSKService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

