namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ztmp_BC_Mau25A_NgoaiTruController : BaseController<ztmp_BC_Mau25A_NgoaiTru, Iztmp_BC_Mau25A_NgoaiTruService>
    {
    private readonly Iztmp_BC_Mau25A_NgoaiTruService _ztmp_BC_Mau25A_NgoaiTruService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ztmp_BC_Mau25A_NgoaiTruController(Iztmp_BC_Mau25A_NgoaiTruService ztmp_BC_Mau25A_NgoaiTruService, IWebHostEnvironment WebHostEnvironment) : base(ztmp_BC_Mau25A_NgoaiTruService, WebHostEnvironment)
    {
    _ztmp_BC_Mau25A_NgoaiTruService = ztmp_BC_Mau25A_NgoaiTruService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

