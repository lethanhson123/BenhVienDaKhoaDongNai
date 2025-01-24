namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Transfer_VienPhi_ChiTietController : BaseController<Transfer_VienPhi_ChiTiet, ITransfer_VienPhi_ChiTietService>
    {
    private readonly ITransfer_VienPhi_ChiTietService _Transfer_VienPhi_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Transfer_VienPhi_ChiTietController(ITransfer_VienPhi_ChiTietService Transfer_VienPhi_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(Transfer_VienPhi_ChiTietService, WebHostEnvironment)
    {
    _Transfer_VienPhi_ChiTietService = Transfer_VienPhi_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

