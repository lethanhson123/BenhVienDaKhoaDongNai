namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CUS_InvoicesController : BaseController<CUS_Invoices, ICUS_InvoicesService>
    {
    private readonly ICUS_InvoicesService _CUS_InvoicesService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CUS_InvoicesController(ICUS_InvoicesService CUS_InvoicesService, IWebHostEnvironment WebHostEnvironment) : base(CUS_InvoicesService, WebHostEnvironment)
    {
    _CUS_InvoicesService = CUS_InvoicesService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

