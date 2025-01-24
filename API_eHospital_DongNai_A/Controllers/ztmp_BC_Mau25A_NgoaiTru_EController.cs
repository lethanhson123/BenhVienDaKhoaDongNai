namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ztmp_BC_Mau25A_NgoaiTru_EController : BaseController<ztmp_BC_Mau25A_NgoaiTru_E, Iztmp_BC_Mau25A_NgoaiTru_EService>
    {
    private readonly Iztmp_BC_Mau25A_NgoaiTru_EService _ztmp_BC_Mau25A_NgoaiTru_EService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ztmp_BC_Mau25A_NgoaiTru_EController(Iztmp_BC_Mau25A_NgoaiTru_EService ztmp_BC_Mau25A_NgoaiTru_EService, IWebHostEnvironment WebHostEnvironment) : base(ztmp_BC_Mau25A_NgoaiTru_EService, WebHostEnvironment)
    {
    _ztmp_BC_Mau25A_NgoaiTru_EService = ztmp_BC_Mau25A_NgoaiTru_EService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

