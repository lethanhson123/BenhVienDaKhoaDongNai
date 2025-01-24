namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQua_XetNghiemController : BaseController<CLSKetQua_XetNghiem, ICLSKetQua_XetNghiemService>
    {
    private readonly ICLSKetQua_XetNghiemService _CLSKetQua_XetNghiemService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQua_XetNghiemController(ICLSKetQua_XetNghiemService CLSKetQua_XetNghiemService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQua_XetNghiemService, WebHostEnvironment)
    {
    _CLSKetQua_XetNghiemService = CLSKetQua_XetNghiemService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

