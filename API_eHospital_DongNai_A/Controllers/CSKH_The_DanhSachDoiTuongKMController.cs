namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_DanhSachDoiTuongKMController : BaseController<CSKH_The_DanhSachDoiTuongKM, ICSKH_The_DanhSachDoiTuongKMService>
    {
    private readonly ICSKH_The_DanhSachDoiTuongKMService _CSKH_The_DanhSachDoiTuongKMService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_DanhSachDoiTuongKMController(ICSKH_The_DanhSachDoiTuongKMService CSKH_The_DanhSachDoiTuongKMService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_DanhSachDoiTuongKMService, WebHostEnvironment)
    {
    _CSKH_The_DanhSachDoiTuongKMService = CSKH_The_DanhSachDoiTuongKMService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

