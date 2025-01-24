namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class His_CSKH_BenhNhan_GoiDichVuChiTietController : BaseController<His_CSKH_BenhNhan_GoiDichVuChiTiet, IHis_CSKH_BenhNhan_GoiDichVuChiTietService>
    {
    private readonly IHis_CSKH_BenhNhan_GoiDichVuChiTietService _His_CSKH_BenhNhan_GoiDichVuChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public His_CSKH_BenhNhan_GoiDichVuChiTietController(IHis_CSKH_BenhNhan_GoiDichVuChiTietService His_CSKH_BenhNhan_GoiDichVuChiTietService, IWebHostEnvironment WebHostEnvironment) : base(His_CSKH_BenhNhan_GoiDichVuChiTietService, WebHostEnvironment)
    {
    _His_CSKH_BenhNhan_GoiDichVuChiTietService = His_CSKH_BenhNhan_GoiDichVuChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

