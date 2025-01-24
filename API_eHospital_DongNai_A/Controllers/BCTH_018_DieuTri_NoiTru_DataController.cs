namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BCTH_018_DieuTri_NoiTru_DataController : BaseController<BCTH_018_DieuTri_NoiTru_Data, IBCTH_018_DieuTri_NoiTru_DataService>
    {
    private readonly IBCTH_018_DieuTri_NoiTru_DataService _BCTH_018_DieuTri_NoiTru_DataService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BCTH_018_DieuTri_NoiTru_DataController(IBCTH_018_DieuTri_NoiTru_DataService BCTH_018_DieuTri_NoiTru_DataService, IWebHostEnvironment WebHostEnvironment) : base(BCTH_018_DieuTri_NoiTru_DataService, WebHostEnvironment)
    {
    _BCTH_018_DieuTri_NoiTru_DataService = BCTH_018_DieuTri_NoiTru_DataService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

