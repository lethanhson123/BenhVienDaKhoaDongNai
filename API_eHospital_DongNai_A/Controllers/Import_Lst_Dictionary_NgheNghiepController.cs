namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Import_Lst_Dictionary_NgheNghiepController : BaseController<Import_Lst_Dictionary_NgheNghiep, IImport_Lst_Dictionary_NgheNghiepService>
    {
    private readonly IImport_Lst_Dictionary_NgheNghiepService _Import_Lst_Dictionary_NgheNghiepService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Import_Lst_Dictionary_NgheNghiepController(IImport_Lst_Dictionary_NgheNghiepService Import_Lst_Dictionary_NgheNghiepService, IWebHostEnvironment WebHostEnvironment) : base(Import_Lst_Dictionary_NgheNghiepService, WebHostEnvironment)
    {
    _Import_Lst_Dictionary_NgheNghiepService = Import_Lst_Dictionary_NgheNghiepService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

