namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TransferController : BaseController<Transfer, ITransferService>
    {
    private readonly ITransferService _TransferService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TransferController(ITransferService TransferService, IWebHostEnvironment WebHostEnvironment) : base(TransferService, WebHostEnvironment)
    {
    _TransferService = TransferService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

