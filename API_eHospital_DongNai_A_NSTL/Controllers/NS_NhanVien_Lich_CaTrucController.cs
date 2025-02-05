namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NhanVien_Lich_CaTrucController : BaseController<NS_NhanVien_Lich_CaTruc, INS_NhanVien_Lich_CaTrucService>
    {
    private readonly INS_NhanVien_Lich_CaTrucService _NS_NhanVien_Lich_CaTrucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NhanVien_Lich_CaTrucController(INS_NhanVien_Lich_CaTrucService NS_NhanVien_Lich_CaTrucService, IWebHostEnvironment WebHostEnvironment) : base(NS_NhanVien_Lich_CaTrucService, WebHostEnvironment)
    {
    _NS_NhanVien_Lich_CaTrucService = NS_NhanVien_Lich_CaTrucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

