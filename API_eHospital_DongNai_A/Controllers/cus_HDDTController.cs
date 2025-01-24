namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class cus_HDDTController : BaseController<cus_HDDT, Icus_HDDTService>
    {
    private readonly Icus_HDDTService _cus_HDDTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public cus_HDDTController(Icus_HDDTService cus_HDDTService, IWebHostEnvironment WebHostEnvironment) : base(cus_HDDTService, WebHostEnvironment)
    {
    _cus_HDDTService = cus_HDDTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

