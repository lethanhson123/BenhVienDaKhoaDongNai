namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_HopDong_KetQua_NHD_CLController : BaseController<KSK_HopDong_KetQua_NHD_CL, IKSK_HopDong_KetQua_NHD_CLService>
    {
    private readonly IKSK_HopDong_KetQua_NHD_CLService _KSK_HopDong_KetQua_NHD_CLService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_HopDong_KetQua_NHD_CLController(IKSK_HopDong_KetQua_NHD_CLService KSK_HopDong_KetQua_NHD_CLService, IWebHostEnvironment WebHostEnvironment) : base(KSK_HopDong_KetQua_NHD_CLService, WebHostEnvironment)
    {
    _KSK_HopDong_KetQua_NHD_CLService = KSK_HopDong_KetQua_NHD_CLService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

