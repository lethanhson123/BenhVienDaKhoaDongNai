namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class His_XepLichChiTietController : BaseController<His_XepLichChiTiet, IHis_XepLichChiTietService>
    {
    private readonly IHis_XepLichChiTietService _His_XepLichChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public His_XepLichChiTietController(IHis_XepLichChiTietService His_XepLichChiTietService, IWebHostEnvironment WebHostEnvironment) : base(His_XepLichChiTietService, WebHostEnvironment)
    {
    _His_XepLichChiTietService = His_XepLichChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

