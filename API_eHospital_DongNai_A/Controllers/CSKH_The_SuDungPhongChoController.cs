namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_SuDungPhongChoController : BaseController<CSKH_The_SuDungPhongCho, ICSKH_The_SuDungPhongChoService>
    {
    private readonly ICSKH_The_SuDungPhongChoService _CSKH_The_SuDungPhongChoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_SuDungPhongChoController(ICSKH_The_SuDungPhongChoService CSKH_The_SuDungPhongChoService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_SuDungPhongChoService, WebHostEnvironment)
    {
    _CSKH_The_SuDungPhongChoService = CSKH_The_SuDungPhongChoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

