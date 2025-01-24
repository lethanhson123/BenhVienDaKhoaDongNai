namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_PhanCongDeAn_1816Controller : BaseController<CDT_PhanCongDeAn_1816, ICDT_PhanCongDeAn_1816Service>
    {
    private readonly ICDT_PhanCongDeAn_1816Service _CDT_PhanCongDeAn_1816Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_PhanCongDeAn_1816Controller(ICDT_PhanCongDeAn_1816Service CDT_PhanCongDeAn_1816Service, IWebHostEnvironment WebHostEnvironment) : base(CDT_PhanCongDeAn_1816Service, WebHostEnvironment)
    {
    _CDT_PhanCongDeAn_1816Service = CDT_PhanCongDeAn_1816Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

