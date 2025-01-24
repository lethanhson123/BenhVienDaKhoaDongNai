namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_SoThuTuTiepNhanController : BaseController<Lst_KeyData_SoThuTuTiepNhan, ILst_KeyData_SoThuTuTiepNhanService>
    {
    private readonly ILst_KeyData_SoThuTuTiepNhanService _Lst_KeyData_SoThuTuTiepNhanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_SoThuTuTiepNhanController(ILst_KeyData_SoThuTuTiepNhanService Lst_KeyData_SoThuTuTiepNhanService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_SoThuTuTiepNhanService, WebHostEnvironment)
    {
    _Lst_KeyData_SoThuTuTiepNhanService = Lst_KeyData_SoThuTuTiepNhanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

