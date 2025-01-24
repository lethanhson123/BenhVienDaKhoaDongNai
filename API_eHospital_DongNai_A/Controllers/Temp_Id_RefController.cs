namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Temp_Id_RefController : BaseController<Temp_Id_Ref, ITemp_Id_RefService>
    {
    private readonly ITemp_Id_RefService _Temp_Id_RefService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Temp_Id_RefController(ITemp_Id_RefService Temp_Id_RefService, IWebHostEnvironment WebHostEnvironment) : base(Temp_Id_RefService, WebHostEnvironment)
    {
    _Temp_Id_RefService = Temp_Id_RefService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

