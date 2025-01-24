namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Transfer_VienPhi_ChiTiet_TempController : BaseController<Transfer_VienPhi_ChiTiet_Temp, ITransfer_VienPhi_ChiTiet_TempService>
    {
    private readonly ITransfer_VienPhi_ChiTiet_TempService _Transfer_VienPhi_ChiTiet_TempService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Transfer_VienPhi_ChiTiet_TempController(ITransfer_VienPhi_ChiTiet_TempService Transfer_VienPhi_ChiTiet_TempService, IWebHostEnvironment WebHostEnvironment) : base(Transfer_VienPhi_ChiTiet_TempService, WebHostEnvironment)
    {
    _Transfer_VienPhi_ChiTiet_TempService = Transfer_VienPhi_ChiTiet_TempService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

