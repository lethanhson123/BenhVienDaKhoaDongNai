namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_List_SourceFileController : BaseController<Sys_List_SourceFile, ISys_List_SourceFileService>
    {
    private readonly ISys_List_SourceFileService _Sys_List_SourceFileService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_List_SourceFileController(ISys_List_SourceFileService Sys_List_SourceFileService, IWebHostEnvironment WebHostEnvironment) : base(Sys_List_SourceFileService, WebHostEnvironment)
    {
    _Sys_List_SourceFileService = Sys_List_SourceFileService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

