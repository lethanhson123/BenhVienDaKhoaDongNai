namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_HoTroChiPhiNoiTruController : BaseController<CSKH_The_HoTroChiPhiNoiTru, ICSKH_The_HoTroChiPhiNoiTruService>
    {
    private readonly ICSKH_The_HoTroChiPhiNoiTruService _CSKH_The_HoTroChiPhiNoiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_HoTroChiPhiNoiTruController(ICSKH_The_HoTroChiPhiNoiTruService CSKH_The_HoTroChiPhiNoiTruService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_HoTroChiPhiNoiTruService, WebHostEnvironment)
    {
    _CSKH_The_HoTroChiPhiNoiTruService = CSKH_The_HoTroChiPhiNoiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

