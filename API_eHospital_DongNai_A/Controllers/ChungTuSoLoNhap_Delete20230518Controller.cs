namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuSoLoNhap_Delete20230518Controller : BaseController<ChungTuSoLoNhap_Delete20230518, IChungTuSoLoNhap_Delete20230518Service>
    {
    private readonly IChungTuSoLoNhap_Delete20230518Service _ChungTuSoLoNhap_Delete20230518Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTuSoLoNhap_Delete20230518Controller(IChungTuSoLoNhap_Delete20230518Service ChungTuSoLoNhap_Delete20230518Service, IWebHostEnvironment WebHostEnvironment) : base(ChungTuSoLoNhap_Delete20230518Service, WebHostEnvironment)
    {
    _ChungTuSoLoNhap_Delete20230518Service = ChungTuSoLoNhap_Delete20230518Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

