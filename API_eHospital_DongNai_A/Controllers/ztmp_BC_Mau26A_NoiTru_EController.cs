namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ztmp_BC_Mau26A_NoiTru_EController : BaseController<ztmp_BC_Mau26A_NoiTru_E, Iztmp_BC_Mau26A_NoiTru_EService>
    {
    private readonly Iztmp_BC_Mau26A_NoiTru_EService _ztmp_BC_Mau26A_NoiTru_EService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ztmp_BC_Mau26A_NoiTru_EController(Iztmp_BC_Mau26A_NoiTru_EService ztmp_BC_Mau26A_NoiTru_EService, IWebHostEnvironment WebHostEnvironment) : base(ztmp_BC_Mau26A_NoiTru_EService, WebHostEnvironment)
    {
    _ztmp_BC_Mau26A_NoiTru_EService = ztmp_BC_Mau26A_NoiTru_EService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

