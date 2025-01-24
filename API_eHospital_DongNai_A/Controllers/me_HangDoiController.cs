namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_HangDoiController : BaseController<me_HangDoi, Ime_HangDoiService>
    {
    private readonly Ime_HangDoiService _me_HangDoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_HangDoiController(Ime_HangDoiService me_HangDoiService, IWebHostEnvironment WebHostEnvironment) : base(me_HangDoiService, WebHostEnvironment)
    {
    _me_HangDoiService = me_HangDoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

