namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_PhauThuatTrongMiengController : BaseController<BenhAn_PhauThuatTrongMieng, IBenhAn_PhauThuatTrongMiengService>
    {
    private readonly IBenhAn_PhauThuatTrongMiengService _BenhAn_PhauThuatTrongMiengService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_PhauThuatTrongMiengController(IBenhAn_PhauThuatTrongMiengService BenhAn_PhauThuatTrongMiengService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_PhauThuatTrongMiengService, WebHostEnvironment)
    {
    _BenhAn_PhauThuatTrongMiengService = BenhAn_PhauThuatTrongMiengService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

